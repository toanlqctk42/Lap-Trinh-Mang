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

namespace client1
{
    public partial class frmclient1 : Form
    {
        Thread thread;
        UdpClient server;
        IPEndPoint sender;

        public frmclient1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(Connect));
            thread.Start();
        }
        void Connect()
        {
            byte[] data = new byte[1024];
            string stringData,s;
            
            server = new UdpClient("127.0.0.1", 9998);
            sender = new IPEndPoint(IPAddress.Any, 0);
            string welcome = "Xin chao server";
            data = Encoding.ASCII.GetBytes(welcome);
            server.Send(data, data.Length);
            data = server.Receive(ref sender);
            s = string.Format("Thong diep duoc nhan tu : {0}", sender.ToString());
            this.listBox1.Items.Add(s);
            stringData = Encoding.ASCII.GetString(data, 0, data.Length);
            this.listBox1.Items.Add(stringData);           
        }
        void send()
        {
            string strdata = txtsend.Text;
            byte[] data = Encoding.ASCII.GetBytes(strdata);
            server.Send(data, data.Length);
            data = server.Receive(ref sender);
            string str = Encoding.ASCII.GetString(data, 0, data.Length);
            this.listBox1.Items.Add(str);
            txtsend.Text = "";

        }
        private void btnsend_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(send));
            thread.Start();
        }


    }
}
