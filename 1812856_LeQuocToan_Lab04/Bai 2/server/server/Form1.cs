using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace server
{
    public partial class frmserver : Form
    {
        /*public delegate void ProcessConnection();
        public delegate string StartConnection(object obj);
        UdpClient server;
        IAsyncResult iar;
        IPEndPoint clientEP;
        Socket serverSocket;
        StartConnection connection;
        Thread Thread;
        byte[] data;*/
        


        public frmserver()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            funtionserver server = new funtionserver();
            server.SetTextFunction += Server_SetTextFunction;

            server.StartServer();
            btnstart.Enabled = false;
            /*connection = new StartConnection(StartServer);
            iar = connection.BeginInvoke(null, null, null);
            btnstart.Enabled = false;
            ProcessConnection pc = new ProcessConnection(ProcessSendReceiveData);
            pc.BeginInvoke(null, null);*/
        }
        private void Server_SetTextFunction(string Text)
        {
            listBox1.Items.Add(Text);
        }
        /*string StartServer(object obj)
        {
            data = new byte[1024];
            server = new UdpClient(9998);
            clientEP = new IPEndPoint(IPAddress.Any, 0);
            this.listBox1.Items.Add("Dang cho client ket noi toi");
            data = server.Receive(ref clientEP);
            data = Encoding.ASCII.GetBytes("Hello Client");
            server.Send(data, data.Length, clientEP);
            return clientEP.ToString();
        }

        void ProcessSendReceiveData()
        {
            string IPport = connection.EndInvoke(iar);
            this.listBox1.Items.Add("Thong tin Client ket noi den : \n " + IPport);
            while (true)
            {
                data = server.Receive(ref clientEP);
                this.listBox1.Items.Add("Nhan tu client : " + Encoding.ASCII.GetString(data, 0, data.Length));
                server.Send(data, data.Length, clientEP);
            }
        }*/

    }
}
