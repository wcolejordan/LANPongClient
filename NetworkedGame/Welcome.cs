using System;
using System.Windows.Forms;

namespace NetworkedGame
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            //Find and display IP
            InitializeComponent();
            Player.setIP();
            IPLabel.Text = "Your IP: " + Player.IP;
            
        }

        private void LobbyButton_Click(object sender, EventArgs e)
        {
            String[] temp = AliasBox.Text.Split();
            if (AliasBox.Text != "" && temp.Length < 2) //Checks no spaces in alias
            {
                Player.setAlias(AliasBox.Text); //Sets alias
                LocateServer locServer = new LocateServer(); //Start server location
                locServer.Show();
                this.Hide();
            }
            else
            {
                ErrorLabel.Text = "Please enter a name with no spaces.";
                temp = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show help menu
            Learn learn = new Learn();
            learn.Show();
        }
    }
}
