using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Client
{
    public partial class ClientChat : Form
    {
        Thread threadClient = null;
        Socket socketClient = null;

        public ClientChat()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress address = IPAddress.Parse(txtIP.Text.Trim());
            IPEndPoint endpoint = new IPEndPoint(address, 8080);
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socketClient.Connect(endpoint);
            }
            catch (SocketException)
            {
                ShowMessage("Connection Fail");
            }
            threadClient = new Thread(ReceiveMessage);
            threadClient.IsBackground = true;
            threadClient.Start();
            ShowMessage("You Are Connected");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string stringMessage = txtMessage.Text.Trim();
            byte[] arrayMessage = Encoding.UTF8.GetBytes(string.Format($"\n {txtName.Text.Trim()} Said: {stringMessage}"));
            byte[] arrayMessageSend = new byte[arrayMessage.Length + 1];
            arrayMessageSend[0] = 0;
            Buffer.BlockCopy(arrayMessage, 0, arrayMessageSend, 1, arrayMessage.Length);
            try
            {
                socketClient.Send(arrayMessageSend);
                this.txtMessage.Clear();
            }
            catch (SocketException)
            {
                ShowMessage("Failer To Send Message");
            }
        }
        
        private void ReceiveMessage()
        {
            while (true)
            {
                byte[] arrayMessageReceive = new byte[1024];
                int length = -1;
                try
                {
                    length = socketClient.Receive(arrayMessageReceive);
                }
                catch (SocketException)
                {
                    ShowMessage("\n Message Fail To Send");
                    break;
                }
                string stringMessageReceive = Encoding.UTF8.GetString(arrayMessageReceive, 0, length);
                ShowMessage(string.Format(stringMessageReceive));
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ShowMessage(string message)
        {
            DisplayMessage.AppendText(message);
        }
    }
}
