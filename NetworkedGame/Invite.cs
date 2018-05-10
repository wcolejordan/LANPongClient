using System;
using System.Windows.Forms;

namespace NetworkedGame
{
    public partial class Invite : Form
    {
        //Define variables
        MessageHandler message;
        NetCons network;
        String aliasA;
        String aliasB;

        public Invite(String aliasA, String aliasB)
        {
            this.aliasA = aliasA;
            this.aliasB = aliasB;
            InitializeComponent();
            //Set label message
            InviteLabel.Text = aliasA + " has invited you to a game! Accept or decline ";
            message = new MessageHandler();
            network = NetCons.getInstance(); //Get NetCons instance
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            //Send confirm message
            network.sendUDP(message.generateMessage("130", aliasA, aliasB));
            this.Close();
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
