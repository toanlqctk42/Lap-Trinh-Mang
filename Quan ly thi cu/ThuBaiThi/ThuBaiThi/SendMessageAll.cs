using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThuBaiThi
{
    public partial class SendMessageAll : Form
    {
        public string mess = null;
        public SendMessageAll()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            mess = txtMessage.Text;
            lboxHistoryMessage.Items.Add(mess);
            txtMessage.Text = "";
        }
    }
}
