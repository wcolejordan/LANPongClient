using System;
using System.Windows.Forms;

namespace NetworkedGame
{
    public partial class LocateServer : Form
    {
        //Get instance and define variables
        NetCons network = NetCons.getInstance();
        MessageHandler message;

        Timer timerSend;
        Timer timerRecieve;

        public LocateServer()
        {
            InitializeComponent();
            //Initialize message handler and timers
            message = new MessageHandler();
            timerSend = new Timer();
            timerSend.Enabled = true;
            timerSend.Interval = 500;
            timerSend.Tick += new EventHandler(send);

            timerRecieve = new Timer();
            timerRecieve.Enabled = true;
            timerRecieve.Interval = 500;
            timerRecieve.Tick += new EventHandler(recieve);
        }

        public void send(object sender, EventArgs e)
        {
            //Broadcast server probe
            network.broadcastUDP(message.generateMessage("105", Player.IP));
        }

        public void recieve(object sender, EventArgs e)
        {
            //Checks if server hasn't been recieved yet
            if (Player.serverIP == null)
            {
                //Process server IP
                message.processServerLoc(network.rcvUDP());
            } 
            else //If recieved
            { 
                //End timers
                timerSend.Enabled = false;
                timerRecieve.Enabled = false;
                //Open Lobby
                Lobby lobby = new Lobby();
                lobby.Show();
                this.Hide();
            }
        }
    }
}
