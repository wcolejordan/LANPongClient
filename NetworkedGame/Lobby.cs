using System;
using System.Windows.Forms;

namespace NetworkedGame
{
    public partial class Lobby : Form
    {
        NetCons network = NetCons.getInstance(); //Get NetCons instance
        //Define variables
        MessageHandler message;
        Timer timerSend;
        Timer timerRecieve;
        BindingSource bindPlayers = new BindingSource(); //for proper updates to controls
        BindingSource bindGames = new BindingSource();

        public Lobby()
        {
            InitializeComponent();
            message = new MessageHandler(privateBox, broadcastBox, bindPlayers, bindGames);
            InfoLabel.Text = "Hello, " + Player.alias + ". Your IP is: " + Player.IP; //Display info label
            playerBox.DisplayMember = "alias";
            bindPlayers.DataSource = message.users; //bind source
            playerBox.DataSource = bindPlayers;

            currentBox.DisplayMember = "versus";
            bindGames.DataSource = message.currentGames; //bind source
            currentBox.DataSource = bindGames;
            //Initialize timers
            timerSend = new Timer();
            timerSend.Enabled = true;
            timerSend.Interval = 500;
            timerSend.Tick += new EventHandler(send);

            timerRecieve = new Timer();
            timerRecieve.Enabled = true;
            timerRecieve.Interval = 25;
            timerRecieve.Tick += new EventHandler(recieve);
        }

        public void send(object sender, EventArgs e)
        {
            //Send message to server notifying still connected
            network.sendUDP(message.generateMessage("100", Player.alias + " " + Player.IP));
        }

        public void recieve(object sender, EventArgs e)
        {
            //Receive messages from server
            message.processMessage(network.rcvUDP());
        }

        private void inviteButton_Click(object sender, EventArgs e)
        {
            if (playerBox.SelectedItem != null) //Checks an item is selected
            {
                //Get name from player list
                String alias = (playerBox.SelectedItem as Users).alias;
                if (!alias.Equals(Player.alias)) //Checks not inviting yourself
                {
                    //Send request to server
                    network.sendUDP(message.generateMessage("120", Player.alias, alias)); 
                }
            }
        }

        private void broadcastButton_Click(object sender, EventArgs e)
        {
            //Get message from box and send
            String newMessage = messageBox.Text;
            network.sendUDP(message.generateMessage("140", Player.alias, newMessage));
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            if (playerBox.SelectedItem != null) //Checks an item is selected
            {
                //Get name from player list
                String alias = (playerBox.SelectedItem as Users).alias;
                String newMessage = messageBox.Text;
                //Sends message to server
                network.sendUDP(message.generateMessage("150", Player.alias, alias, newMessage));
            } 
        }

        private void Lobby_OnFormClosing(object sender, FormClosingEventArgs e)
        {
            //Disables timers, sends leaving lobby message and exits
            timerSend.Enabled = false;
            timerRecieve.Enabled = false;
            network.sendUDP(message.generateMessage("110", Player.alias));
            Application.Exit();
        }

        private void watchButton_Click(object sender, EventArgs e)
        {
            if (currentBox.SelectedItem != null) //Checks if any selected
            {
                String playerA = (currentBox.SelectedItem as CurrentGames).playerA;
                String playerB = (currentBox.SelectedItem as CurrentGames).playerB;
                //Sends stream request to server
                network.sendUDP(message.generateMessage("160", Player.IP, playerA, playerB));
                //Creates game instance ready for stream
                Game game = new Game(playerA, playerB);
                //Show window
                game.Show();
                //Add instance to MessageHandler
                message.addGameStream(game);
            }
        }
    }
}
