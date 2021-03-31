
namespace server
{
    partial class frmserver
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
            this.btnstart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 264);
            this.listBox1.TabIndex = 0;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(224, 282);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(90, 24);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "&Start Server";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Location = new System.Drawing.Point(323, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 264);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các nick name";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(198, 238);
            this.listBox2.TabIndex = 0;
            // 
            // frmserver
            // 
            this.AcceptButton = this.btnstart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.listBox1);
            this.Name = "frmserver";
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

