namespace Panther.Email.Winform
{
    partial class NewMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMessageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpdateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lbImportEml = new System.Windows.Forms.Label();
            this.btnImportEml = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbTheme = new System.Windows.Forms.TextBox();
            this.tbBcc = new System.Windows.Forms.TextBox();
            this.tbReceipt = new System.Windows.Forms.TextBox();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBccMeail = new System.Windows.Forms.Button();
            this.btnReceptMeail = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.htmlEditUserControl1 = new ZetaHtmlEditControl.UI.HtmlEditUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpdateTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbPath);
            this.panel1.Controls.Add(this.lbImportEml);
            this.panel1.Controls.Add(this.btnImportEml);
            this.panel1.Controls.Add(this.btnSaveAs);
            this.panel1.Controls.Add(this.btnSendMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 37);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(801, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "時間：";
            // 
            // dtpdateTime
            // 
            this.dtpdateTime.CustomFormat = "yyy-MM-dd HH:mm:ss";
            this.dtpdateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdateTime.Location = new System.Drawing.Point(842, 8);
            this.dtpdateTime.MinDate = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.dtpdateTime.Name = "dtpdateTime";
            this.dtpdateTime.Size = new System.Drawing.Size(164, 21);
            this.dtpdateTime.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "路徑：";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(417, 8);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(338, 21);
            this.tbPath.TabIndex = 10;
            // 
            // lbImportEml
            // 
            this.lbImportEml.AutoSize = true;
            this.lbImportEml.Location = new System.Drawing.Point(456, 13);
            this.lbImportEml.Name = "lbImportEml";
            this.lbImportEml.Size = new System.Drawing.Size(0, 12);
            this.lbImportEml.TabIndex = 5;
            // 
            // btnImportEml
            // 
            this.btnImportEml.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImportEml.BackgroundImage")));
            this.btnImportEml.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImportEml.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImportEml.Location = new System.Drawing.Point(263, 7);
            this.btnImportEml.Name = "btnImportEml";
            this.btnImportEml.Size = new System.Drawing.Size(72, 23);
            this.btnImportEml.TabIndex = 9;
            this.btnImportEml.Text = "導入eml";
            this.btnImportEml.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportEml.UseVisualStyleBackColor = true;
            this.btnImportEml.Click += new System.EventHandler(this.btnImportEml_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.BackgroundImage")));
            this.btnSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveAs.Enabled = false;
            this.btnSaveAs.Location = new System.Drawing.Point(184, 7);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(66, 23);
            this.btnSaveAs.TabIndex = 1;
            this.btnSaveAs.Text = "另存為";
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendMessage.BackgroundImage")));
            this.btnSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendMessage.Location = new System.Drawing.Point(9, 7);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(54, 23);
            this.btnSendMessage.TabIndex = 0;
            this.btnSendMessage.Text = "發送";
            this.btnSendMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbTheme);
            this.panel2.Controls.Add(this.tbBcc);
            this.panel2.Controls.Add(this.tbReceipt);
            this.panel2.Controls.Add(this.tbSend);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 107);
            this.panel2.TabIndex = 1;
            // 
            // tbTheme
            // 
            this.tbTheme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbTheme.Location = new System.Drawing.Point(97, 84);
            this.tbTheme.Multiline = true;
            this.tbTheme.Name = "tbTheme";
            this.tbTheme.Size = new System.Drawing.Size(1002, 23);
            this.tbTheme.TabIndex = 4;
            // 
            // tbBcc
            // 
            this.tbBcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBcc.Enabled = false;
            this.tbBcc.Location = new System.Drawing.Point(97, 46);
            this.tbBcc.Multiline = true;
            this.tbBcc.Name = "tbBcc";
            this.tbBcc.Size = new System.Drawing.Size(1002, 23);
            this.tbBcc.TabIndex = 3;
            // 
            // tbReceipt
            // 
            this.tbReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbReceipt.Enabled = false;
            this.tbReceipt.Location = new System.Drawing.Point(97, 23);
            this.tbReceipt.Multiline = true;
            this.tbReceipt.Name = "tbReceipt";
            this.tbReceipt.Size = new System.Drawing.Size(1002, 23);
            this.tbReceipt.TabIndex = 2;
            this.tbReceipt.Visible = false;
            // 
            // tbSend
            // 
            this.tbSend.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSend.Enabled = false;
            this.tbSend.Location = new System.Drawing.Point(97, 0);
            this.tbSend.Multiline = true;
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(1002, 23);
            this.tbSend.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnBccMeail);
            this.panel3.Controls.Add(this.btnReceptMeail);
            this.panel3.Controls.Add(this.btnSendMail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 107);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "主題：";
            // 
            // btnBccMeail
            // 
            this.btnBccMeail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBccMeail.Location = new System.Drawing.Point(0, 46);
            this.btnBccMeail.Margin = new System.Windows.Forms.Padding(5);
            this.btnBccMeail.Name = "btnBccMeail";
            this.btnBccMeail.Size = new System.Drawing.Size(97, 23);
            this.btnBccMeail.TabIndex = 2;
            this.btnBccMeail.Text = "密送人";
            this.btnBccMeail.UseVisualStyleBackColor = true;
            this.btnBccMeail.Click += new System.EventHandler(this.btnBccMeail_Click);
            // 
            // btnReceptMeail
            // 
            this.btnReceptMeail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceptMeail.Enabled = false;
            this.btnReceptMeail.Location = new System.Drawing.Point(0, 23);
            this.btnReceptMeail.Name = "btnReceptMeail";
            this.btnReceptMeail.Size = new System.Drawing.Size(97, 23);
            this.btnReceptMeail.TabIndex = 1;
            this.btnReceptMeail.Text = "收件人";
            this.btnReceptMeail.UseVisualStyleBackColor = true;
            this.btnReceptMeail.Visible = false;
            this.btnReceptMeail.Click += new System.EventHandler(this.btnReceptMeail_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSendMail.Location = new System.Drawing.Point(0, 0);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(5);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(97, 23);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "發件人";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.htmlEditUserControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1099, 393);
            this.panel4.TabIndex = 2;
            // 
            // htmlEditUserControl1
            // 
            this.htmlEditUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlEditUserControl1.IsToolbarVisible = true;
            this.htmlEditUserControl1.Location = new System.Drawing.Point(0, 0);
            this.htmlEditUserControl1.Name = "htmlEditUserControl1";
            this.htmlEditUserControl1.Size = new System.Drawing.Size(1099, 393);
            this.htmlEditUserControl1.TabIndex = 0;
            // 
            // NewMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 537);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新消息";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnImportEml;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReceptMeail;
        private System.Windows.Forms.TextBox tbBcc;
        private System.Windows.Forms.TextBox tbReceipt;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBccMeail;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.TextBox tbTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbImportEml;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpdateTime;
        private System.Windows.Forms.Label label3;
        private ZetaHtmlEditControl.UI.HtmlEditUserControl htmlEditUserControl1;
    }
}