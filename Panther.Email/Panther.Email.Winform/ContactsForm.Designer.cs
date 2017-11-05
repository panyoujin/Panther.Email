namespace Panther.Email.Winform
{
    partial class ContactsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmailBccAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailBccAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailBccAccountAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailBccAccountCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.tbOld = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteExport = new System.Windows.Forms.Button();
            this.btnDataExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnShowOneContactForm = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountEnd = new System.Windows.Forms.TextBox();
            this.txtCountStart = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通訊錄";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 395);
            this.panel2.TabIndex = 57;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbSelectAll);
            this.panel4.Controls.Add(this.dgvContact);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(607, 395);
            this.panel4.TabIndex = 55;
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.Location = new System.Drawing.Point(5, 4);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(15, 14);
            this.cbSelectAll.TabIndex = 53;
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.CheckedChanged += new System.EventHandler(this.cbSelectAll_CheckedChanged);
            // 
            // dgvContact
            // 
            this.dgvContact.AllowUserToAddRows = false;
            this.dgvContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.EmailBccAccountID,
            this.EmailBccAccountName,
            this.EmailBccAccountAddress,
            this.EmailBccAccountCreateTime,
            this.State,
            this.index});
            this.dgvContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContact.Location = new System.Drawing.Point(0, 0);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.RowHeadersVisible = false;
            this.dgvContact.RowTemplate.Height = 23;
            this.dgvContact.Size = new System.Drawing.Size(607, 395);
            this.dgvContact.TabIndex = 52;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.Width = 20;
            // 
            // EmailBccAccountID
            // 
            this.EmailBccAccountID.HeaderText = "EmailBccAccountID";
            this.EmailBccAccountID.Name = "EmailBccAccountID";
            this.EmailBccAccountID.Visible = false;
            // 
            // EmailBccAccountName
            // 
            this.EmailBccAccountName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmailBccAccountName.HeaderText = "名稱";
            this.EmailBccAccountName.Name = "EmailBccAccountName";
            this.EmailBccAccountName.Width = 54;
            // 
            // EmailBccAccountAddress
            // 
            this.EmailBccAccountAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmailBccAccountAddress.HeaderText = "郵箱地址";
            this.EmailBccAccountAddress.Name = "EmailBccAccountAddress";
            this.EmailBccAccountAddress.Width = 78;
            // 
            // EmailBccAccountCreateTime
            // 
            this.EmailBccAccountCreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmailBccAccountCreateTime.HeaderText = "创建日期";
            this.EmailBccAccountCreateTime.Name = "EmailBccAccountCreateTime";
            this.EmailBccAccountCreateTime.ReadOnly = true;
            this.EmailBccAccountCreateTime.Width = 78;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.State.HeaderText = "状态";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 54;
            // 
            // index
            // 
            this.index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.index.HeaderText = "";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(607, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 395);
            this.panel3.TabIndex = 54;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCountEnd);
            this.groupBox2.Controls.Add(this.txtCountStart);
            this.groupBox2.Controls.Add(this.lbCount);
            this.groupBox2.Controls.Add(this.btnReplace);
            this.groupBox2.Controls.Add(this.tbNew);
            this.groupBox2.Controls.Add(this.tbOld);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 395);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "替换";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbCount.Location = new System.Drawing.Point(3, 380);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(41, 12);
            this.lbCount.TabIndex = 4;
            this.lbCount.Text = "總數：";
            // 
            // btnReplace
            // 
            this.btnReplace.ForeColor = System.Drawing.Color.Black;
            this.btnReplace.Location = new System.Drawing.Point(20, 91);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(59, 23);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "替换";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // tbNew
            // 
            this.tbNew.Location = new System.Drawing.Point(20, 131);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(169, 21);
            this.tbNew.TabIndex = 2;
            // 
            // tbOld
            // 
            this.tbOld.Location = new System.Drawing.Point(20, 56);
            this.tbOld.Name = "tbOld";
            this.tbOld.Size = new System.Drawing.Size(169, 21);
            this.tbOld.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteExport);
            this.panel1.Controls.Add(this.btnDataExport);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.btnShowOneContactForm);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 43);
            this.panel1.TabIndex = 56;
            // 
            // btnDeleteExport
            // 
            this.btnDeleteExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteExport.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteExport.Location = new System.Drawing.Point(310, 7);
            this.btnDeleteExport.Name = "btnDeleteExport";
            this.btnDeleteExport.Size = new System.Drawing.Size(87, 23);
            this.btnDeleteExport.TabIndex = 57;
            this.btnDeleteExport.Text = "導入刪除數據";
            this.btnDeleteExport.UseVisualStyleBackColor = true;
            this.btnDeleteExport.Click += new System.EventHandler(this.btnDeleteExport_Click);
            // 
            // btnDataExport
            // 
            this.btnDataExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDataExport.ForeColor = System.Drawing.Color.Black;
            this.btnDataExport.Location = new System.Drawing.Point(712, 8);
            this.btnDataExport.Name = "btnDataExport";
            this.btnDataExport.Size = new System.Drawing.Size(81, 23);
            this.btnDataExport.TabIndex = 56;
            this.btnDataExport.Text = "數據導出";
            this.btnDataExport.UseVisualStyleBackColor = true;
            this.btnDataExport.Click += new System.EventHandler(this.btnDataExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Location = new System.Drawing.Point(495, 8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(81, 23);
            this.btnImport.TabIndex = 53;
            this.btnImport.Text = "導入數據";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportExcel.Location = new System.Drawing.Point(620, 8);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(81, 23);
            this.btnExportExcel.TabIndex = 55;
            this.btnExportExcel.Text = "模板導出";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(6, 9);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(197, 21);
            this.tbEmail.TabIndex = 49;
            // 
            // btnShowOneContactForm
            // 
            this.btnShowOneContactForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowOneContactForm.ForeColor = System.Drawing.Color.Black;
            this.btnShowOneContactForm.Location = new System.Drawing.Point(403, 8);
            this.btnShowOneContactForm.Name = "btnShowOneContactForm";
            this.btnShowOneContactForm.Size = new System.Drawing.Size(77, 23);
            this.btnShowOneContactForm.TabIndex = 54;
            this.btnShowOneContactForm.Text = "單個數據";
            this.btnShowOneContactForm.UseVisualStyleBackColor = true;
            this.btnShowOneContactForm.Click += new System.EventHandler(this.btnShowOneContactForm_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Location = new System.Drawing.Point(207, 8);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 22);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(250, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 23);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(41, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 61;
            this.label2.Text = "—";
            // 
            // txtCountEnd
            // 
            this.txtCountEnd.Location = new System.Drawing.Point(60, 343);
            this.txtCountEnd.Name = "txtCountEnd";
            this.txtCountEnd.Size = new System.Drawing.Size(33, 21);
            this.txtCountEnd.TabIndex = 60;
            // 
            // txtCountStart
            // 
            this.txtCountStart.Location = new System.Drawing.Point(6, 343);
            this.txtCountStart.Name = "txtCountStart";
            this.txtCountStart.Size = new System.Drawing.Size(33, 21);
            this.txtCountStart.TabIndex = 59;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 458);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "通訊錄";
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowOneContactForm;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.TextBox tbOld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.Button btnDataExport;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailBccAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailBccAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailBccAccountAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailBccAccountCreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.Button btnDeleteExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountEnd;
        private System.Windows.Forms.TextBox txtCountStart;



    }
}