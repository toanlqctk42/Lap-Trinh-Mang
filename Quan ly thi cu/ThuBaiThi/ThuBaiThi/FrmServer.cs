using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using MayTinh;
using NetLib;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
namespace ThuBaiThi
{
    public partial class FrmServer : Form
    {

        ServerThread serverThread;
        Thread t, CommandProcessThread, threadDemLuiThoiGian;
        Thread copyDir;

        Thread threadXuatMayTinh;
        ArrayList DSDeThi = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            serverThread = new ServerThread();
            serverThread.OnClientListChanged += HandleOnClientListChanged;
            serverThread.Start();
        }

        #region It Khi dung den
        private void HandleOnClientListChanged(List<Maytinhinfo> clientList)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    RenderClientList(clientList);
                });
            }
            else
            {
                RenderClientList(clientList);
            }
        }/*
        public delegate void SetTextCallBack(string text);*/


        private void cmdConnect_Click(object sender, EventArgs e)
        {

        }
        public FrmServer()
        {
            InitializeComponent();
        }
        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (t != null)
                t.Abort();

            serverThread.Close();
        }

        private void mnuSetIP_Click(object sender, EventArgs e)
        {

        }

        private void cmdDisconnect_Click(object sender, EventArgs e)
        {
            serverThread.Close();
            
        }

        void RenderClientList(List<Maytinhinfo> clientList)
        {
            if (flpPc.Controls.Count == 0)
            {
                foreach (Maytinhinfo clientInfo in clientList)
                {
                    frmmaytinh frm = new frmmaytinh(clientInfo);
                    flpPc.Controls.Add(frm);
                }

                return;
            }

            int clientControlLength = flpPc.Controls.Count;
            int i = 0;
            for (i = 0; i < clientList.Count; i++)
            {
                Maytinhinfo clientInfoInList = clientList[i];

                if (i < clientControlLength)
                {
                   frmmaytinh frm = flpPc.Controls[i] as frmmaytinh;
                    Maytinhinfo clientInfoInControl = frm.maytinhinfo;

                    frm.SetClient(clientInfoInList);
                }
                else
                {
                    frmmaytinh frm = new frmmaytinh(clientInfoInList);
                    flpPc.Controls.Add(frm);
                }
            }

            if (i < flpPc.Controls.Count)
                for (int j = flpPc.Controls.Count - 1; j >= i; j--)
                    flpPc.Controls.RemoveAt(j);
        }

        private void cmdNhapVungIP_Click(object sender, EventArgs e)
        {
            FrmSetIP frmSetIP = new FrmSetIP();
            DialogResult result = frmSetIP.ShowDialog();
            if (result !=DialogResult.OK)
            {
                return;
            }
            string FirstIP = frmSetIP.FirstIP;
            string LastIP = frmSetIP.LastIP;
            string SubnetMask = frmSetIP.SubnetMask;
            serverThread.SetClienttoList(FirstIP, LastIP, SubnetMask);
        }


    }
}
#endregion