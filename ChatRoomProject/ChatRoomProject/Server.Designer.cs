namespace ChatRoomProject
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MessageBox = new System.Windows.Forms.GroupBox();
            this.DisplayMessage = new System.Windows.Forms.TextBox();
            this.UserOnlineBox = new System.Windows.Forms.GroupBox();
            this.User = new System.Windows.Forms.ListBox();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnLogOn = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.DisplayPort = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.DisplayIp = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.menuBar.SuspendLayout();
            this.MessageBox.SuspendLayout();
            this.UserOnlineBox.SuspendLayout();
            this.InfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(376, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(116, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // MessageBox
            // 
            this.MessageBox.Controls.Add(this.DisplayMessage);
            this.MessageBox.Location = new System.Drawing.Point(184, 125);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(178, 240);
            this.MessageBox.TabIndex = 6;
            this.MessageBox.TabStop = false;
            this.MessageBox.Text = "Chat";
            // 
            // DisplayMessage
            // 
            this.DisplayMessage.Location = new System.Drawing.Point(6, 21);
            this.DisplayMessage.Multiline = true;
            this.DisplayMessage.Name = "DisplayMessage";
            this.DisplayMessage.ReadOnly = true;
            this.DisplayMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayMessage.Size = new System.Drawing.Size(164, 212);
            this.DisplayMessage.TabIndex = 2;
            // 
            // UserOnlineBox
            // 
            this.UserOnlineBox.Controls.Add(this.User);
            this.UserOnlineBox.Location = new System.Drawing.Point(15, 125);
            this.UserOnlineBox.Name = "UserOnlineBox";
            this.UserOnlineBox.Size = new System.Drawing.Size(163, 240);
            this.UserOnlineBox.TabIndex = 5;
            this.UserOnlineBox.TabStop = false;
            this.UserOnlineBox.Text = "Online User";
            // 
            // User
            // 
            this.User.FormattingEnabled = true;
            this.User.ItemHeight = 16;
            this.User.Location = new System.Drawing.Point(6, 21);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(151, 212);
            this.User.TabIndex = 0;
            // 
            // InfoBox
            // 
            this.InfoBox.Controls.Add(this.btnLogOff);
            this.InfoBox.Controls.Add(this.btnLogOn);
            this.InfoBox.Controls.Add(this.txtPort);
            this.InfoBox.Controls.Add(this.DisplayPort);
            this.InfoBox.Controls.Add(this.txtIP);
            this.InfoBox.Controls.Add(this.DisplayIp);
            this.InfoBox.Location = new System.Drawing.Point(15, 34);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(347, 85);
            this.InfoBox.TabIndex = 4;
            this.InfoBox.TabStop = false;
            this.InfoBox.Text = "Information";
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(182, 49);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(159, 28);
            this.btnLogOff.TabIndex = 4;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            // 
            // btnLogOn
            // 
            this.btnLogOn.Location = new System.Drawing.Point(9, 49);
            this.btnLogOn.Name = "btnLogOn";
            this.btnLogOn.Size = new System.Drawing.Size(167, 28);
            this.btnLogOn.TabIndex = 3;
            this.btnLogOn.Text = "Log On";
            this.btnLogOn.UseVisualStyleBackColor = true;
            this.btnLogOn.Click += new System.EventHandler(this.btnLogOn_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(241, 21);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "8080";
            // 
            // DisplayPort
            // 
            this.DisplayPort.AutoSize = true;
            this.DisplayPort.Location = new System.Drawing.Point(197, 24);
            this.DisplayPort.Name = "DisplayPort";
            this.DisplayPort.Size = new System.Drawing.Size(38, 17);
            this.DisplayPort.TabIndex = 2;
            this.DisplayPort.Text = "Port:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(91, 21);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 22);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.0.126";
            // 
            // DisplayIp
            // 
            this.DisplayIp.AutoSize = true;
            this.DisplayIp.Location = new System.Drawing.Point(6, 24);
            this.DisplayIp.Name = "DisplayIp";
            this.DisplayIp.Size = new System.Drawing.Size(79, 17);
            this.DisplayIp.TabIndex = 0;
            this.DisplayIp.Text = "Ip Address:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 371);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(266, 62);
            this.txtMessage.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(287, 371);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 62);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 442);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.UserOnlineBox);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "Server";
            this.Text = "Server";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.MessageBox.ResumeLayout(false);
            this.MessageBox.PerformLayout();
            this.UserOnlineBox.ResumeLayout(false);
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.GroupBox MessageBox;
        private System.Windows.Forms.TextBox DisplayMessage;
        private System.Windows.Forms.GroupBox UserOnlineBox;
        private System.Windows.Forms.ListBox User;
        private System.Windows.Forms.GroupBox InfoBox;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnLogOn;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label DisplayPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label DisplayIp;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
    }
}

