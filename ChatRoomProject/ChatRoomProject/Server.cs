using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
namespace ChatRoomProject
{
    public partial class Server : Form
    {
        string strMsgReceive;
        Queue<string> message = new Queue<string>();
        Thread thread = null;
        Socket socket = null;
        Dictionary<string, Socket> dict = new Dictionary<string, Socket>();
        Dictionary<string, Thread> dictThread = new Dictionary<string, Thread>();

        public Server()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnLogOn_Click(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress address = IPAddress.Parse(txtIP.Text.Trim());
            IPEndPoint endpoint = new IPEndPoint(address, int.Parse(txtPort.Text.Trim()));
            try
            {
                socket.Bind(endpoint);
            }
            catch (SocketException)
            {
                ShowMessage("Check Ip Address");
                return;
            }
            socket.Listen(10);
            thread = new Thread(WatchConnection);
            thread.IsBackground = true;
            thread.Start();
            ShowMessage("Server Is On");
        }

        private void WatchConnection()
        {
            while (true)
            {
                Socket socketConnection = null;
                try
                {
                    socketConnection = socket.Accept();
                }
                catch (SocketException)
                {
                    ShowMessage("Connection Fail");
                    break;
                }
                User.Items.Add(socketConnection.RemoteEndPoint.ToString());
                dict.Add(socketConnection.RemoteEndPoint.ToString(), socketConnection);
                Thread threadCommunicate = new Thread(ReceiveMessage);
                threadCommunicate.IsBackground = true;
                threadCommunicate.Start(socketConnection);
                dictThread.Add(socketConnection.RemoteEndPoint.ToString(), threadCommunicate);
                ShowMessage(string.Format("\n {0} Have Join. ", socketConnection.RemoteEndPoint.ToString()));
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string stringMessage = txtMessage.Text.Trim();
            byte[] arrayMessage = Encoding.UTF8.GetBytes(string.Format($"\n Admin Said: {stringMessage}"));
            foreach (Socket s in dict.Values)
            {
                try
                {
                    s.Send(arrayMessage);
                    this.txtMessage.Clear();
                }
                catch (SocketException)
                {
                    ShowMessage("Message Didn't Send");
                    break;
                }
            }
        }

        private void SendMessageToAll()
        {
            string stringMessage = message.Dequeue();
            byte[] arrayMessage = Encoding.UTF8.GetBytes(string.Format(stringMessage));
            foreach (Socket s in dict.Values)
            {
                try
                {
                    s.Send(arrayMessage);
                }
                catch (SocketException)
                {
                    ShowMessage("Message Didn't Send");
                    break;
                }
            }
        }

        private void ReceiveMessage(object socketClientParameter)
        {
            Socket socketClient = socketClientParameter as Socket;
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
                    ShowMessage($"\n {socketClient.RemoteEndPoint.ToString()} Sign Out");
                    dict.Remove(socketClient.RemoteEndPoint.ToString());
                    dictThread.Remove(socketClient.RemoteEndPoint.ToString());
                    User.Items.Remove(socketClient.RemoteEndPoint.ToString());
                    break;
                }
                if (arrayMessageReceive[0] == 0)
                {
                    strMsgReceive = Encoding.UTF8.GetString(arrayMessageReceive, 1, length - 1);
                    ShowMessage(string.Format("\n" + strMsgReceive));
                    message.Enqueue(strMsgReceive);
                    SendMessageToAll();
                }
            }
        }

        private void ShowMessage(string message)
        {
            DisplayMessage.AppendText(message);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
