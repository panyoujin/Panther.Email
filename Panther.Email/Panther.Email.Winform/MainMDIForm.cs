using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Panther.Email.Core.Log;
using System.Drawing.Drawing2D;

namespace Panther.Email.Winform
{
    public partial class MainMDIForm : Form
    {
        public MainMDIForm()
        {
            InitializeComponent();
            btnMain_Click(null, null);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            LayouMdi(new MainForm(), "MainForm");
        }


        private void btnContact_Click(object sender, EventArgs e)
        {
            LayouMdi(new ContactsForm(), "ContactsForm");
        }

        private void btnEmailManager_Click(object sender, EventArgs e)
        {
            LayouMdi(new EmailManagerForm(), "EmailManagerForm");
        }


        void LayouMdi(Form form, string name)
        {
            try
            {
                bool isExistForm = false;
                foreach (var children in this.MdiChildren)
                {
                    if (children.Text.Equals(name))
                    {
                        //children.Activate();
                        children.Show();
                        isExistForm = true;
                    }
                    else
                    {
                        children.Hide();
                    }
                }
                if (!isExistForm)
                {
                    form.MdiParent = this;
                    form.Text = name;
                    form.Location = new Point(10, 50);
                    form.Width = this.Width - 40;
                    form.Height = this.Height - 100;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("主窗口", "彈出子窗口", ex.Message, ex);
                MessageBox.Show("操作失敗請稍後重試,如重複出現錯誤請關閉軟件再打開使用");
            }
        }

        private void MainMDIForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)  //判断是否最小化
            {
                this.ShowInTaskbar = false;  //不显示在系统任务栏
                notifyIcon1.Visible = true;  //托盘图标可见
            }
            else
            {
                foreach (var children in this.MdiChildren)
                {
                    children.Width = this.Width - 40;
                    children.Height = this.Height - 100;
                }
            }
        }

        private void btnNewMail_Click(object sender, EventArgs e)
        {
            NewMessageForm newMail = new NewMessageForm();
            newMail.Show();
        }


        #region 任務欄
        private void 顯示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }

        private void 隱藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //隐藏托盘程序中的图标
            notifyIcon1.Visible = false;
            //关闭系统
            this.Close();
            this.Dispose(true);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMessageForm newMail = new NewMessageForm();
            newMail.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }
        #endregion 任務欄

        private void btnGarbage_Click(object sender, EventArgs e)
        {
            LayouMdi(new GarbageEmail(), "GarbageEmail");
        }


    }
}
