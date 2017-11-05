namespace Panther.Email.Winform
{
    partial class EmailManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailManagerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvSendMail = new System.Windows.Forms.TreeView();
            this.cmsTreeViewShow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSendList = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmailSendBccAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtCountEnd = new System.Windows.Forms.TextBox();
            this.txtCountStart = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnStopSend = new System.Windows.Forms.Button();
            this.btnFailure = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvSendAccount = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendList)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "郵件管理";
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
            this.splitContainer1.Size = new System.Drawing.Size(994, 485);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvSendMail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 485);
            this.panel2.TabIndex = 2;
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
            this.tvSendMail.Size = new System.Drawing.Size(255, 485);
            this.tvSendMail.TabIndex = 0;
            this.tvSendMail.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSendMail_AfterSelect);
            this.tvSendMail.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvSendMail_NodeMouseDoubleClick);
            // 
            // cmsTreeViewShow
            // 
            this.cmsTreeViewShow.Name = "cmsSynchronous";
            this.cmsTreeViewShow.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "receiptsMail.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(727, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "發送列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvSendList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(721, 404);
            this.panel4.TabIndex = 9;
            // 
            // dgvSendList
            // 
            this.dgvSendList.AllowUserToAddRows = false;
            this.dgvSendList.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvSendList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSendList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.EmailSendBccAccountID,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column12});
            this.dgvSendList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSendList.Location = new System.Drawing.Point(0, 0);
            this.dgvSendList.Name = "dgvSendList";
            this.dgvSendList.RowHeadersVisible = false;
            this.dgvSendList.RowTemplate.Height = 23;
            this.dgvSendList.Size = new System.Drawing.Size(721, 404);
            this.dgvSendList.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "IsChecked";
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.Width = 5;
            // 
            // EmailSendBccAccountID
            // 
            this.EmailSendBccAccountID.HeaderText = "EmailSendBccAccountID";
            this.EmailSendBccAccountID.Name = "EmailSendBccAccountID";
            this.EmailSendBccAccountID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EmailSendBccAccountID.Visible = false;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtCount);
            this.panel3.Controls.Add(this.txtCountEnd);
            this.panel3.Controls.Add(this.txtCountStart);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.tbSearch);
            this.panel3.Controls.Add(this.btnDeleteAll);
            this.panel3.Controls.Add(this.btnStopSend);
            this.panel3.Controls.Add(this.btnFailure);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(721, 49);
            this.panel3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(616, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 59;
            this.label2.Text = "总数:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(554, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 58;
            this.label1.Text = "—";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(654, 13);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(33, 21);
            this.txtCount.TabIndex = 57;
            // 
            // txtCountEnd
            // 
            this.txtCountEnd.Location = new System.Drawing.Point(573, 12);
            this.txtCountEnd.Name = "txtCountEnd";
            this.txtCountEnd.Size = new System.Drawing.Size(33, 21);
            this.txtCountEnd.TabIndex = 56;
            // 
            // txtCountStart
            // 
            this.txtCountStart.Location = new System.Drawing.Point(519, 12);
            this.txtCountStart.Name = "txtCountStart";
            this.txtCountStart.Size = new System.Drawing.Size(33, 21);
            this.txtCountStart.TabIndex = 55;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(185, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 23);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Location = new System.Drawing.Point(150, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 22);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(7, 14);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(143, 21);
            this.tbSearch.TabIndex = 52;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteAll.Location = new System.Drawing.Point(245, 12);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteAll.TabIndex = 2;
            this.btnDeleteAll.Text = "刪除全部記錄";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnStopSend
            // 
            this.btnStopSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStopSend.Location = new System.Drawing.Point(437, 12);
            this.btnStopSend.Name = "btnStopSend";
            this.btnStopSend.Size = new System.Drawing.Size(75, 23);
            this.btnStopSend.TabIndex = 3;
            this.btnStopSend.Text = "停止發送";
            this.btnStopSend.UseVisualStyleBackColor = true;
            this.btnStopSend.Click += new System.EventHandler(this.btnStopSend_Click);
            // 
            // btnFailure
            // 
            this.btnFailure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFailure.Location = new System.Drawing.Point(341, 12);
            this.btnFailure.Name = "btnFailure";
            this.btnFailure.Size = new System.Drawing.Size(90, 23);
            this.btnFailure.TabIndex = 4;
            this.btnFailure.Text = "刪除失敗記錄";
            this.btnFailure.UseVisualStyleBackColor = true;
            this.btnFailure.Click += new System.EventHandler(this.btnFailure_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSendAccount);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "發送賬號";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.dgvSendAccount.Size = new System.Drawing.Size(721, 453);
            this.dgvSendAccount.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "IsChecked";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EmailTitle";
            this.Column2.HeaderText = "郵件主題";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
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
            // Column11
            // 
            this.Column11.DataPropertyName = "EmailSendAccountID";
            this.Column11.HeaderText = "編號";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // EmailManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 505);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "EmailManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "郵件管理";
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvSendMail;
        private System.Windows.Forms.ContextMenuStrip cmsTreeViewShow;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSendAccount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSendList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnStopSend;
        private System.Windows.Forms.Button btnFailure;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailSendBccAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtCountEnd;
        private System.Windows.Forms.TextBox txtCountStart;
        private System.Windows.Forms.Label label2;

    }
}