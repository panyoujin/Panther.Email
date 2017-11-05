namespace Panther.Email.Winform.Controls.MessageControl
{
    partial class SelectReceptForm
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
            this.dgvReceptEmail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmailBccAccountAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailBccAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceptEmail
            // 
            this.dgvReceptEmail.AllowUserToAddRows = false;
            this.dgvReceptEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceptEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.EmailBccAccountAddress,
            this.EmailBccAccountID});
            this.dgvReceptEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvReceptEmail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvReceptEmail.Location = new System.Drawing.Point(0, 0);
            this.dgvReceptEmail.Name = "dgvReceptEmail";
            this.dgvReceptEmail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvReceptEmail.RowHeadersVisible = false;
            this.dgvReceptEmail.RowTemplate.Height = 23;
            this.dgvReceptEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReceptEmail.Size = new System.Drawing.Size(326, 211);
            this.dgvReceptEmail.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(251, 227);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "確定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.Location = new System.Drawing.Point(4, 217);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(48, 16);
            this.cbSelectAll.TabIndex = 7;
            this.cbSelectAll.Text = "全選";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.CheckedChanged += new System.EventHandler(this.cbSelectAll_CheckedChanged);
            // 
            // SelectReceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 262);
            this.Controls.Add(this.cbSelectAll);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvReceptEmail);
            this.Name = "SelectReceptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "選擇收件人";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceptEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailBccAccountAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailBccAccountID;
    }
}