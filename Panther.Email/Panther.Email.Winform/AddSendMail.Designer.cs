namespace Panther.Email.Winform
{
    partial class AddSendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSendMail));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbSpace = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbIsSSL = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEmailCount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPOP3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPOP3Port = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSendMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSMTP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSMTPPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.btnAddSendMail = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.dgvSendEmail = new System.Windows.Forms.DataGridView();
            this.btnImportSendMail = new System.Windows.Forms.Button();
            this.btnImportSends = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btnTest);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnAddSendMail);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "單個添加";
            // 
            // btnTest
            // 
            this.btnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTest.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTest.Location = new System.Drawing.Point(151, 349);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(84, 33);
            this.btnTest.TabIndex = 53;
            this.btnTest.Text = "測試";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbSpace);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cbIsSSL);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbEmailCount);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox4.Location = new System.Drawing.Point(29, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 133);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "part2";
            // 
            // tbSpace
            // 
            this.tbSpace.Location = new System.Drawing.Point(133, 55);
            this.tbSpace.Name = "tbSpace";
            this.tbSpace.Size = new System.Drawing.Size(82, 21);
            this.tbSpace.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(27, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "是否启用SSL：";
            // 
            // cbIsSSL
            // 
            this.cbIsSSL.FormattingEnabled = true;
            this.cbIsSSL.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cbIsSSL.Location = new System.Drawing.Point(133, 22);
            this.cbIsSSL.Name = "cbIsSSL";
            this.cbIsSSL.Size = new System.Drawing.Size(82, 20);
            this.cbIsSSL.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 44;
            this.label9.Text = "發送間隔(分鐘)：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(21, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 39;
            this.label10.Text = "最多發送數量：";
            // 
            // tbEmailCount
            // 
            this.tbEmailCount.Location = new System.Drawing.Point(133, 88);
            this.tbEmailCount.Name = "tbEmailCount";
            this.tbEmailCount.Size = new System.Drawing.Size(82, 21);
            this.tbEmailCount.TabIndex = 40;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPOP3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbPOP3Port);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Location = new System.Drawing.Point(354, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 133);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "part3";
            // 
            // tbPOP3
            // 
            this.tbPOP3.Location = new System.Drawing.Point(89, 38);
            this.tbPOP3.Name = "tbPOP3";
            this.tbPOP3.Size = new System.Drawing.Size(159, 21);
            this.tbPOP3.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "POP3：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = "POP3端口：";
            // 
            // tbPOP3Port
            // 
            this.tbPOP3Port.Location = new System.Drawing.Point(89, 77);
            this.tbPOP3Port.Name = "tbPOP3Port";
            this.tbPOP3Port.Size = new System.Drawing.Size(47, 21);
            this.tbPOP3Port.TabIndex = 38;
            this.tbPOP3Port.Text = "110";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbSendMode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbSMTP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbSMTPPort);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Location = new System.Drawing.Point(354, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 133);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "part4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 55;
            this.label11.Text = "發送方式：";
            // 
            // cbSendMode
            // 
            this.cbSendMode.Enabled = false;
            this.cbSendMode.FormattingEnabled = true;
            this.cbSendMode.Items.AddRange(new object[] {
            "發送",
            "密送"});
            this.cbSendMode.Location = new System.Drawing.Point(89, 88);
            this.cbSendMode.Name = "cbSendMode";
            this.cbSendMode.Size = new System.Drawing.Size(121, 20);
            this.cbSendMode.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "SMTP：";
            // 
            // tbSMTP
            // 
            this.tbSMTP.Location = new System.Drawing.Point(89, 22);
            this.tbSMTP.Name = "tbSMTP";
            this.tbSMTP.Size = new System.Drawing.Size(159, 21);
            this.tbSMTP.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 35;
            this.label6.Text = "SMTP端口：";
            // 
            // tbSMTPPort
            // 
            this.tbSMTPPort.Location = new System.Drawing.Point(89, 55);
            this.tbSMTPPort.Name = "tbSMTPPort";
            this.tbSMTPPort.Size = new System.Drawing.Size(47, 21);
            this.tbSMTPPort.TabIndex = 36;
            this.tbSMTPPort.Text = "25";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbEmailAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPassWord);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(29, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 133);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "part1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "郵箱地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "名    稱：";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(106, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(147, 21);
            this.tbName.TabIndex = 26;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(106, 55);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(147, 21);
            this.tbEmailAddress.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "郵箱密碼：";
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(106, 91);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(147, 21);
            this.tbPassWord.TabIndex = 30;
            this.tbPassWord.UseSystemPasswordChar = true;
            // 
            // btnAddSendMail
            // 
            this.btnAddSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddSendMail.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddSendMail.Location = new System.Drawing.Point(29, 349);
            this.btnAddSendMail.Name = "btnAddSendMail";
            this.btnAddSendMail.Size = new System.Drawing.Size(84, 33);
            this.btnAddSendMail.TabIndex = 20;
            this.btnAddSendMail.Text = "確定";
            this.btnAddSendMail.UseVisualStyleBackColor = true;
            this.btnAddSendMail.Click += new System.EventHandler(this.btnAddSendMail_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "批量添加";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.btnExportExcel);
            this.groupBox5.Controls.Add(this.dgvSendEmail);
            this.groupBox5.Controls.Add(this.btnImportSendMail);
            this.groupBox5.Controls.Add(this.btnImportSends);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(717, 415);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "導入";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportExcel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportExcel.Location = new System.Drawing.Point(238, 20);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(113, 43);
            this.btnExportExcel.TabIndex = 22;
            this.btnExportExcel.Text = "模板導出";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // dgvSendEmail
            // 
            this.dgvSendEmail.AllowUserToAddRows = false;
            this.dgvSendEmail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSendEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSendEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSendEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSendEmail.Location = new System.Drawing.Point(3, 69);
            this.dgvSendEmail.Name = "dgvSendEmail";
            this.dgvSendEmail.RowHeadersVisible = false;
            this.dgvSendEmail.RowTemplate.Height = 23;
            this.dgvSendEmail.Size = new System.Drawing.Size(711, 343);
            this.dgvSendEmail.TabIndex = 1;
            // 
            // btnImportSendMail
            // 
            this.btnImportSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImportSendMail.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImportSendMail.ForeColor = System.Drawing.Color.Black;
            this.btnImportSendMail.Location = new System.Drawing.Point(19, 20);
            this.btnImportSendMail.Name = "btnImportSendMail";
            this.btnImportSendMail.Size = new System.Drawing.Size(60, 43);
            this.btnImportSendMail.TabIndex = 21;
            this.btnImportSendMail.Text = "確定";
            this.btnImportSendMail.UseVisualStyleBackColor = true;
            this.btnImportSendMail.Click += new System.EventHandler(this.btnImportSendMail_Click);
            // 
            // btnImportSends
            // 
            this.btnImportSends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImportSends.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImportSends.ForeColor = System.Drawing.Color.Black;
            this.btnImportSends.Location = new System.Drawing.Point(100, 20);
            this.btnImportSends.Name = "btnImportSends";
            this.btnImportSends.Size = new System.Drawing.Size(113, 43);
            this.btnImportSends.TabIndex = 0;
            this.btnImportSends.Text = "導入數據";
            this.btnImportSends.UseVisualStyleBackColor = true;
            this.btnImportSends.Click += new System.EventHandler(this.btnImportSends_Click);
            // 
            // AddSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(731, 447);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加發件郵箱";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnImportSends;
        private System.Windows.Forms.DataGridView dgvSendEmail;
        private System.Windows.Forms.Button btnImportSendMail;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAddSendMail;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbIsSSL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEmailCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbPOP3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPOP3Port;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSMTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSMTPPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.TextBox tbSpace;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSendMode;
    }
}