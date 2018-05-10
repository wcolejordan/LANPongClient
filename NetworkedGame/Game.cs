using System;
using System.Drawing;
using System.Windows.Forms;

namespace NetworkedGame
{
    public partial class Game : Form
    {
        //Initialize and define variables
        PictureBox ball = new PictureBox();
        PictureBox paddle = new PictureBox();
        PictureBox opponentPaddle = new PictureBox();
        GameCons network;
        MessageHandler message;
        
        int pointsA = 0;
        int pointsB = 0;

        int pSpeed = 15; //paddle speed

        Timer timerSend; 
        Timer timerRecieve;

        String ab;

        public Game(String ab, String portA, String portB, String playerName)
        {
            //Set up game basics
            this.ab = ab;
            InitializeComponent();
            network = new GameCons(Int32.Parse(portA), Int32.Parse(portB));
            message = new MessageHandler();
            //initialize key events
            KeyDown += new KeyEventHandler(key);
            this.KeyPreview = true;
            //set colours and sizes
            ball.BackColor = Color.Lime;
            ball.Size = new Size(20,20);
            paddle.BackColor = Color.Lime;

            paddle.Size = new Size(15,70);
            opponentPaddle.BackColor = Color.Lime;
            opponentPaddle.Size = new Size(15, 70);
            //Add to table
            pongTable.Controls.Add(ball);
            pongTable.Controls.Add(paddle);
            pongTable.Controls.Add(opponentPaddle);

            ball.Location = new Point(pongTable.Size.Width / 2, (pongTable.Size.Height / 2) - 15);
            ball.BringToFront(); //Make sure ball is in front of other Graphics

            //Check token player has been allocated by server so they are controlling the correct paddle
            if (ab.Equals("A"))
            {
                //Display names
                labelA.Text = Player.alias;
                labelB.Text = playerName;
                //Set paddles
                paddle.Location = new Point(0, (pongTable.Size.Height / 2) - 35);
                opponentPaddle.Location = new Point(pongTable.Size.Width - 15, (pongTable.Size.Height / 2) - 35);
            }
            else if (ab.Equals("B"))
            {
                //Display names
                labelA.Text = playerName;
                labelB.Text = Player.alias;
                //Set paddles
                opponentPaddle.Location = new Point(0, (pongTable.Size.Height / 2) - 35);
                paddle.Location = new Point(pongTable.Size.Width - 15, (pongTable.Size.Height / 2) - 35);
            }
            //Set up timers
            timerSend = new Timer();
            timerSend.Enabled = true;
            timerSend.Interval = 40;
            timerSend.Tick += new EventHandler(send);

            timerRecieve = new Timer();
            timerRecieve.Enabled = true;
            timerRecieve.Interval = 25;
            timerRecieve.Tick += new EventHandler(recieve);
        }

        private void send(object sender, EventArgs e)
        {
            sendPaddle(); //Send paddle location
        }

        private void recieve(object sender, EventArgs e)
        {
            gameInfo(network.rcvUDP()); //recieve locations
            scoreLabelA.Text = pointsA.ToString(); //Update points labels
            scoreLabelB.Text = pointsB.ToString();
        }


        private void gameInfo(String message)
        {
            if (message != null) //If a message is there
            {
                System.Diagnostics.Debug.WriteLine(message);
                String temp = message.Substring(0, 3); //Take message code
                message = message.Substring(4, message.Length - 4); //Trim code from message
                if (message != null)
                {
                    if (temp.Equals("300"))  //Basic game data
                    {
                        String[] info = message.Split();
                        opponentPaddle.Location = new Point(opponentPaddle.Location.X, int.Parse(info[0].Trim()));
                        ball.Location = new Point(int.Parse(info[2].Trim()), int.Parse(info[1].Trim()));
                        pointsA = int.Parse(info[3].Trim());
                        pointsB = int.Parse(info[4].Trim());
                    }
                    if (temp.Equals("410")) //Game has been cancelled
                    {
                        //Disable controls and show exit label
                        paddle.Visible = false;
                        opponentPaddle.Visible = false;
                        ball.Visible = false;
                        exitLabel.Visible = true;
                    }

                    if (temp.Equals("420"))//A player has won
                    {
                        String[] points = message.Split();
                        pointsA = Convert.ToInt32(points[0].Trim());
                        pointsB = Convert.ToInt32(points[1].Trim()); //Update points 
                        scoreLabelA.Text = pointsA.ToString();
                        scoreLabelB.Text = pointsB.ToString(); //Update points labels
                        paddle.Visible = false; //Disable controls
                        opponentPaddle.Visible = false;
                        ball.Visible = false;
                        timerSend.Enabled = false; //Disable timers
                        timerRecieve.Enabled = false;
                        //Check who won and display
                        if (pointsA == 10)
                        {
                            exitLabel.Text = labelA.Text + " wins";
                        }
                        if (pointsB == 10)
                        {
                            exitLabel.Text = labelB.Text + " wins";
                        } 
                        exitLabel.Visible = true;
                    }
                }
            }
        }

        private void sendPaddle()
        {
            //Paddle message
            network.sendUDP(message.generateMessage("330", ab, paddle.Location.Y.ToString()));
        }

        private void key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (paddle.Top + 70 + pSpeed < pongTable.Size.Height)
                {
                    //Move paddle down
                    paddle.Location = new Point(paddle.Location.X, paddle.Location.Y + pSpeed);
                }
            }
            else if (e.KeyCode == Keys.Up)
            { 
                if (paddle.Top - pSpeed > 0) 
                {
                    //Move paddle up
                    paddle.Location = new Point(paddle.Location.X, paddle.Location.Y - pSpeed);
                }
                        
            }

            if (e.KeyCode == Keys.Space)
            {
                network.sendUDP(message.generateMessage("340", "")); //ready up for next point
            }
        }

        private void Game_OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (network != null) //if network there [not a stream instance]
            {
                //disable timers, update server and close sockets
                timerSend.Enabled = false;
                timerRecieve.Enabled = false;
                network.sendUDP(message.generateMessage("400", "close"));
                network.close();
            }
        }

        //STREAM INSTANCE
        public Game(String playerA, String playerB) //Takes player names
        {
            //Set up table
            InitializeComponent();
            ball.BackColor = Color.Lime;
            ball.Size = new Size(20, 20);
            paddle.BackColor = Color.Lime;

            paddle.Size = new Size(15, 70);
            opponentPaddle.BackColor = Color.Lime;
            opponentPaddle.Size = new Size(15, 70);

            pongTable.Controls.Add(ball);
            pongTable.Controls.Add(paddle);
            pongTable.Controls.Add(opponentPaddle);

            ball.Location = new Point(pongTable.Size.Width / 2, (pongTable.Size.Height / 2) - 15);
            ball.BringToFront();
            labelA.Text = playerA;
            labelB.Text = playerB;
            paddle.Location = new Point(0, (pongTable.Size.Height / 2) - 35);
            opponentPaddle.Location = new Point(pongTable.Size.Width - 15, (pongTable.Size.Height / 2) - 35);
        }

        public void updateStream(int paddleA, int paddleB, int bally, int ballx, int pointsA, int pointsB)
        {
            //Similar to 300 game message but updates both paddles
            paddle.Location = new Point(paddle.Location.X, paddleA);
            opponentPaddle.Location = new Point(opponentPaddle.Location.X, paddleB);
            ball.Location = new Point(ballx, bally);
            this.pointsA = pointsA;
            this.pointsB = pointsB;
            scoreLabelA.Text = pointsA.ToString();
            scoreLabelB.Text = pointsB.ToString();
        }

        //Player has left unexpectedly or game end
        public void streamCancelled()
        {
            paddle.Visible = false;
            opponentPaddle.Visible = false;
            ball.Visible = false;
            exitLabel.Text = "A player has left the game please exit";
            //checks if there was a winner or if it was an unexpected exit and displays correct message
            if (pointsA == 10)
            {
                exitLabel.Text = labelA.Text + " wins";
            }
            if (pointsB == 10)
            {
                exitLabel.Text = labelB.Text + " wins";
            }
            exitLabel.Visible = true;
        }
    }
}
