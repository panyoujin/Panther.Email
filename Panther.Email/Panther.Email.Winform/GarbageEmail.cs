using Panther.Email.Business;
using Panther.Email.Core.Log;
using Panther.Email.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Panther.Email.Winform
{
    public partial class GarbageEmail : Form
    {
        private int _countStart = 0;
        private int _countEnd = 100;
        public GarbageEmail()
        {
            InitializeComponent();
            txtCountStart.Text = "0";
            txtCountEnd.Text = "100";
            LoadEvent();
            this.Load += GarbageEmail_Load;
        }

        void GarbageEmail_Load(object sender, EventArgs e)
        {
            Init(" EmailIsDel=1 order by EmailCreateTime desc");
        }

        private void LoadEvent()
        {
            ToolStripMenuItem Recovery = new ToolStripMenuItem("恢復郵件");
            Recovery.Click += Recovery_Click;
            ToolStripMenuItem sendDeleteMore = new ToolStripMenuItem("刪除勾選的郵件");
            sendDeleteMore.Click += sendDeleteMore_Click;
            ToolStripMenuItem sendDelete = new ToolStripMenuItem("刪除");
            sendDelete.Click += sendDelete_Click;
            ToolStripMenuItem sendRefresh = new ToolStripMenuItem("刷新");
            sendRefresh.Click += sendRefresh_Click;

            cmsTreeViewShow.Items.Add(Recovery);
            cmsTreeViewShow.Items.Add(sendDeleteMore);
            cmsTreeViewShow.Items.Add(sendDelete);
            cmsTreeViewShow.Items.Add(sendRefresh);
        }


        #region ToolStripMenuItem
        void Recovery_Click(object sender, EventArgs e)
        {
            TreeView tree = tvSendMail;
            if (tree == null || tree.SelectedNode == null)
            {
                LogHelper.Info("請選擇需要删除的郵件");
                return;
            }
            EmailInfo email = tree.SelectedNode.Tag as EmailInfo;
            email.EmailIsDel = false;
            if (EmailInfoBLL.Current.Update(email))
            {
                Init(" EmailIsDel=1 order by EmailCreateTime desc");
            }
        }

        void sendDeleteMore_Click(object sender, EventArgs e)
        {
            TreeView tree = tvSendMail;
            if (tree == null)
            {
                return;
            }
            if (MessageBox.Show("是否對郵件進行刪除操作？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (TreeNode node in tree.Nodes)
                {
                    if (node.Checked)
                    {
                        EmailInfo ei = node.Tag as EmailInfo;
                        if (EmailInfoBLL.Current.Delete(ei.EmailID))
                        {
                            EmailSendAccountBLL.Current.DeleteByEmailID(ei.EmailID);
                            EmailSendBccAccountBLL.Current.DeleteByEmailID(ei.EmailID);
                        }
                    }
                }
                Init("  EmailIsDel=1 order by EmailCreateTime desc");
            }
        }

        void sendRefresh_Click(object sender, EventArgs e)
        {
            Init(" EmailIsDel=1 order by EmailCreateTime desc");
        }
        void sendDelete_Click(object sender, EventArgs e)
        {
            TreeView tree = tvSendMail;
            if (tree == null || tree.SelectedNode == null)
            {
                LogHelper.Info("請選擇需要删除的郵件");
                return;
            }
            EmailInfo email = tree.SelectedNode.Tag as EmailInfo;
            if (email == null || string.IsNullOrEmpty(email.EmailID))
            {
                LogHelper.Info("操作的郵件信息為空。");
                return;
            }
            string emailID = email.EmailID;

            #region 临时处理没做事务
            if (MessageBox.Show("是否對郵件進行刪除操作？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (EmailInfoBLL.Current.Delete(emailID))
                {
                    EmailSendAccountBLL.Current.DeleteByEmailID(emailID);
                    EmailSendBccAccountBLL.Current.DeleteByEmailID(emailID);
                    Init("  EmailIsDel=1 order by EmailCreateTime desc");
                }
            }
            #endregion
        }
        #endregion

        private void Init(string strWhere)
        {
            TreeNode first = null;
            tvSendMail.Nodes.Clear();
            List<EmailInfo> emailList = EmailInfoBLL.Current.GetModelList(strWhere);
            emailList.OrderBy(e => e.EmailCreateTime);
            if (emailList != null)
            {
                foreach (var email in emailList)
                {
                    TreeNode tn = new TreeNode(Text = email.EmailTitle);
                    tn.Tag = email;
                    tvSendMail.Nodes.Add(tn);
                    if (first == null)
                        first = tn;
                }
            }
            if (first != null)
            {
                tvSendMail.SelectedNode = first;
            }
            else
            {
                dgvSendAccount.Rows.Clear();
                dgvSendList.Rows.Clear();
            }
        }

        private void tvSendMail_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (sender != null)
            {
                TreeNode tn = (sender as TreeView).SelectedNode;
                EmailInfo entity = tn.Tag as EmailInfo;
                if (entity != null)
                {
                    LoadTsbPageSend(entity.EmailID);
                    LoadTabPageBcc(entity.EmailID);
                }
                else
                {
                    dgvSendAccount.Rows.Clear();
                    dgvSendList.Rows.Clear();
                }
            }
        }


        /// <summary>
        /// 加载发送帐号列表
        /// </summary>
        /// <param name="emailID"></param>
        private void LoadTsbPageSend(string emailID)
        {
            string tableSql = @" (EmailSendAccount as esa  left join EmailInfo as ei on ei.EmailID = esa.EmailID)  left join EmailAccount as ea on ea.EmailAccountID = esa.EmailAccountID ";
            string strWhere = string.Format(" esa.EmailID = '{0}'", emailID);
            string orderby = " EmailAccountAddress ";
            string columns = "esa.EmailSendAccountID,ei.EmailTitle,ea.EmailAccountAddress ";
            int sendAccountCount = EmailSendAccountBLL.Current.GetRecordCount(tableSql, strWhere);
            int startIndex = 0;
            int endIndex = sendAccountCount;
            if (endIndex > 0)
            {
                DataSet ds = EmailSendAccountBLL.Current.GetListByPage(tableSql, strWhere, orderby, startIndex, endIndex, columns);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    InsertColumn(dgvSendAccount, ds.Tables[0]);
                }
            }
            else
            {
                dgvSendAccount.Rows.Clear();
            }
        }

        /// <summary>
        /// 加载发送状态列表
        /// </summary>
        /// <param name="emailID"></param>
        private void LoadTabPageBcc(string emailID)
        {
            string tableSql = @" (( EmailSendBccAccount as esba left join EmailInfo as ei on ei.EmailID = esba.EmailID )   
left join EmailBccAccount as eba on eba.EmailBccAccountID = esba.EmailBccAccountID ) 
left join EmailAccount as ea on ea.EmailAccountID = esba.EmailAccountID ";
            string strWhere = string.Format(" esba.EmailID = '{0}'", emailID);
            string orderby = " EmailSendBccAccountCreateTime,EmailBccAccountAddress ";
            string columns = @" esba.EmailSendBccAccountID,ei.EmailTitle,eba.EmailBccAccountAddress,ea.EmailAccountAddress
,case esba.EmailSendBccAccountState when -1 then '发送失败' when 1 then '已发送' when  0 then '未发送' when 2 then '停止發送' when 3 then '正在發送' else '未知' end as EmailSendBccAccountState
,esba.EmailSendBccAccountSendTIme,esba.EmailSendBccAccountCreateTime ";
            int sendAccountCount = EmailSendAccountBLL.Current.GetRecordCount(tableSql, strWhere);
            txtCount.Text = sendAccountCount.ToString();

            Int32.TryParse(txtCountStart.Text, out _countStart);
            Int32.TryParse(txtCountEnd.Text, out _countEnd);
            if (_countEnd > sendAccountCount)
            {
                _countEnd = sendAccountCount;
            }
            if (_countStart >= _countEnd)
            {
                if (_countStart != 0)
                {
                    _countStart = _countEnd - 1;
                }
            }
            txtCountStart.Text = _countStart.ToString();
            txtCountEnd.Text = _countEnd.ToString();
            int startIndex = _countStart;
            int endIndex = _countEnd;
            if (endIndex > 0)
            {
                DataSet ds = EmailSendAccountBLL.Current.GetListByPage(tableSql, strWhere, orderby, startIndex, endIndex, columns);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    InsertColumn(dgvSendList, ds.Tables[0]);
                }
            }
            else
            {
                dgvSendList.Rows.Clear();
            }
        }
        private void InsertColumn(DataGridView dgv, DataTable dt)
        {
            dgv.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                check.Tag = dr[0];
                check.Value = false;
                dgvr.Cells.Add(check);
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    DataGridViewTextBoxCell EmailTitle = new DataGridViewTextBoxCell();
                    EmailTitle.Value = dr[i];
                    dgvr.Cells.Add(EmailTitle);
                }
                dgv.Rows.Add(dgvr);
            }

        }

        private void tvSendMail_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.Node.Parent != null || e.Node == null) return;
            tvSendMail.SelectedNode = e.Node;
            cmsTreeViewShow.Show(tvSendMail, e.X, e.Y);
        }

        private void tvSendMail_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                TreeNode tn = tvSendMail.SelectedNode;
                if (tn == null)
                {
                    return;
                }
                EmailInfo entity = tn.Tag as EmailInfo;
                if (entity != null)
                {
                    NewMessageForm message = new NewMessageForm(entity);
                    message.Text = entity.EmailTitle;
                    message.Show();
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("郵件管理", "雙擊打開郵件時出錯", ex.Message, ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TreeNode tn = tvSendMail.SelectedNode;
            EmailInfo entity = tn.Tag as EmailInfo;
            if (entity != null)
            {
                LoadTsbPageSend(entity.EmailID);
                LoadTabPageBcc(entity.EmailID);
            }
        }

    }
}
