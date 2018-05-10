namespace NetworkedGame
{
    partial class Lobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.InfoLabel = new System.Windows.Forms.Label();
            this.playerBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inviteButton = new System.Windows.Forms.Button();
            this.messageButton = new System.Windows.Forms.Button();
            this.currentBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.watchButton = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.broadcastButton = new System.Windows.Forms.Button();
            this.broadcastBox = new System.Windows.Forms.TextBox();
            this.privateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(16, 11);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 17);
            this.InfoLabel.TabIndex = 0;
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerBox.ForeColor = System.Drawing.Color.Lime;
            this.playerBox.FormattingEnabled = true;
            this.playerBox.ItemHeight = 16;
            this.playerBox.Location = new System.Drawing.Point(16, 64);
            this.playerBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(371, 130);
            this.playerBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available players:";
            // 
            // inviteButton
            // 
            this.inviteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inviteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inviteButton.ForeColor = System.Drawing.Color.Lime;
            this.inviteButton.Location = new System.Drawing.Point(16, 204);
            this.inviteButton.Margin = new System.Windows.Forms.Padding(4);
            this.inviteButton.Name = "inviteButton";
            this.inviteButton.Size = new System.Drawing.Size(149, 28);
            this.inviteButton.TabIndex = 3;
            this.inviteButton.Text = "Invite Selected";
            this.inviteButton.UseVisualStyleBackColor = false;
            this.inviteButton.Click += new System.EventHandler(this.inviteButton_Click);
            // 
            // messageButton
            // 
            this.messageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.messageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.messageButton.ForeColor = System.Drawing.Color.Lime;
            this.messageButton.Location = new System.Drawing.Point(455, 386);
            this.messageButton.Margin = new System.Windows.Forms.Padding(4);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(153, 28);
            this.messageButton.TabIndex = 4;
            this.messageButton.Text = "Send Private";
            this.messageButton.UseVisualStyleBackColor = false;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // currentBox
            // 
            this.currentBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentBox.ForeColor = System.Drawing.Color.Lime;
            this.currentBox.FormattingEnabled = true;
            this.currentBox.ItemHeight = 16;
            this.currentBox.Location = new System.Drawing.Point(16, 261);
            this.currentBox.Margin = new System.Windows.Forms.Padding(4);
            this.currentBox.Name = "currentBox";
            this.currentBox.Size = new System.Drawing.Size(371, 114);
            this.currentBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(16, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current games:";
            // 
            // watchButton
            // 
            this.watchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.watchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.watchButton.ForeColor = System.Drawing.Color.Lime;
            this.watchButton.Location = new System.Drawing.Point(16, 386);
            this.watchButton.Margin = new System.Windows.Forms.Padding(4);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(149, 28);
            this.watchButton.TabIndex = 7;
            this.watchButton.Text = "Watch game";
            this.watchButton.UseVisualStyleBackColor = false;
            this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageBox.ForeColor = System.Drawing.Color.Lime;
            this.messageBox.Location = new System.Drawing.Point(455, 352);
            this.messageBox.Margin = new System.Windows.Forms.Padding(4);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(319, 22);
            this.messageBox.TabIndex = 8;
            // 
            // broadcastButton
            // 
            this.broadcastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.broadcastButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.broadcastButton.ForeColor = System.Drawing.Color.Lime;
            this.broadcastButton.Location = new System.Drawing.Point(616, 386);
            this.broadcastButton.Margin = new System.Windows.Forms.Padding(4);
            this.broadcastButton.Name = "broadcastButton";
            this.broadcastButton.Size = new System.Drawing.Size(159, 28);
            this.broadcastButton.TabIndex = 9;
            this.broadcastButton.Text = "Send Public";
            this.broadcastButton.UseVisualStyleBackColor = false;
            this.broadcastButton.Click += new System.EventHandler(this.broadcastButton_Click);
            // 
            // broadcastBox
            // 
            this.broadcastBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.broadcastBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.broadcastBox.ForeColor = System.Drawing.Color.Lime;
            this.broadcastBox.Location = new System.Drawing.Point(455, 64);
            this.broadcastBox.Margin = new System.Windows.Forms.Padding(4);
            this.broadcastBox.Multiline = true;
            this.broadcastBox.Name = "broadcastBox";
            this.broadcastBox.Size = new System.Drawing.Size(319, 132);
            this.broadcastBox.TabIndex = 10;
            // 
            // privateBox
            // 
            this.privateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.privateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.privateBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.privateBox.ForeColor = System.Drawing.Color.Lime;
            this.privateBox.Location = new System.Drawing.Point(455, 261);
            this.privateBox.Margin = new System.Windows.Forms.Padding(4);
            this.privateBox.Multiline = true;
            this.privateBox.Name = "privateBox";
            this.privateBox.Size = new System.Drawing.Size(319, 79);
            this.privateBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(455, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Public messages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(455, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Private messages";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(791, 460);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.privateBox);
            this.Controls.Add(this.broadcastBox);
            this.Controls.Add(this.broadcastButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.watchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentBox);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.inviteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Lobby";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lobby";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lobby_OnFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.ListBox playerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inviteButton;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.ListBox currentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button broadcastButton;
        private System.Windows.Forms.TextBox broadcastBox;
        private System.Windows.Forms.TextBox privateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}