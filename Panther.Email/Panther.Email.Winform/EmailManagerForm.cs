using Panther.Email.Business;
using Panther.Email.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Panther.Email.Core.Log;
using Panther.Email.Winform.Common;

namespace Panther.Email.Winform
{
    public partial class EmailManagerForm : Form
    {

        private int _countStart = 0;
        private int _countEnd = 100;

        public EmailManagerForm()
        {
            InitializeComponent();
            txtCountStart.Text = "0";
            txtCountEnd.Text = "100";
            LoadEvent();
            this.Load += EmailManagerForm_Load;

        }

        void EmailManagerForm_Load(object sender, EventArgs e)
        {
            Init(" EmailIsDel=0 order by EmailCreateTime desc");
        }

        private void LoadEvent()
        {
            ToolStripMenuItem sendStop = new ToolStripMenuItem("停止的邮件重新发送");
            sendStop.Click += sendsendStop_Click;
            ToolStripMenuItem sendFail = new ToolStripMenuItem("發送失敗郵件重新發送");
            sendFail.Click += sendFail_Click;
            ToolStripMenuItem exportSuccess = new ToolStripMenuItem("導出發送成功郵箱");
            exportSuccess.Click += exportSuccess_Click;
            ToolStripMenuItem exportFail = new ToolStripMenuItem("導出發送失敗郵箱");
            exportFail.Click += exportFail_Click;
            ToolStripMenuItem exportStop = new ToolStripMenuItem("導出停止發送郵箱");
            exportStop.Click += exportStop_Click;
            ToolStripMenuItem exportNotSend = new ToolStripMenuItem("導出未發送郵箱");
            exportNotSend.Click += exportNotSend_Click;
            ToolStripMenuItem sendDeleteMore = new ToolStripMenuItem("刪除勾選的郵件");
            sendDeleteMore.Click += sendDeleteMore_Click;
            ToolStripMenuItem sendDelete = new ToolStripMenuItem("刪除");
            sendDelete.Click += sendDelete_Click;
            ToolStripMenuItem sendRefresh = new ToolStripMenuItem("刷新");
            sendRefresh.Click += sendRefresh_Click;

            cmsTreeViewShow.Items.Add(sendStop);
            cmsTreeViewShow.Items.Add(sendFail);
            cmsTreeViewShow.Items.Add(exportSuccess);
            cmsTreeViewShow.Items.Add(exportFail);
            cmsTreeViewShow.Items.Add(exportStop);
            cmsTreeViewShow.Items.Add(exportNotSend);
            cmsTreeViewShow.Items.Add(sendDeleteMore);
            cmsTreeViewShow.Items.Add(sendDelete);
            cmsTreeViewShow.Items.Add(sendRefresh);
        }

        #region ToolStripMenuItem
        void sendRefresh_Click(object sender, EventArgs e)
        {
            Init(" EmailIsDel=0 order by EmailCreateTime desc");
        }
        void sendDeleteMore_Click(object sender, EventArgs e)
        {
            TreeView tree = tvSendMail;
            if (tree == null)
            {
                return;
            }
            foreach (TreeNode node in tree.Nodes)
            {
                if (node.Checked)
                {
                    EmailInfo ei = node.Tag as EmailInfo;
                    if (ei == null) continue;
                    ei.EmailIsDel = true;
                    EmailInfoBLL.Current.Update(ei);
                }
            }
            Init(" EmailIsDel=0 order by EmailCreateTime desc");
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
            email.EmailIsDel = true;
            if (EmailInfoBLL.Current.Update(email))
            {
                Init(" EmailIsDel=0 order by EmailCreateTime desc");
            }
        }
        void sendFail_Click(object sender, EventArgs e)
        {
            try
            {
                TreeView tree = tvSendMail;
                if (tree == null || tree.SelectedNode == null)
                {
                    LogHelper.Info("請選擇需要操作的郵件");
                    return;
                }
                EmailInfo email = tree.SelectedNode.Tag as EmailInfo;
                if (email == null || string.IsNullOrEmpty(email.EmailID))
                {
                    LogHelper.Info("發送失敗郵件重新發送時，操作的郵件信息為空。");
                    return;
                }
                string emailID = email.EmailID;
                if (MessageBox.Show(string.Format("是否對郵件【{0}】的所有失敗記錄進行重新發送操作？", email.EmailTitle), "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //修改為啟動發送
                    EmailInfoBLL.Current.UpdateEmailState(emailID, 0);
                    //修改為未發送
                    EmailSendBccAccountBLL.Current.UpdateSendState(emailID, 0, "-1");
                    EmailSendBccAccountBLL.Current.UpdateSendState(emailID, 0, "3");
                    LoadTabPageBcc(emailID);
                    MessageBox.Show("發送失敗郵件重新發送成功！");
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("郵件管理", "發送失敗郵件重新發送", ex.Message, ex);
                MessageBox.Show("發送失敗郵件重新發送失敗，請重試！");
            }
        }

        void sendsendStop_Click(object sender, EventArgs e)
        {
            try
            {
                TreeView tree = tvSendMail;
                if (tree == null || tree.SelectedNode == null)
                {
                    LogHelper.Info("請選擇需要操作的郵件");
                    return;
                }
                EmailInfo email = tree.SelectedNode.Tag as EmailInfo;
                if (email == null || string.IsNullOrEmpty(email.EmailID))
                {
                    LogHelper.Info("全部郵件重新發送時，操作的郵件信息為空。");
                    return;
                }
                string emailID = email.EmailID;
                if (MessageBox.Show(string.Format("是否對郵件【{0}】的所有記錄進行重新發送操作？", email.EmailTitle), "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //修改為啟動發送
                    EmailInfoBLL.Current.UpdateEmailState(emailID, 0);
                    //修改為未發送
                    EmailSendBccAccountBLL.Current.UpdateSendState(emailID, 0, "2");

                    MessageBox.Show("全部郵件重新發送成功！");
                    LoadTabPageBcc(emailID);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("郵件管理", "全部郵件重新發送", ex.Message, ex);
                MessageBox.Show("全部郵件重新發送失敗，請重試！");
            }
        }


        void exportSuccess_Click(object sender, EventArgs e)
        {
            try
            {
                GetExportEmailBccAccount(1);
            }
            catch (Exception ex)
            {
                LogHelper.Error("導出發送成功的郵箱", "導出發送成功的郵箱", ex.Message, ex);
                MessageBox.Show("導出失敗");
            }
        }
        void exportFail_Click(object sender, EventArgs e)
        {
            try
            {
                GetExportEmailBccAccount(-1);
            }
            catch (Exception ex)
            {
                LogHelper.Error("導出發送失敗的郵箱", "導出發送失敗的郵箱", ex.Message, ex);
                MessageBox.Show("導出失敗");
            }
        }

        void exportStop_Click(object sender, EventArgs e)
        {
            try
            {
                GetExportEmailBccAccount(2);
            }
            catch (Exception ex)
            {
                LogHelper.Error("導出停止發送的郵箱", "導出停止發送的郵箱", ex.Message, ex);
                MessageBox.Show("導出失敗");
            }
        }

        void exportNotSend_Click(object sender, EventArgs e)
        {
            try
            {
                GetExportEmailBccAccount(0);
            }
            catch (Exception ex)
            {
                LogHelper.Error("導出未發送的郵箱", "導出未發送的郵箱", ex.Message, ex);
                MessageBox.Show("導出失敗");
            }
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
                    InsertColumn(dgvSendAccount, ds.Tables[0], 1);
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
        private void InsertColumn(DataGridView dgv, DataTable dt, int index = 0)
        {
            dgv.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                check.Tag = dr[0];
                check.Value = false;
                dgvr.Cells.Add(check);
                for (int i = index; i < dt.Columns.Count; i++)
                {
                    DataGridViewTextBoxCell EmailTitle = new DataGridViewTextBoxCell();
                    EmailTitle.Value = dr[i];
                    dgvr.Cells.Add(EmailTitle);
                }
                dgv.Rows.Add(dgvr);
            }

        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    string str = string.Format(" EmailTitle like '%{0}%'", tbSearch.Text.Trim());
        //    Init(str);
        //}

        private void tvSendMail_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.Node.Parent != null || e.Node == null) return;
            tvSendMail.SelectedNode = e.Node;
            cmsTreeViewShow.Show(tvSendMail, e.X, e.Y);
        }

        //private void tbSearch_TextChanged(object sender, EventArgs e)
        //{
        //    string str = string.Format(" EmailTitle like '%{0}%'", tbSearch.Text.Trim());
        //    Init(str);
        //}

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode tn = tvSendMail.SelectedNode;
                if (tn == null)
                {
                    MessageBox.Show("請選中左邊需要刪除的郵件，再進行刪除操作");
                    return;
                }
                EmailInfo entity = tn.Tag as EmailInfo;
                if (entity == null)
                {
                    MessageBox.Show("請選中左邊需要刪除的郵件，再進行刪除操作");
                    return;
                }
                if (MessageBox.Show(string.Format("是否刪除郵件【{0}】的所有發送記錄？", entity.EmailTitle), "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    EmailSendBccAccountBLL.Current.DeleteByEmailID(entity.EmailID);
                    MessageBox.Show("刪除成功");
                }

            }
            catch (Exception ex)
            {
                LogHelper.Error("郵件管理", "刪除全部", ex.Message, ex);
            }
        }

        private void btnStopSend_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode tn = tvSendMail.SelectedNode;
                if (tn == null)
                {
                    MessageBox.Show("請選中左邊需要刪除的郵件，再進行刪除操作");
                    return;
                }
                EmailInfo entity = tn.Tag as EmailInfo;
                if (entity == null)
                {
                    MessageBox.Show("請選中左邊需要停止的郵件，再進行停止操作");
                    return;
                }
                if (MessageBox.Show(string.Format("是否停止發送郵件【{0}】？", entity.EmailTitle), "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    EmailInfoBLL.Current.UpdateEmailState(entity.EmailID, 1);
                    //所有未發送的改為停止發送
                    EmailSendBccAccountBLL.Current.UpdateSendState(entity.EmailID, 2, "0");
                    LoadTabPageBcc(entity.EmailID);
                    MessageBox.Show("停止發送郵件成功！");
                }

            }
            catch (Exception ex)
            {
                LogHelper.Error("郵件管理", "刪除全部", ex.Message, ex);
            }
        }

        private void btnFailure_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode tn = tvSendMail.SelectedNode;
                if (tn == null)
                {
                    MessageBox.Show("請選中左邊需要刪除的郵件，再進行刪除操作");
                    return;
                }
                EmailInfo entity = tn.Tag as EmailInfo;
                if (entity == null)
                {
                    MessageBox.Show("請選中左邊需要刪除的郵件，再進行刪除操作");
                    return;
                }
                if (MessageBox.Show(string.Format("是否刪除郵件【{0}】的所有失敗記錄？", entity.EmailTitle), "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    EmailSendBccAccountBLL.Current.DeleteByEmailID(entity.EmailID, "-1");
                    MessageBox.Show("刪除成功");
                }

            }
            catch (Exception ex)
            {
                LogHelper.Error("郵件管理", "刪除全部", ex.Message, ex);
            }
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂时还未实现");
        }

        private void btnExportSuccess_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂时还未实现");
        }

        private void btnExportStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂时还未实现");
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
            SearchBccAccount();
        }

        void SearchBccAccount()
        {
            TreeNode tn = tvSendMail.SelectedNode;
            if (tn == null)
            {
                return;
            }
            EmailInfo entity = tn.Tag as EmailInfo;
            string tableSql = @" (( EmailSendBccAccount as esba left join EmailInfo as ei on ei.EmailID = esba.EmailID )   
                                left join EmailBccAccount as eba on eba.EmailBccAccountID = esba.EmailBccAccountID ) 
left join EmailAccount as ea on ea.EmailAccountID = esba.EmailAccountID ";
            string strWhere = string.Format(" esba.EmailID = '{0}' and eba.EmailBccAccountAddress like '%{1}%'", entity.EmailID, tbSearch.Text.Trim());
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowOne in dgvSendList.Rows)
            {
                DataGridViewCheckBoxCell one = rowOne.Cells[0] as DataGridViewCheckBoxCell;
                if (one != null && one.Value != null && (bool)one.Value == true)
                {
                    DataGridViewTextBoxCell two = rowOne.Cells[1] as DataGridViewTextBoxCell;
                    EmailSendBccAccountBLL.Current.Delete(two.Value.ToString());
                }
            }
            SearchBccAccount();
        }



        /// <summary>
        /// 獲取需要導出的數據
        /// </summary>
        /// <param name="emailID"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public void GetExportEmailBccAccount(int state)
        {

            TreeView tree = tvSendMail;
            if (tree == null || tree.SelectedNode == null || tree.SelectedNode.Tag == null)
            {
                LogHelper.Info("請選擇需要導出的郵件");
            }
            EmailInfo email = tree.SelectedNode.Tag as EmailInfo;


            List<EmailBccAccount> emailBccAccountList = null;
            string tableSql = @"  EmailSendBccAccount as esba  left join EmailBccAccount as eba on eba.EmailBccAccountID = esba.EmailBccAccountID ";
            string strWhere = string.Format(" esba.EmailID = '{0}' and esba.EmailSendBccAccountState={1} ", email.EmailID, state);
            string orderby = " EmailBccAccountAddress ";
            string columns = @"eba.* ";
            int sendAccountCount = EmailSendAccountBLL.Current.GetRecordCount(tableSql, strWhere);
            int startIndex = 0;
            int endIndex = sendAccountCount;
            if (endIndex > 0)
            {
                DataSet ds = EmailSendAccountBLL.Current.GetListByPage(tableSql, strWhere, orderby, startIndex, endIndex, columns);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    emailBccAccountList = new List<EmailBccAccount>();
                    var rows = ds.Tables[0].Rows;
                    foreach (DataRow row in rows)
                    {
                        var entity = EmailBccAccountBLL.Current.DataRowToModel(row);
                        if (entity != null)
                        {
                            emailBccAccountList.Add(entity);
                        }
                    }
                }
            }
            ExportBccAccount export = new ExportBccAccount();
            export.Export(emailBccAccountList);
        }
    }
}
