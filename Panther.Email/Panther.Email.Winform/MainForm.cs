using Panther.Email.Business;
using Panther.Email.Entity.Model;
using Panther.Email.Winform.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace Panther.Email.Winform
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            LoadEvent();
            LoadSendEmail("");
        }

        #region Method
        /// <summary>
        /// 加载发件箱
        /// </summary>
        void LoadSendEmail(string strWhere)
        {
            TreeNode first = null;
            tvSendMailList.Nodes.Clear();
            List<EmailAccount> emailList = EmailAccountBLL.Current.GetModelList(strWhere);
            if (emailList != null)
            {
                foreach (var email in emailList)
                {
                    TreeNode tn = new TreeNode(email.EmailAccountAddress);
                    //tn.Nodes.Add(new TreeNode { Text = "收件箱", ImageIndex = 2, SelectedImageIndex = 2 });
                    //tn.Nodes.Add(new TreeNode { Text = "草稿", ImageIndex = 1, SelectedImageIndex = 1 });
                    //tn.Nodes.Add(new TreeNode { Text = "發件箱", ImageIndex = 3, SelectedImageIndex = 3 });
                    tn.Tag = email;
                    tvSendMailList.Nodes.Add(tn);
                    if (first == null)
                        first = tn;
                }
            }
            if (first != null)
                tvSendMailList.SelectedNode = first;
        }

        void LoadEvent()
        {
            ToolStripMenuItem smidelete = new ToolStripMenuItem("刪除");
            smidelete.Click += new EventHandler(smidelete_Click);
            ToolStripMenuItem smiupdate = new ToolStripMenuItem("刷新");
            smiupdate.Click += smiupdate_Click;

            cmsTreeViewShow.Items.Add(smidelete);
            cmsTreeViewShow.Items.Add(smiupdate);
        }

        #region ToolStripMenuItem

        void smidelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("刪除該郵箱涉及到的記錄數據？", "刪除提示框", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (tvSendMailList.SelectedNode != null)
            {
                if (tvSendMailList.SelectedNode.Tag is EmailAccount)
                {
                    EmailAccount ea = tvSendMailList.SelectedNode.Tag as EmailAccount;
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (EmailAccountBLL.Current.Delete(ea.EmailAccountID))
                        {
                            //删除EmailSendAccount
                            List<EmailSendAccount> EmailSendAccountList = EmailSendAccountBLL.Current.GetModelList(string.Format(" EmailAccountID='{0}'", ea.EmailAccountID));
                            foreach (EmailSendAccount emailSendAccount in EmailSendAccountList)
                            {
                                EmailSendAccountBLL.Current.Delete(emailSendAccount.EmailSendAccountID);
                            }
                            //删除EmailSendBccAccount
                            List<EmailSendBccAccount> EmailSendBccAccountList = EmailSendBccAccountBLL.Current.GetModelList(string.Format(" EmailAccountID='{0}'", ea.EmailAccountID));
                            foreach (EmailSendBccAccount emailSendBccAccount in EmailSendBccAccountList)
                            {
                                EmailSendBccAccountBLL.Current.Delete(emailSendBccAccount.EmailSendBccAccountID);
                            }
                            //删除EmailSendFailur
                            List<EmailSendFailure> EmailSendFailureList = EmailSendFailureBLL.Current.GetModelList(string.Format(" EmailAccountID='{0}'", ea.EmailAccountID));
                            foreach (EmailSendFailure emailSendFailure in EmailSendFailureList)
                            {
                                EmailSendFailureBLL.Current.Delete(emailSendFailure.EmailSendFailureID);
                            }
                            //删除邮件跟未发送
                            if (EmailSendAccountList != null && EmailSendAccountList.Count>0)
                            {
                                List<EmailSendAccount> EmailSendAccountByEmail = EmailSendAccountBLL.Current.GetModelList(string.Format(" EmailID='{0}'", EmailSendAccountList.First().EmailID));
                                if (EmailSendAccountByEmail == null || EmailSendAccountByEmail.Count == 0)
                                {
                                    List<EmailSendBccAccount> EmailSendBccAccountByEmail = EmailSendBccAccountBLL.Current.GetModelList(string.Format(" EmailID='{0}'", EmailSendAccountList.First().EmailID));
                                    foreach (EmailSendBccAccount eailSendBccAccountByEmailOne in EmailSendBccAccountByEmail)
                                    {
                                        EmailSendBccAccountBLL.Current.Delete(eailSendBccAccountByEmailOne.EmailSendBccAccountID);
                                    }
                                    EmailInfo info = EmailInfoBLL.Current.GetModel(EmailSendAccountList.First().EmailID);
                                    if (info != null)
                                    {
                                        if (File.Exists(info.EmailFilePath))
                                        {
                                            File.Delete(info.EmailFilePath);
                                        }
                                        EmailInfoBLL.Current.Delete(EmailSendAccountList.First().EmailID);
                                    }
                                }
                            }

                        }
                        scope.Complete();
                    }
                    
                    LoadSendEmail("");
                }
            }
        }

        void smiupdate_Click(object sender, EventArgs e)
        {
            LoadSendEmail("");
        }
        #endregion
        #endregion

        #region Event
        /// <summary>
        /// 樹控件右鍵事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvSendMailList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.Node.Parent != null || e.Node == null) return;
            tvSendMailList.SelectedNode = e.Node;
            cmsTreeViewShow.Show(tvSendMailList, e.X, e.Y);
        }

        /// <summary>
        /// 郵箱樹控件的選擇事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (sender != null)
            {
                TreeNode tn = (sender as TreeView).SelectedNode;
                switch (tn.Text.ToString())
                {
                    case "收件箱":
                        panBody.Controls.Clear();
                        ReceiptControl rc = new ReceiptControl();
                        rc.Dock = DockStyle.Fill;
                        rc.AutoSize = true;
                        panBody.Controls.Add(rc);
                        break;
                    case "草稿":
                        panBody.Controls.Clear();
                        DraftControl dc = new DraftControl();
                        dc.Dock = DockStyle.Fill;
                        dc.AutoSize = true;
                        panBody.Controls.Add(dc);
                        break;
                    case "發件箱":
                        panBody.Controls.Clear();
                        SendControlControl scc = new SendControlControl();
                        scc.Dock = DockStyle.Fill;
                        scc.AutoSize = true;
                        panBody.Controls.Add(scc);
                        break;
                    default:
                        panBody.Controls.Clear();
                        EditSendMail esm = new EditSendMail(tn.Text.Trim(), tn.Tag as EmailAccount);
                        esm.Dock = DockStyle.Fill;
                        esm.AutoSize = true;
                        panBody.Controls.Add(esm);
                        break;
                }
            }
        }

        /// <summary>
        /// 新增發送郵箱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSendMail_Click(object sender, EventArgs e)
        {
            AddSendMail addSendMail = new AddSendMail();
            addSendMail.FormClosed += addSendMail_FormClosed;
            btnAddSendMail.Enabled = false;
            addSendMail.Show();
        }

        /// <summary>
        /// 新增發送郵箱關閉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addSendMail_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnAddSendMail.Enabled = true;
            LoadSendEmail("");
        }

        /// <summary>
        /// 通訊錄彈出窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContact_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.FormClosed += contactsForm_FormClosed;
            btnContact.Enabled = false;

            //contactsForm.MdiParent = this;
            //contactsForm.Location = new System.Drawing.Point(0, 102);
            contactsForm.Show();
        }
        /// <summary>
        /// 通訊錄彈出窗口關閉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void contactsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnContact.Enabled = true;
        }


        /// <summary>
        /// 新建消息彈出窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewMessage_Click(object sender, EventArgs e)
        {
            NewMessageForm newMessageForm = new NewMessageForm();
            //newMessageForm.MdiParent = this;
            //newMessageForm.Location = new System.Drawing.Point(0, 102);
            newMessageForm.Show();
        }
        #endregion

        private void btnEmainManager_Click(object sender, EventArgs e)
        {
            //EmailManager email = new EmailManager();
            //email.Show();
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm is EmailManagerForm)
                {
                    childrenForm.Activate();
                    return;
                }
            }
            EmailManagerForm email = new EmailManagerForm();
            email.MdiParent = this;
            email.Location = new System.Drawing.Point(0, 102);
            email.Show();
        }

        private void btnSendSearch_Click(object sender, EventArgs e)
        {
            string strSQL = string.Format(" EmailAccountAddress like '%{0}%'", tbSendSearch.Text.Trim());
            LoadSendEmail(strSQL);
        }

        private void tbSendSearch_TextChanged(object sender, EventArgs e)
        {
            string strSQL = string.Format(" EmailAccountAddress like '%{0}%'", tbSendSearch.Text.Trim());
            LoadSendEmail(strSQL);
        }


    }
}
