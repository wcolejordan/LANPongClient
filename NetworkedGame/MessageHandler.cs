using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkedGame
{
    public class MessageHandler
    {
        //Define variables
        TextBox privateBox;
        TextBox broadcastBox;
        public List<Users> users;
        public List<CurrentGames> currentGames;
        NetCons network = NetCons.getInstance();
        BindingSource bindPlayers;
        BindingSource bindGames;
        Game gameStream;

        public MessageHandler()
        {
            //list of connected players
            users = new List<Users>();
        }

        public MessageHandler(TextBox privateBox, TextBox broadcastBox, BindingSource bindPlayers, BindingSource bindGames)
        {
            //Initialize variables
            this.bindPlayers = bindPlayers;
            this.bindGames = bindGames;
            this.privateBox = privateBox;
            this.broadcastBox = broadcastBox;
            users = new List<Users>();
            currentGames = new List<CurrentGames>();
        }

        public byte[] generateMessage(String code, String overload1) //1 variable message
        {
            String temp = code + " " + overload1; //concatonate string
            byte[] data = Encoding.ASCII.GetBytes(temp); //convert to bytes 
            return data; //returns message
        }

        public byte[] generateMessage(String code, String overload1, String overload2) //2 variable message
        {
            String temp = code + " " + overload1 + " " + overload2; //concatonate string
            byte[] data = Encoding.ASCII.GetBytes(temp); //convert to bytes 
            return data; //returns message
        }

        public byte[] generateMessage(String code, String overload1, String overload2, String overload3) //3 variable message
        {
            String temp = code + " " + overload1 + " " + overload2 + " " + overload3;//concatonate string
            byte[] data = Encoding.ASCII.GetBytes(temp); //convert to bytes 
            return data; //return message
        }

        public void processServerLoc(String message) //For server locating
        {
            if (message != null) //if there is a message
            {
                String temp = message.Substring(0, 3); //message code
                message = message.Substring(4, message.Length - 4); //message
                System.Diagnostics.Debug.WriteLine(message);
                if (message != null)
                {
                    if (temp.Equals("106") && Player.serverIP == null) //broadcast of lobby members
                    {
                        String[] tempInfo = message.Split();
                        Player.setServerIP(tempInfo[0].Trim()); //Set server IP
                    }
                }
            }
        }

        public void processMessage(String message)
        {
            System.Diagnostics.Debug.WriteLine(message);
            if (message != null)
            {
                String temp = message.Substring(0, 3); //message code
                message = message.Substring(4, message.Length - 4); // message
                System.Diagnostics.Debug.WriteLine(message);
                if (message != null)
                {
                    if (temp.Equals("200")) //broadcast of lobby members
                    {
                        String[] tempInfo = message.Split();
                        for (int i = 0; i < tempInfo.Length - 1; i += 2) //Cycle through message one user at a time
                        {
                            if (users.FirstOrDefault(o => o.alias.Equals(tempInfo[i].Trim())) == null)
                            {
                                users.Add(new Users(tempInfo[i + 1].Trim(), tempInfo[i].Trim())); //add users alias/IP
                                bindPlayers.ResetBindings(false); //reset list box
                            }
                        }
                    }

                    if (temp.Equals("205")) //User removal
                    {
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].alias.Equals(message.Trim()))
                            {
                                users.RemoveAt(i); //remove from user list
                                bindPlayers.ResetBindings(false); //update listbox
                            }
                        }
                    }

                    else if (temp.Equals("210")) //invitation recieved
                    {
                        String[] tempAliases = message.Split();
                        String tempA = tempAliases[0];
                        String tempB = tempAliases[1].Trim();
                        Invite inv = new Invite(tempA, tempB); //Opens invite popup
                        inv.ShowDialog();
                    }
                    else if (temp.Equals("220")) //recieve broadcast message
                    {
                        String[] iBroadcast = message.Split(); //incoming broadcast
                        String tempA = iBroadcast[0];
                        int tempInt = tempA.Length + 1; //find start index of message
                        String tempMessage = message.Substring(tempInt);
                        broadcastBox.AppendText(tempA + ": " + tempMessage + "\r\n");//display message and start new line
                    }
                    else if (temp.Equals("230")) //recieve private message
                    {
                        String[] iPrivate = message.Split();
                        String tempA = iPrivate[0];
                        int tempInt = tempA.Length + 1; //find start index of message
                        String tempMessage = message.Substring(tempInt);
                        privateBox.AppendText(tempA + ": " + tempMessage + "\r\n");//display message and start new line
                    }


                    if (temp.Equals("250")) //Recieve current game list
                    {
                        String[] tempInfo = message.Split();
                        for (int i = 0; i < tempInfo.Length - 1; i += 2) //cycle one game at a time
                        {
                            if (currentGames.FirstOrDefault(o => o.playerA.Equals(tempInfo[i].Trim()) && o.playerB.Equals(tempInfo[i + 1].Trim())) == null)
                            {
                                //add to list of games
                                currentGames.Add(new CurrentGames(tempInfo[i].Trim(), tempInfo[i + 1].Trim()));
                                bindGames.ResetBindings(false);
                            }
                        }
                    }

                    if (temp.Equals("255")) //remove unactive games from list
                    {
                        String[] tempInfo = message.Split();
                        for (int i = 0; i < currentGames.Count; i++) //cycle games
                        {
                            //check for game
                            if (currentGames[i].playerA.Equals(tempInfo[0].Trim()) && currentGames[i].playerB.Equals(tempInfo[1].Trim()))
                            {
                                //remove game
                                currentGames.RemoveAt(i);
                                //update box
                                bindGames.ResetBindings(false);
                            }
                        }
                    }


                    if (temp.Equals("320")) //Game start
                    {
                        String[] tempInfo = message.Split();
                        String tempAB = tempInfo[0];
                        String tempPortA = tempInfo[1].Trim();
                        String tempPortB = tempInfo[2].Trim();
                        String playerName = tempInfo[3].Trim();
                        //Check game token
                        if (tempAB.Equals("A"))
                        {
                            //Create instance and display
                            Game game = new Game("A", tempPortA, tempPortB, playerName);
                            game.Show();
                        }
                        else if (tempAB.Equals("B"))
                        {
                            //Create instance and display
                            Game game = new Game("B", tempPortA, tempPortB, playerName);
                            game.Show();
                        }
                    }

                    if (temp.Equals("500")) //Stream message
                    {
                        if (gameStream != null)//If stream active
                        {
                            //get message info
                            String[] tempInfo = message.Split();
                            int paddleA = Convert.ToInt32(tempInfo[0]);
                            int paddleB = Convert.ToInt32(tempInfo[1].Trim());
                            int bally = Convert.ToInt32(tempInfo[2].Trim());
                            int ballx = Convert.ToInt32(tempInfo[3].Trim());
                            int pointsA = Convert.ToInt32(tempInfo[4].Trim());
                            int pointsB = Convert.ToInt32(tempInfo[5].Trim());
                            //feed into stream
                            gameStream.updateStream(paddleA, paddleB, bally, ballx, pointsA, pointsB);
                        }
                    }
                    if (temp.Equals("510")) //Stream end
                    {
                        String[] points = message.Split();
                        int pointsA = Convert.ToInt32(points[0].Trim());
                        int pointsB = Convert.ToInt32(points[1].Trim());
                        if (gameStream != null) //if stream still active
                        {
                            //update final points
                            gameStream.updateStream(0, 0, 0, 0, pointsA, pointsB);
                            gameStream.streamCancelled(); //Ends stream
                            gameStream = null; //deletes instance
                        }
                    }
                }
            }
        }

        public void addGameStream(Game game)
        {
            if (gameStream != null)
            {
                gameStream.Close();
                gameStream = null;
            }
            gameStream = game;
        }
    }
}
