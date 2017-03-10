namespace Client
{
    partial class ClientChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientChat));
            this.btnSend = new System.Windows.Forms.Button();
            this.UserOnlineBox = new System.Windows.Forms.GroupBox();
            this.User = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.DisplayMessage = new System.Windows.Forms.TextBox();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.DisplayName = new System.Windows.Forms.Label();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UserOnlineBox.SuspendLayout();
            this.InfoBox.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(362, 350);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(138, 63);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // UserOnlineBox
            // 
            this.UserOnlineBox.Controls.Add(this.User);
            this.UserOnlineBox.Location = new System.Drawing.Point(362, 34);
            this.UserOnlineBox.Name = "UserOnlineBox";
            this.UserOnlineBox.Size = new System.Drawing.Size(138, 310);
            this.UserOnlineBox.TabIndex = 11;
            this.UserOnlineBox.TabStop = false;
            this.UserOnlineBox.Text = "Online User";
            // 
            // User
            // 
            this.User.FormattingEnabled = true;
            this.User.ItemHeight = 16;
            this.User.Location = new System.Drawing.Point(6, 21);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(123, 276);
            this.User.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(9, 350);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(347, 63);
            this.txtMessage.TabIndex = 10;
            // 
            // DisplayMessage
            // 
            this.DisplayMessage.BackColor = System.Drawing.Color.White;
            this.DisplayMessage.Location = new System.Drawing.Point(9, 125);
            this.DisplayMessage.Multiline = true;
            this.DisplayMessage.Name = "DisplayMessage";
            this.DisplayMessage.ReadOnly = true;
            this.DisplayMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayMessage.Size = new System.Drawing.Size(347, 219);
            this.DisplayMessage.TabIndex = 9;
            // 
            // InfoBox
            // 
            this.InfoBox.Controls.Add(this.txtIP);
            this.InfoBox.Controls.Add(this.label1);
            this.InfoBox.Controls.Add(this.btnConnect);
            this.InfoBox.Controls.Add(this.txtName);
            this.InfoBox.Controls.Add(this.DisplayName);
            this.InfoBox.Location = new System.Drawing.Point(9, 34);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(347, 85);
            this.InfoBox.TabIndex = 8;
            this.InfoBox.TabStop = false;
            this.InfoBox.Text = "Information";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(248, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(93, 22);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "192.168.0.126";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ip Address: ";
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnect.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(9, 49);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(332, 28);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(93, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Enter Name";
            // 
            // DisplayName
            // 
            this.DisplayName.AutoSize = true;
            this.DisplayName.Location = new System.Drawing.Point(6, 24);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(49, 17);
            this.DisplayName.TabIndex = 0;
            this.DisplayName.Text = "Name:";
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(509, 28);
            this.menuBar.TabIndex = 7;
            this.menuBar.Text = "menu";
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
            // ClientChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 421);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.UserOnlineBox);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.DisplayMessage);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.UserOnlineBox.ResumeLayout(false);
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox UserOnlineBox;
        private System.Windows.Forms.ListBox User;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox DisplayMessage;
        private System.Windows.Forms.GroupBox InfoBox;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label DisplayName;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}

