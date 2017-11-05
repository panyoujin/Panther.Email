namespace Panther.Email.Winform
{
    partial class MainMDIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMDIForm));
            this.btnMain = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnEmailManager = new System.Windows.Forms.Button();
            this.btnNewMail = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.顯示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隱藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGarbage = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.Location = new System.Drawing.Point(12, 12);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(84, 33);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "首 頁";
            this.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(102, 12);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(84, 33);
            this.btnContact.TabIndex = 1;
            this.btnContact.Text = "通訊錄";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnEmailManager
            // 
            this.btnEmailManager.Location = new System.Drawing.Point(192, 12);
            this.btnEmailManager.Name = "btnEmailManager";
            this.btnEmailManager.Size = new System.Drawing.Size(84, 33);
            this.btnEmailManager.TabIndex = 2;
            this.btnEmailManager.Text = "郵件管理";
            this.btnEmailManager.UseVisualStyleBackColor = true;
            this.btnEmailManager.Click += new System.EventHandler(this.btnEmailManager_Click);
            // 
            // btnNewMail
            // 
            this.btnNewMail.Location = new System.Drawing.Point(282, 12);
            this.btnNewMail.Name = "btnNewMail";
            this.btnNewMail.Size = new System.Drawing.Size(84, 33);
            this.btnNewMail.TabIndex = 4;
            this.btnNewMail.Text = "新增郵件";
            this.btnNewMail.UseVisualStyleBackColor = true;
            this.btnNewMail.Click += new System.EventHandler(this.btnNewMail_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "智能郵件發送";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顯示ToolStripMenuItem,
            this.隱藏ToolStripMenuItem,
            this.NewToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 92);
            // 
            // 顯示ToolStripMenuItem
            // 
            this.顯示ToolStripMenuItem.Name = "顯示ToolStripMenuItem";
            this.顯示ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.顯示ToolStripMenuItem.Text = "顯示";
            this.顯示ToolStripMenuItem.Click += new System.EventHandler(this.顯示ToolStripMenuItem_Click);
            // 
            // 隱藏ToolStripMenuItem
            // 
            this.隱藏ToolStripMenuItem.Name = "隱藏ToolStripMenuItem";
            this.隱藏ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.隱藏ToolStripMenuItem.Text = "隱藏";
            this.隱藏ToolStripMenuItem.Click += new System.EventHandler(this.隱藏ToolStripMenuItem_Click);
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.NewToolStripMenuItem.Text = "新增郵件";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // btnGarbage
            // 
            this.btnGarbage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGarbage.Location = new System.Drawing.Point(898, 12);
            this.btnGarbage.Name = "btnGarbage";
            this.btnGarbage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGarbage.Size = new System.Drawing.Size(84, 33);
            this.btnGarbage.TabIndex = 6;
            this.btnGarbage.Text = "垃圾郵件";
            this.btnGarbage.UseVisualStyleBackColor = true;
            this.btnGarbage.Click += new System.EventHandler(this.btnGarbage_Click);
            // 
            // MainMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 507);
            this.Controls.Add(this.btnGarbage);
            this.Controls.Add(this.btnNewMail);
            this.Controls.Add(this.btnEmailManager);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(920, 545);
            this.Name = "MainMDIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能郵件發送";
            this.SizeChanged += new System.EventHandler(this.MainMDIForm_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnEmailManager;
        private System.Windows.Forms.Button btnNewMail;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 顯示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隱藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Button btnGarbage;
    }
}