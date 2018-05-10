namespace NetworkedGame
{
    partial class Invite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invite));
            this.AcceptButton = new System.Windows.Forms.Button();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.InviteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AcceptButton.ForeColor = System.Drawing.Color.Lime;
            this.AcceptButton.Location = new System.Drawing.Point(13, 72);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(4);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(179, 28);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // DeclineButton
            // 
            this.DeclineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeclineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeclineButton.ForeColor = System.Drawing.Color.Lime;
            this.DeclineButton.Location = new System.Drawing.Point(200, 72);
            this.DeclineButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(166, 28);
            this.DeclineButton.TabIndex = 1;
            this.DeclineButton.Text = "Decline";
            this.DeclineButton.UseVisualStyleBackColor = false;
            this.DeclineButton.Click += new System.EventHandler(this.DeclineButton_Click);
            // 
            // InviteLabel
            // 
            this.InviteLabel.AutoSize = true;
            this.InviteLabel.ForeColor = System.Drawing.Color.Lime;
            this.InviteLabel.Location = new System.Drawing.Point(24, 20);
            this.InviteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InviteLabel.Name = "InviteLabel";
            this.InviteLabel.Size = new System.Drawing.Size(46, 17);
            this.InviteLabel.TabIndex = 2;
            this.InviteLabel.Text = "label1";
            // 
            // Invite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(379, 126);
            this.Controls.Add(this.InviteLabel);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.AcceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Invite";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Invite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button DeclineButton;
        private System.Windows.Forms.Label InviteLabel;
    }
}