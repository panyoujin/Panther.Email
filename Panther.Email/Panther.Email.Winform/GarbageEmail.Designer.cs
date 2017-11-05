namespace Panther.Email.Winform
{
    partial class GarbageEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GarbageEmail));
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvSendAccount = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSendList = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmsTreeViewShow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tvSendMail = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtCountEnd = new System.Windows.Forms.TextBox();
            this.txtCountStart = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendAccount)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendList)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "IsChecked";
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.Width = 5;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "EmailTitle";
            this.Column5.HeaderText = "郵件主題";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "EmailBccAccountAddress";
            this.Column6.HeaderText = "收件箱地址";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 90;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "EmailAccountAddress";
            this.Column7.HeaderText = "發件箱地址";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 90;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.DataPropertyName = "EmailSendBccAccountState";
            this.Column8.HeaderText = "發送狀態";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 78;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.DataPropertyName = "EmailSendBccAccountSendTIme";
            this.Column9.HeaderText = "發送時間";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 78;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.DataPropertyName = "EmailSendBccAccountCreateTime";
            this.Column10.HeaderText = "創建時間";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 78;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "EmailSendBccAccountID";
            this.Column12.HeaderText = "編號";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "EmailSendAccountID";
            this.Column11.HeaderText = "編號";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EmailTitle";
            this.Column2.HeaderText = "郵件主題";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "IsChecked";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // dgvSendAccount
            // 
            this.dgvSendAccount.AllowUserToAddRows = false;
            this.dgvSendAccount.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvSendAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSendAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSendAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column11});
            this.dgvSendAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSendAccount.Location = new System.Drawing.Point(3, 3);
            this.dgvSendAccount.Name = "dgvSendAccount";
            this.dgvSendAccount.RowHeadersVisible = false;
            this.dgvSendAccount.RowTemplate.Height = 23;
            this.dgvSendAccount.Size = new System.Drawing.Size(643, 466);
            this.dgvSendAccount.TabIndex = 1;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "EmailAccountAddress";
            this.Column3.HeaderText = "發件箱地址";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSendAccount);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "發送賬號";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtCount);
            this.panel4.Controls.Add(this.txtCountEnd);
            this.panel4.Controls.Add(this.txtCountStart);
            this.panel4.Controls.Add(this.dgvSendList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(643, 466);
            this.panel4.TabIndex = 9;
            // 
            // dgvSendList
            // 
            this.dgvSendList.AllowUserToAddRows = false;
            this.dgvSendList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSendList.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvSendList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSendList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column12});
            this.dgvSendList.Location = new System.Drawing.Point(0, 41);
            this.dgvSendList.Name = "dgvSendList";
            this.dgvSendList.RowHeadersVisible = false;
            this.dgvSendList.RowTemplate.Height = 23;
            this.dgvSendList.Size = new System.Drawing.Size(643, 425);
            this.dgvSendList.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "發送列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 498);
            this.tabControl1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "receiptsMail.png");
            // 
            // cmsTreeViewShow
            // 
            this.cmsTreeViewShow.Name = "cmsSynchronous";
            this.cmsTreeViewShow.Size = new System.Drawing.Size(61, 4);
            // 
            // tvSendMail
            // 
            this.tvSendMail.BackColor = System.Drawing.SystemColors.Control;
            this.tvSendMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvSendMail.CheckBoxes = true;
            this.tvSendMail.ContextMenuStrip = this.cmsTreeViewShow;
            this.tvSendMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSendMail.ForeColor = System.Drawing.Color.Black;
            this.tvSendMail.ImageIndex = 0;
            this.tvSendMail.ImageList = this.imageList1;
            this.tvSendMail.ItemHeight = 20;
            this.tvSendMail.Location = new System.Drawing.Point(0, 0);
            this.tvSendMail.Name = "tvSendMail";
            this.tvSendMail.SelectedImageIndex = 0;
            this.tvSendMail.ShowNodeToolTips = true;
            this.tvSendMail.ShowRootLines = false;
            this.tvSendMail.Size = new System.Drawing.Size(228, 498);
            this.tvSendMail.TabIndex = 0;
            this.tvSendMail.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSendMail_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvSendMail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 498);
            this.panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 17);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(889, 498);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 518);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "垃圾郵件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(562, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 64;
            this.label2.Text = "总数:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 63;
            this.label1.Text = "—";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(600, 10);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(33, 21);
            this.txtCount.TabIndex = 62;
            // 
            // txtCountEnd
            // 
            this.txtCountEnd.Location = new System.Drawing.Point(71, 14);
            this.txtCountEnd.Name = "txtCountEnd";
            this.txtCountEnd.Size = new System.Drawing.Size(33, 21);
            this.txtCountEnd.TabIndex = 61;
            // 
            // txtCountStart
            // 
            this.txtCountStart.Location = new System.Drawing.Point(17, 14);
            this.txtCountStart.Name = "txtCountStart";
            this.txtCountStart.Size = new System.Drawing.Size(33, 21);
            this.txtCountStart.TabIndex = 60;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Location = new System.Drawing.Point(123, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 22);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GarbageEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 518);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GarbageEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GarbageEmail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendAccount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvSendAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSendList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip cmsTreeViewShow;
        private System.Windows.Forms.TreeView tvSendMail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtCountEnd;
        private System.Windows.Forms.TextBox txtCountStart;
        private System.Windows.Forms.Button btnSearch;
    }
}