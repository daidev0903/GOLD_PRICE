using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ServerApp
{
    public partial class FServerApp : Form
    {
        SimpleTcpServer server;
        IPEndPoint serverEndPoint;
        Socket serverSocket;
        List<Socket> clientSockets;
        public FServerApp()
        {
            InitializeComponent();
        }

        byte[] ReveiceRespone(object obj)
        {
            byte[] buffer = new byte[1024];
            int received = serverSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return null;
            return buffer;
        }

        private void StartOpenConnecting()
        {
            server = new SimpleTcpServer();
            clientSockets = new List<Socket>();
            string serverIP = ipserverTextbox.Text;
            string port = portTextbox.Text;
            serverEndPoint = new IPEndPoint(IPAddress.Any, Int32.Parse(port));
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(serverEndPoint);
            clientActiTextbox.AppendText("Start opening connecting .......");
            clientActiTextbox.AppendText(Environment.NewLine);

            Thread serverListen = new Thread(() =>
            {
                try
                {

                    while (true)
                    {
                        serverSocket.Listen(100);
                        Socket client = serverSocket.Accept();
                        clientSockets.Add(client);
                        clientActiTextbox.Text += $"{client.RemoteEndPoint.ToString()}: Connected at {DateTime.Now.ToString()} {Environment.NewLine}";
                        Thread rec = new Thread(ReceiveFromClient);
                        rec.IsBackground = true;
                        rec.Start(client);
                    }
                }
                catch
                {
                    serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIP), Int32.Parse(port));
                    serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }

            });
            serverListen.IsBackground = true;
            serverListen.Start();

        }

        private void ReceiveFromClient(object obj)
        {
            //Socket client = (Socket)obj;
            //try
            //{
            //    while (true)
            //    {
            //        byte[] data = new byte[1024 * 5000];
            //        client.Receive(data);
            //        string mess = (string)Deserialize(data);
            //        clientActiTextbox.Text += $"{client.RemoteEndPoint.ToString()}:{mess}{Environment.NewLine}";
            //        //checkString1(mess, clien);
            //    }

            //}
            //catch { }
        }

        
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartOpenConnecting();
            startButton.Enabled = false;
            stopButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            serverSocket.Close();
            
            clientActiTextbox.AppendText("Stop !!!");
            clientActiTextbox.AppendText(Environment.NewLine);
            stopButton.Enabled = false;
            startButton.Enabled = true;
        }

        private void clientActiTextbox_Textchanged(object sender, EventArgs e)
        {
            clientActiTextbox.ScrollBars = ScrollBars.Vertical;
        }

        private void clientInUseTextbox_Textchanged(object sender, EventArgs e)
        {
            clientInUseTextbox.ScrollBars = ScrollBars.Vertical;
        }

        bool CheckClienConnecting(Socket client)
        {
            try
            {
                return !(client.Poll(1, SelectMode.SelectRead) && client.Available == 0);
            }
            catch (SocketException)
            {
                return false;
            }
        }

        bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }

        private void SendRequest(string request)
        {
            if (request.Length == 0) return;
            byte[] buffer = new byte[request.Length];
            buffer = Encoding.ASCII.GetBytes(request);
            serverSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        

        //private void HandleRequestClient(byte[] requestBuff, Socket client)
        //{
        //    string requestStr = System.Text.Encoding.UTF8.GetString(requestBuff);
        //    if (requestStr.ToLower() == "disconnect")
        //    {
        //        clientActiTextbox.AppendText($"{client.RemoteEndPoint.ToString()}: Connected at {DateTime.Now.ToString()} {Environment.NewLine}");
        //    }
        //}
    }
}
