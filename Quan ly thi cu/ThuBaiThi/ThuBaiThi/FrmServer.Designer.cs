namespace ThuBaiThi
{
    partial class FrmServer
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
            this.components = new System.ComponentModel.Container();
            this.lstDeThi = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthemdethi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbserver = new System.Windows.Forms.RadioButton();
            this.rbclient = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdChonClientPath = new System.Windows.Forms.Button();
            this.cmdChon = new System.Windows.Forms.Button();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.txtMonThi = new System.Windows.Forms.TextBox();
            this.txtThoiGianLamBai = new System.Windows.Forms.TextBox();
            this.btndisconnec = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmdChapNhan = new System.Windows.Forms.Button();
            this.btnsendtoall = new System.Windows.Forms.Button();
            this.btnlaydsthitufile = new System.Windows.Forms.Button();
            this.btnlaydsthitucsdl = new System.Windows.Forms.Button();
            this.btndisableclient = new System.Windows.Forms.Button();
            this.cmdBatDauLamBai = new System.Windows.Forms.Button();
            this.cmdKichHoatAllClient = new System.Windows.Forms.Button();
            this.cmdNhapVungIP = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDeThi
            // 
            this.lstDeThi.FormattingEnabled = true;
            this.lstDeThi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstDeThi.Items.AddRange(new object[] {
            "\\\\192.168.6.1\\dethi\\de1.htm",
            "\\\\192.168.6.1\\dethi\\de2.htm",
            "\\\\192.168.6.1\\dethi\\de3.htm",
            "\\\\192.168.6.3\\dethi\\de4.htm"});
            this.lstDeThi.Location = new System.Drawing.Point(7, 19);
            this.lstDeThi.Name = "lstDeThi";
            this.lstDeThi.Size = new System.Drawing.Size(240, 108);
            this.lstDeThi.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthemdethi);
            this.groupBox1.Controls.Add(this.lstDeThi);
            this.groupBox1.Location = new System.Drawing.Point(248, 496);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 153);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Đề Thi";
            // 
            // btnthemdethi
            // 
            this.btnthemdethi.Location = new System.Drawing.Point(253, 59);
            this.btnthemdethi.Name = "btnthemdethi";
            this.btnthemdethi.Size = new System.Drawing.Size(88, 29);
            this.btnthemdethi.TabIndex = 31;
            this.btnthemdethi.Text = "Thêm Đề Thi";
            this.btnthemdethi.UseVisualStyleBackColor = true;
            this.btnthemdethi.Click += new System.EventHandler(this.btnthemdethi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbserver);
            this.groupBox2.Controls.Add(this.rbclient);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(872, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 150);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Noi Lưu Bài Thi";
            // 
            // rbserver
            // 
            this.rbserver.AutoSize = true;
            this.rbserver.Location = new System.Drawing.Point(10, 74);
            this.rbserver.Name = "rbserver";
            this.rbserver.Size = new System.Drawing.Size(56, 17);
            this.rbserver.TabIndex = 1;
            this.rbserver.TabStop = true;
            this.rbserver.Text = "Server";
            this.rbserver.UseVisualStyleBackColor = true;
            // 
            // rbclient
            // 
            this.rbclient.AutoSize = true;
            this.rbclient.Checked = true;
            this.rbclient.Location = new System.Drawing.Point(10, 51);
            this.rbclient.Name = "rbclient";
            this.rbclient.Size = new System.Drawing.Size(51, 17);
            this.rbclient.TabIndex = 1;
            this.rbclient.TabStop = true;
            this.rbclient.Text = "Client";
            this.rbclient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài thi được lưu ở";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Server Path:";
            // 
            // txtServerPath
            // 
            this.txtServerPath.Location = new System.Drawing.Point(12, 36);
            this.txtServerPath.Name = "txtServerPath";
            this.txtServerPath.Size = new System.Drawing.Size(120, 20);
            this.txtServerPath.TabIndex = 34;
            this.txtServerPath.Text = "c:\\serverPath";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Client Path:";
            // 
            // txtClientPath
            // 
            this.txtClientPath.Location = new System.Drawing.Point(12, 82);
            this.txtClientPath.Name = "txtClientPath";
            this.txtClientPath.Size = new System.Drawing.Size(120, 20);
            this.txtClientPath.TabIndex = 34;
            this.txtClientPath.Text = "C:\\tam";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdChonClientPath);
            this.groupBox3.Controls.Add(this.cmdChon);
            this.groupBox3.Controls.Add(this.txtClientPath);
            this.groupBox3.Controls.Add(this.txtServerPath);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(14, 493);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 156);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn Đường Dẫn";
            // 
            // cmdChonClientPath
            // 
            this.cmdChonClientPath.Location = new System.Drawing.Point(139, 80);
            this.cmdChonClientPath.Name = "cmdChonClientPath";
            this.cmdChonClientPath.Size = new System.Drawing.Size(62, 23);
            this.cmdChonClientPath.TabIndex = 36;
            this.cmdChonClientPath.Text = "Chọn";
            this.cmdChonClientPath.UseVisualStyleBackColor = true;
            this.cmdChonClientPath.Click += new System.EventHandler(this.cmdChonClientPath_Click);
            // 
            // cmdChon
            // 
            this.cmdChon.Location = new System.Drawing.Point(139, 36);
            this.cmdChon.Name = "cmdChon";
            this.cmdChon.Size = new System.Drawing.Size(62, 24);
            this.cmdChon.TabIndex = 35;
            this.cmdChon.Text = "Chọn";
            this.cmdChon.UseVisualStyleBackColor = true;
            this.cmdChon.Click += new System.EventHandler(this.cmdChon_Click);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Location = new System.Drawing.Point(138, 12);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(866, 473);
            this.MainGroupBox.TabIndex = 37;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "Danh Sách Các Máy Tính Trong Phòng Máy";
            // 
            // txtMonThi
            // 
            this.txtMonThi.Location = new System.Drawing.Point(11, 21);
            this.txtMonThi.Name = "txtMonThi";
            this.txtMonThi.Size = new System.Drawing.Size(203, 20);
            this.txtMonThi.TabIndex = 28;
            this.txtMonThi.Text = "Chọn Môn Thi";
            this.txtMonThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThoiGianLamBai
            // 
            this.txtThoiGianLamBai.Location = new System.Drawing.Point(11, 60);
            this.txtThoiGianLamBai.Name = "txtThoiGianLamBai";
            this.txtThoiGianLamBai.Size = new System.Drawing.Size(203, 20);
            this.txtThoiGianLamBai.TabIndex = 28;
            this.txtThoiGianLamBai.Text = "120";
            this.txtThoiGianLamBai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btndisconnec
            // 
            this.btndisconnec.Location = new System.Drawing.Point(7, 57);
            this.btndisconnec.Name = "btndisconnec";
            this.btndisconnec.Size = new System.Drawing.Size(109, 30);
            this.btndisconnec.TabIndex = 40;
            this.btndisconnec.Text = "Disconnect";
            this.btndisconnec.UseVisualStyleBackColor = true;
            this.btndisconnec.Click += new System.EventHandler(this.btndisconnec_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmdChapNhan);
            this.groupBox5.Controls.Add(this.txtThoiGianLamBai);
            this.groupBox5.Controls.Add(this.txtMonThi);
            this.groupBox5.Location = new System.Drawing.Point(608, 496);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(239, 150);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chọn Môn Thi và Thời Gian Làm Bài";
            // 
            // cmdChapNhan
            // 
            this.cmdChapNhan.Location = new System.Drawing.Point(65, 104);
            this.cmdChapNhan.Name = "cmdChapNhan";
            this.cmdChapNhan.Size = new System.Drawing.Size(103, 23);
            this.cmdChapNhan.TabIndex = 29;
            this.cmdChapNhan.Text = "Chấp Nhận";
            this.cmdChapNhan.UseVisualStyleBackColor = true;
            this.cmdChapNhan.Click += new System.EventHandler(this.cmdChapNhan_Click);
            // 
            // btnsendtoall
            // 
            this.btnsendtoall.Location = new System.Drawing.Point(7, 94);
            this.btnsendtoall.Name = "btnsendtoall";
            this.btnsendtoall.Size = new System.Drawing.Size(109, 40);
            this.btnsendtoall.TabIndex = 40;
            this.btnsendtoall.Text = "Send Message To All";
            this.btnsendtoall.UseVisualStyleBackColor = true;
            this.btnsendtoall.Click += new System.EventHandler(this.btnsendtoall_Click);
            // 
            // btnlaydsthitufile
            // 
            this.btnlaydsthitufile.Location = new System.Drawing.Point(7, 139);
            this.btnlaydsthitufile.Name = "btnlaydsthitufile";
            this.btnlaydsthitufile.Size = new System.Drawing.Size(109, 43);
            this.btnlaydsthitufile.TabIndex = 40;
            this.btnlaydsthitufile.Text = "Lấy Danh Sách Thi Từ File";
            this.btnlaydsthitufile.UseVisualStyleBackColor = true;
            this.btnlaydsthitufile.Click += new System.EventHandler(this.btnlaydsthitufile_Click);
            // 
            // btnlaydsthitucsdl
            // 
            this.btnlaydsthitucsdl.Location = new System.Drawing.Point(7, 189);
            this.btnlaydsthitucsdl.Name = "btnlaydsthitucsdl";
            this.btnlaydsthitucsdl.Size = new System.Drawing.Size(109, 43);
            this.btnlaydsthitucsdl.TabIndex = 40;
            this.btnlaydsthitucsdl.Text = "Lấy Danh Sách Thi Từ CSDL";
            this.btnlaydsthitucsdl.UseVisualStyleBackColor = true;
            this.btnlaydsthitucsdl.Click += new System.EventHandler(this.btnlaydsthitucsdl_Click);
            // 
            // btndisableclient
            // 
            this.btndisableclient.Location = new System.Drawing.Point(7, 238);
            this.btndisableclient.Name = "btndisableclient";
            this.btndisableclient.Size = new System.Drawing.Size(109, 43);
            this.btndisableclient.TabIndex = 40;
            this.btndisableclient.Text = "Disable Tất Cả Các Máy Trống";
            this.btndisableclient.UseVisualStyleBackColor = true;
            this.btndisableclient.Click += new System.EventHandler(this.btndisableclient_Click);
            // 
            // cmdBatDauLamBai
            // 
            this.cmdBatDauLamBai.Location = new System.Drawing.Point(7, 335);
            this.cmdBatDauLamBai.Name = "cmdBatDauLamBai";
            this.cmdBatDauLamBai.Size = new System.Drawing.Size(109, 32);
            this.cmdBatDauLamBai.TabIndex = 44;
            this.cmdBatDauLamBai.Text = "Bắt Đầu Làm Bài";
            this.cmdBatDauLamBai.UseVisualStyleBackColor = true;
            this.cmdBatDauLamBai.Click += new System.EventHandler(this.cmdBatDauLamBai_Click);
            // 
            // cmdKichHoatAllClient
            // 
            this.cmdKichHoatAllClient.Location = new System.Drawing.Point(7, 288);
            this.cmdKichHoatAllClient.Name = "cmdKichHoatAllClient";
            this.cmdKichHoatAllClient.Size = new System.Drawing.Size(109, 39);
            this.cmdKichHoatAllClient.TabIndex = 45;
            this.cmdKichHoatAllClient.Text = "Kích Hoạt Tất Cả Client";
            this.cmdKichHoatAllClient.UseVisualStyleBackColor = true;
            this.cmdKichHoatAllClient.Click += new System.EventHandler(this.cmdKichHoatAllClient_Click);
            // 
            // cmdNhapVungIP
            // 
            this.cmdNhapVungIP.Location = new System.Drawing.Point(7, 21);
            this.cmdNhapVungIP.Name = "cmdNhapVungIP";
            this.cmdNhapVungIP.Size = new System.Drawing.Size(109, 30);
            this.cmdNhapVungIP.TabIndex = 46;
            this.cmdNhapVungIP.Text = "Nhập Vùng  IP";
            this.cmdNhapVungIP.UseVisualStyleBackColor = true;
            this.cmdNhapVungIP.Click += new System.EventHandler(this.cmdNhapVungIP_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdNhapVungIP);
            this.groupBox4.Controls.Add(this.cmdKichHoatAllClient);
            this.groupBox4.Controls.Add(this.cmdBatDauLamBai);
            this.groupBox4.Controls.Add(this.btnsendtoall);
            this.groupBox4.Controls.Add(this.btndisableclient);
            this.groupBox4.Controls.Add(this.btnlaydsthitucsdl);
            this.groupBox4.Controls.Add(this.btnlaydsthitufile);
            this.groupBox4.Controls.Add(this.btndisconnec);
            this.groupBox4.Location = new System.Drawing.Point(6, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(124, 473);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 653);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDeThi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbserver;
        private System.Windows.Forms.RadioButton rbclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.TextBox txtMonThi;
        private System.Windows.Forms.TextBox txtThoiGianLamBai;
        private System.Windows.Forms.Button cmdChon;
        private System.Windows.Forms.Button btnthemdethi;
        private System.Windows.Forms.Button btndisconnec;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnsendtoall;
        private System.Windows.Forms.Button cmdChapNhan;
        private System.Windows.Forms.Button btnlaydsthitufile;
        private System.Windows.Forms.Button btnlaydsthitucsdl;
        private System.Windows.Forms.Button btndisableclient;
        private System.Windows.Forms.Button cmdBatDauLamBai;
        private System.Windows.Forms.Button cmdChonClientPath;
        private System.Windows.Forms.Button cmdKichHoatAllClient;
        private System.Windows.Forms.Button cmdNhapVungIP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer timer1;
    }
}

