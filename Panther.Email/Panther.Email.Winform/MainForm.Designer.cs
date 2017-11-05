namespace Panther.Email.Winform
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewMessage = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnEmainManager = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tvSendMailList = new System.Windows.Forms.TreeView();
            this.cmsTreeViewShow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddSendMail = new System.Windows.Forms.Button();
            this.tbSendSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panBody = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNewMessage);
            this.flowLayoutPanel1.Controls.Add(this.btnContact);
            this.flowLayoutPanel1.Controls.Add(this.btnEmainManager);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(890, 44);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Visible = false;
            // 
            // btnNewMessage
            // 
            this.btnNewMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewMessage.BackgroundImage")));
            this.btnNewMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewMessage.Location = new System.Drawing.Point(10, 10);
            this.btnNewMessage.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnNewMessage.Name = "btnNewMessage";
            this.btnNewMessage.Size = new System.Drawing.Size(78, 23);
            this.btnNewMessage.TabIndex = 2;
            this.btnNewMessage.Text = "新建消息";
            this.btnNewMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewMessage.UseVisualStyleBackColor = true;
            this.btnNewMessage.Visible = false;
            this.btnNewMessage.Click += new System.EventHandler(this.btnNewMessage_Click);
            // 
            // btnContact
            // 
            this.btnContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContact.BackgroundImage")));
            this.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContact.Location = new System.Drawing.Point(98, 10);
            this.btnContact.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(65, 23);
            this.btnContact.TabIndex = 3;
            this.btnContact.Text = "通訊錄";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Visible = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnEmainManager
            // 
            this.btnEmainManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmainManager.BackgroundImage")));
            this.btnEmainManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmainManager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmainManager.Location = new System.Drawing.Point(173, 10);
            this.btnEmainManager.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnEmainManager.Name = "btnEmainManager";
            this.btnEmainManager.Size = new System.Drawing.Size(85, 23);
            this.btnEmainManager.TabIndex = 5;
            this.btnEmainManager.Text = "郵件管理";
            this.btnEmainManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmainManager.UseVisualStyleBackColor = true;
            this.btnEmainManager.Visible = false;
            this.btnEmainManager.Click += new System.EventHandler(this.btnEmainManager_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 44);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 449);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // tvSendMailList
            // 
            this.tvSendMailList.BackColor = System.Drawing.SystemColors.Control;
            this.tvSendMailList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvSendMailList.ContextMenuStrip = this.cmsTreeViewShow;
            this.tvSendMailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSendMailList.ImageIndex = 0;
            this.tvSendMailList.ImageList = this.imageList1;
            this.tvSendMailList.Location = new System.Drawing.Point(3, 43);
            this.tvSendMailList.Name = "tvSendMailList";
            this.tvSendMailList.SelectedImageIndex = 0;
            this.tvSendMailList.ShowRootLines = false;
            this.tvSendMailList.Size = new System.Drawing.Size(194, 403);
            this.tvSendMailList.TabIndex = 1;
            this.tvSendMailList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.tvSendMailList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvSendMailList_NodeMouseClick);
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
            this.imageList1.Images.SetKeyName(0, "mail.png");
            this.imageList1.Images.SetKeyName(1, "draftMail.png");
            this.imageList1.Images.SetKeyName(2, "receiptsMail.png");
            this.imageList1.Images.SetKeyName(3, "sendMail.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddSendMail);
            this.panel2.Controls.Add(this.tbSendSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 26);
            this.panel2.TabIndex = 0;
            // 
            // btnAddSendMail
            // 
            this.btnAddSendMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSendMail.BackgroundImage")));
            this.btnAddSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddSendMail.Location = new System.Drawing.Point(169, 1);
            this.btnAddSendMail.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddSendMail.Name = "btnAddSendMail";
            this.btnAddSendMail.Size = new System.Drawing.Size(25, 23);
            this.btnAddSendMail.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnAddSendMail, "添加发件箱地址");
            this.btnAddSendMail.UseVisualStyleBackColor = true;
            this.btnAddSendMail.Click += new System.EventHandler(this.btnAddSendMail_Click);
            // 
            // tbSendSearch
            // 
            this.tbSendSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSendSearch.Location = new System.Drawing.Point(2, 2);
            this.tbSendSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tbSendSearch.Name = "tbSendSearch";
            this.tbSendSearch.Size = new System.Drawing.Size(167, 21);
            this.tbSendSearch.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbSendSearch, "请输入搜索内容");
            this.tbSendSearch.TextChanged += new System.EventHandler(this.tbSendSearch_TextChanged);
            // 
            // panBody
            // 
            this.panBody.AutoSize = true;
            this.panBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBody.Location = new System.Drawing.Point(200, 44);
            this.panBody.Name = "panBody";
            this.panBody.Size = new System.Drawing.Size(690, 449);
            this.panBody.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvSendMailList);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "郵箱列表";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 449);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 493);
            this.Controls.Add(this.panBody);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "自郵便捷系統";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNewMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSendSearch;
        private System.Windows.Forms.TreeView tvSendMailList;
        private System.Windows.Forms.Button btnAddSendMail;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panBody;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.ContextMenuStrip cmsTreeViewShow;
        private System.Windows.Forms.Button btnEmainManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;




    }
}