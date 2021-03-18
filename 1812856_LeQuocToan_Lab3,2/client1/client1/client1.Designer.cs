
namespace client1
{
    partial class frmclient1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnconnect = new System.Windows.Forms.Button();
            this.txtsend = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 290);
            this.listBox1.TabIndex = 0;
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(138, 297);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(80, 29);
            this.btnconnect.TabIndex = 1;
            this.btnconnect.Text = "&Connect";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // txtsend
            // 
            this.txtsend.Location = new System.Drawing.Point(16, 332);
            this.txtsend.Multiline = true;
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(249, 63);
            this.txtsend.TabIndex = 2;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(271, 332);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(80, 63);
            this.btnsend.TabIndex = 1;
            this.btnsend.Text = "&Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // frmclient1
            // 
            this.AcceptButton = this.btnsend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 399);
            this.Controls.Add(this.txtsend);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.listBox1);
            this.Name = "frmclient1";
            this.Text = "Client1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.Button btnsend;
    }
}

