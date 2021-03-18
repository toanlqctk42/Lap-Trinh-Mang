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
        UdpClient newsock;
        IPEndPoint sender;
        Thread Thread;
        public frmserver()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            Thread = new Thread(new ThreadStart(Connect));
            Thread.Start();
            btnstart.Enabled = false;
        }
        void Connect()
        {
            string s;
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9998);
            newsock = new UdpClient(ipep);
            this.listBox1.Items.Add("Dang cho client ket noi den...");
            sender = new IPEndPoint(IPAddress.Any, 0);
            data = newsock.Receive(ref sender);
            s = string.Format("Thong diep duoc nhan tu : {0}", sender.ToString());
            this.listBox2.Items.Add(sender.Port.ToString());
            this.listBox1.Items.Add(s);
            this.listBox1.Items.Add(sender.ToString() + " : " + Encoding.ASCII.GetString(data, 0, data.Length));
            string welcome = "Xin chao client";
            data = Encoding.ASCII.GetBytes(welcome);
            newsock.Send(data, data.Length, sender);
            while (true)
            {
                data = newsock.Receive(ref sender);
                this.listBox2.Items.Add(sender.Port.ToString());
                this.listBox1.Items.Add(sender.ToString()+" : " + Encoding.ASCII.GetString(data, 0, data.Length));
                newsock.Send(data, data.Length, sender);
            }
        }


    }
}
