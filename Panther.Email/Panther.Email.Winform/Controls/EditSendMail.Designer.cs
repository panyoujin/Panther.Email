namespace Panther.Email.Winform.Controls
{
    partial class EditSendMail
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbEditMail = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSendCounted = new System.Windows.Forms.TextBox();
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
            this.label13 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
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
            this.btnUpdateMail = new System.Windows.Forms.Button();
            this.gbEditMail.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEditMail
            // 
            this.gbEditMail.Controls.Add(this.groupBox4);
            this.gbEditMail.Controls.Add(this.groupBox3);
            this.gbEditMail.Controls.Add(this.groupBox2);
            this.gbEditMail.Controls.Add(this.groupBox1);
            this.gbEditMail.Controls.Add(this.btnUpdateMail);
            this.gbEditMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEditMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbEditMail.Location = new System.Drawing.Point(0, 0);
            this.gbEditMail.Margin = new System.Windows.Forms.Padding(5);
            this.gbEditMail.Name = "gbEditMail";
            this.gbEditMail.Size = new System.Drawing.Size(717, 471);
            this.gbEditMail.TabIndex = 1;
            this.gbEditMail.TabStop = false;
            this.gbEditMail.Text = "郵箱编辑";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtSendCounted);
            this.groupBox4.Controls.Add(this.tbSpace);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cbIsSSL);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbEmailCount);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox4.Location = new System.Drawing.Point(28, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 161);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "part2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 50;
            this.label12.Text = "剩餘發送數量：";
            // 
            // txtSendCounted
            // 
            this.txtSendCounted.Location = new System.Drawing.Point(133, 123);
            this.txtSendCounted.Name = "txtSendCounted";
            this.txtSendCounted.Size = new System.Drawing.Size(120, 21);
            this.txtSendCounted.TabIndex = 51;
            // 
            // tbSpace
            // 
            this.tbSpace.Location = new System.Drawing.Point(133, 55);
            this.tbSpace.Name = "tbSpace";
            this.tbSpace.Size = new System.Drawing.Size(120, 21);
            this.tbSpace.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
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
            this.cbIsSSL.Size = new System.Drawing.Size(120, 20);
            this.cbIsSSL.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 44;
            this.label9.Text = "發送間隔(分鐘)：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
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
            this.tbEmailCount.Size = new System.Drawing.Size(120, 21);
            this.tbEmailCount.TabIndex = 40;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPOP3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbPOP3Port);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Location = new System.Drawing.Point(353, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 133);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "part3";
            // 
            // tbPOP3
            // 
            this.tbPOP3.Location = new System.Drawing.Point(122, 41);
            this.tbPOP3.Name = "tbPOP3";
            this.tbPOP3.Size = new System.Drawing.Size(151, 21);
            this.tbPOP3.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "POP3：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = "POP3端口：";
            // 
            // tbPOP3Port
            // 
            this.tbPOP3Port.Location = new System.Drawing.Point(122, 80);
            this.tbPOP3Port.Name = "tbPOP3Port";
            this.tbPOP3Port.Size = new System.Drawing.Size(151, 21);
            this.tbPOP3Port.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTime);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbSendMode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbSMTP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbSMTPPort);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Location = new System.Drawing.Point(353, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 161);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "part4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 12);
            this.label13.TabIndex = 52;
            this.label13.Text = "下次發送時間：";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(118, 122);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(155, 21);
            this.txtTime.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(42, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 57;
            this.label11.Text = "發送方式：";
            // 
            // cbSendMode
            // 
            this.cbSendMode.Enabled = false;
            this.cbSendMode.FormattingEnabled = true;
            this.cbSendMode.Items.AddRange(new object[] {
            "發送",
            "密送"});
            this.cbSendMode.Location = new System.Drawing.Point(118, 89);
            this.cbSendMode.Name = "cbSendMode";
            this.cbSendMode.Size = new System.Drawing.Size(155, 20);
            this.cbSendMode.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "SMTP：";
            // 
            // tbSMTP
            // 
            this.tbSMTP.Location = new System.Drawing.Point(118, 23);
            this.tbSMTP.Name = "tbSMTP";
            this.tbSMTP.Size = new System.Drawing.Size(155, 21);
            this.tbSMTP.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 35;
            this.label6.Text = "SMTP端口：";
            // 
            // tbSMTPPort
            // 
            this.tbSMTPPort.Location = new System.Drawing.Point(118, 56);
            this.tbSMTPPort.Name = "tbSMTPPort";
            this.tbSMTPPort.Size = new System.Drawing.Size(155, 21);
            this.tbSMTPPort.TabIndex = 36;
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
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 133);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "part1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "郵箱地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
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
            // 
            // btnUpdateMail
            // 
            this.btnUpdateMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateMail.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateMail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnUpdateMail.Location = new System.Drawing.Point(28, 359);
            this.btnUpdateMail.Name = "btnUpdateMail";
            this.btnUpdateMail.Size = new System.Drawing.Size(60, 43);
            this.btnUpdateMail.TabIndex = 41;
            this.btnUpdateMail.Text = "修改";
            this.btnUpdateMail.UseVisualStyleBackColor = true;
            this.btnUpdateMail.Click += new System.EventHandler(this.btnUpdateMail_Click);
            // 
            // EditSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbEditMail);
            this.Name = "EditSendMail";
            this.Size = new System.Drawing.Size(717, 471);
            this.gbEditMail.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEditMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbIsSSL;
        private System.Windows.Forms.Button btnUpdateMail;
        private System.Windows.Forms.TextBox tbEmailCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPOP3Port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSMTPPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPOP3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSMTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSpace;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSendMode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSendCounted;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTime;


    }
}
