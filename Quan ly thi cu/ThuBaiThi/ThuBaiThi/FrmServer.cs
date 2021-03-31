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
        Thread t/*, CommandProcessThread, threadDemLuiThoiGian*/;
  /*      Thread copyDir;
*/
        MangMayTinh mangMayTinh= new MangMayTinh();
       /* Thread threadXuatMayTinh;*/
        ArrayList DSDeThi = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
           serverThread = new ServerThread();
        }

        #region It Khi dung den

        public delegate void SetTextCallBack(string text);


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
        int i;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            if(i==0)
            {
                timer1.Stop();
            }
            txtThoiGianLamBai.Text = i.ToString();

        }

        private void cmdBatDauLamBai_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(txtThoiGianLamBai.Text);
            timer1.Start();
           
        }

        void NhapDanhSachIP()
        {
            FrmSetIP frmSetIP = new FrmSetIP();
            frmSetIP.ShowDialog();
            // mangMayTinh = serverThread.AddMayTinh("192.168.255.1", "192.168.255.60", "255.255.255.0");

            // this.MainGroupBox.Controls.Add(mangMayTinh);

            mangMayTinh = serverThread.AddMayTinh(StaticInfo.FirstIP, StaticInfo.LastIP, StaticInfo.SubnetMask);
            this.MainGroupBox.Controls.Add(mangMayTinh);
        }

        
        #endregion

        private void cmdNhapVungIP_Click(object sender, EventArgs e)
        {
            NhapDanhSachIP();
        }

        private void btndisconnec_Click(object sender, EventArgs e)
        {
            serverThread.Close();
        }

        private void btnsendtoall_Click(object sender, EventArgs e)
        {

        }

        private void btnlaydsthitufile_Click(object sender, EventArgs e)
        {

        }

        private void btnlaydsthitucsdl_Click(object sender, EventArgs e)
        {

        }

        private void btndisableclient_Click(object sender, EventArgs e)
        {

        }

        private void cmdKichHoatAllClient_Click(object sender, EventArgs e)
        {

        }

        private void cmdChon_Click(object sender, EventArgs e)
        {

        }

        private void cmdChonClientPath_Click(object sender, EventArgs e)
        {

        }

        private void btnthemdethi_Click(object sender, EventArgs e)
        {

        }

        private void cmdChapNhan_Click(object sender, EventArgs e)
        {

        }
    }
}