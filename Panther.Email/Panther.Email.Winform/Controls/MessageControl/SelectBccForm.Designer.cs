namespace Panther.Email.Winform.Controls.MessageControl
{
    partial class SelectBccForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectBccForm));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvBccEmail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailBccAccountAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailBccAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBccEmail)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(244, 9);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "確定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvBccEmail
            // 
            this.dgvBccEmail.AllowUserToAddRows = false;
            this.dgvBccEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBccEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBccEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.EmailBccAccountAddress,
            this.EmailBccAccountID,
            this.index});
            this.dgvBccEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBccEmail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvBccEmail.Location = new System.Drawing.Point(0, 0);
            this.dgvBccEmail.Name = "dgvBccEmail";
            this.dgvBccEmail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvBccEmail.RowHeadersVisible = false;
            this.dgvBccEmail.RowTemplate.Height = 23;
            this.dgvBccEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBccEmail.Size = new System.Drawing.Size(326, 226);
            this.dgvBccEmail.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 20;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "名稱";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 54;
            // 
            // EmailBccAccountAddress
            // 
            this.EmailBccAccountAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmailBccAccountAddress.HeaderText = "郵箱地址";
            this.EmailBccAccountAddress.Name = "EmailBccAccountAddress";
            this.EmailBccAccountAddress.ReadOnly = true;
            this.EmailBccAccountAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmailBccAccountAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EmailBccAccountAddress.Width = 59;
            // 
            // EmailBccAccountID
            // 
            this.EmailBccAccountID.HeaderText = "EmailBccAccountID";
            this.EmailBccAccountID.Name = "EmailBccAccountID";
            this.EmailBccAccountID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmailBccAccountID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EmailBccAccountID.Visible = false;
            // 
            // index
            // 
            this.index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.index.HeaderText = "";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 36);
            this.panel1.TabIndex = 7;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(7, 10);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(207, 21);
            this.tbSearch.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbSelectAll);
            this.panel2.Controls.Add(this.dgvBccEmail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 226);
            this.panel2.TabIndex = 8;
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.Location = new System.Drawing.Point(4, 4);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(15, 14);
            this.cbSelectAll.TabIndex = 5;
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.CheckedChanged += new System.EventHandler(this.cbSelectAll_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Location = new System.Drawing.Point(217, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 22);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SelectBccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 262);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SelectBccForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "選擇密送人";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBccEmail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvBccEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailBccAccountAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailBccAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.Button btnSearch;
    }
}