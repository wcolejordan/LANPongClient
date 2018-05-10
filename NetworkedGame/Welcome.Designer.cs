namespace NetworkedGame
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel2 = new System.Windows.Forms.Label();
            this.AliasBox = new System.Windows.Forms.TextBox();
            this.LobbyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Lime;
            this.WelcomeLabel.Location = new System.Drawing.Point(17, 16);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(177, 17);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to Network Pong!";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.BackColor = System.Drawing.Color.Black;
            this.IPLabel.ForeColor = System.Drawing.Color.Lime;
            this.IPLabel.Location = new System.Drawing.Point(21, 263);
            this.IPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(0, 17);
            this.IPLabel.TabIndex = 1;
            // 
            // WelcomeLabel2
            // 
            this.WelcomeLabel2.AutoSize = true;
            this.WelcomeLabel2.ForeColor = System.Drawing.Color.Lime;
            this.WelcomeLabel2.Location = new System.Drawing.Point(17, 58);
            this.WelcomeLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel2.Name = "WelcomeLabel2";
            this.WelcomeLabel2.Size = new System.Drawing.Size(240, 17);
            this.WelcomeLabel2.TabIndex = 2;
            this.WelcomeLabel2.Text = "Please enter a name with no spaces:";
            // 
            // AliasBox
            // 
            this.AliasBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AliasBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AliasBox.ForeColor = System.Drawing.Color.Lime;
            this.AliasBox.Location = new System.Drawing.Point(21, 79);
            this.AliasBox.Margin = new System.Windows.Forms.Padding(4);
            this.AliasBox.Name = "AliasBox";
            this.AliasBox.Size = new System.Drawing.Size(132, 22);
            this.AliasBox.TabIndex = 3;
            // 
            // LobbyButton
            // 
            this.LobbyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LobbyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LobbyButton.ForeColor = System.Drawing.Color.Lime;
            this.LobbyButton.Location = new System.Drawing.Point(21, 158);
            this.LobbyButton.Margin = new System.Windows.Forms.Padding(4);
            this.LobbyButton.Name = "LobbyButton";
            this.LobbyButton.Size = new System.Drawing.Size(136, 30);
            this.LobbyButton.TabIndex = 4;
            this.LobbyButton.Text = "Go To Lobby";
            this.LobbyButton.UseVisualStyleBackColor = false;
            this.LobbyButton.Click += new System.EventHandler(this.LobbyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(21, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Once you have entered a name please click the button below!";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.Black;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Lime;
            this.ErrorLabel.Location = new System.Drawing.Point(21, 233);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.ErrorLabel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(21, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "How To Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(471, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LobbyButton);
            this.Controls.Add(this.AliasBox);
            this.Controls.Add(this.WelcomeLabel2);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Network Pong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label WelcomeLabel2;
        private System.Windows.Forms.TextBox AliasBox;
        private System.Windows.Forms.Button LobbyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button button1;
    }
}

