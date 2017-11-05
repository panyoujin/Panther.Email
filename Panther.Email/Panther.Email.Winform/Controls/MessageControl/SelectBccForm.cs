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

namespace Panther.Email.Winform.Controls.MessageControl
{
    public partial class SelectBccForm : Form
    {
        public SelectBccForm()
        {
            InitializeComponent();
            this.Load += SelectBccForm_Load;
        }

        void SelectBccForm_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate()
            {
                this.Refresh();
                List<EmailBccAccount> emailList = EmailBccAccountBLL.Current.GetModelList("");
                LoadBccData(emailList);
            }));

        }

        void LoadBccData(List<EmailBccAccount> emailList)
        {
            dgvBccEmail.Rows.Clear();
            for (int i = 0; i < emailList.Count; i++)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                check.Value = NewMessageForm._BccMailList.SingleOrDefault(p => p.EmailBccAccountID == emailList[i].EmailBccAccountID)==null?false:true;
                check.Tag = emailList[i];
                dgvr.Cells.Add(check);

                DataGridViewTextBoxCell EmailBccAccountName = new DataGridViewTextBoxCell();
                EmailBccAccountName.Value = emailList[i].EmailBccAccountName;
                dgvr.Cells.Add(EmailBccAccountName);

                DataGridViewTextBoxCell EmailBccAccountAddress = new DataGridViewTextBoxCell();
                EmailBccAccountAddress.Value = emailList[i].EmailBccAccountAddress;
                dgvr.Cells.Add(EmailBccAccountAddress);

                DataGridViewTextBoxCell EmailBccAccountID = new DataGridViewTextBoxCell();
                EmailBccAccountID.Value = emailList[i].EmailBccAccountID;
                dgvr.Cells.Add(EmailBccAccountID);

                DataGridViewTextBoxCell index = new DataGridViewTextBoxCell();
                index.Value = (i+1);
                dgvr.Cells.Add(index);
                //var single = NewMessageForm._BccMailList.SingleOrDefault(p => p.EmailBccAccountID == emailList[i].EmailBccAccountID);
                //if (single != null)
                //{
                //    check.Value = true;
                //}

                dgvBccEmail.Rows.Add(dgvr);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            NewMessageForm._BccMailList.Clear();
            foreach (DataGridViewRow rowOne in dgvBccEmail.Rows)
            {
                DataGridViewCheckBoxCell one = rowOne.Cells[0] as DataGridViewCheckBoxCell;
                if ((bool)one.Value == true)
                {
                    //DataGridViewTextBoxCell two = rowOne.Cells[1] as DataGridViewTextBoxCell;
                    //DataGridViewTextBoxCell three = rowOne.Cells[2] as DataGridViewTextBoxCell;
                    //DataGridViewTextBoxCell four = rowOne.Cells[3] as DataGridViewTextBoxCell;
                    NewMessageForm._BccMailList.Add(one.Tag as EmailBccAccount);
                    //NewMessageForm._BccMailList.Add(new EmailBccAccount { EmailBccAccountID = four.Value.ToString(), EmailBccAccountAddress = three.Value.ToString(), EmailBccAccountName = two.Value.ToString() });
                }
            }
            this.Close();
        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelectAll.Checked == true)
            {
                foreach (DataGridViewRow rowOne in dgvBccEmail.Rows)
                {
                    (rowOne.Cells[0] as DataGridViewCheckBoxCell).Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow rowOne in dgvBccEmail.Rows)
                {
                    (rowOne.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<EmailBccAccount> emailList = null;
            if (string.IsNullOrWhiteSpace(tbSearch.Text.Trim()))
            {
                emailList = EmailBccAccountBLL.Current.GetModelList("");
            }
            else
            {
                emailList = EmailBccAccountBLL.Current.GetModelList(string.Format("  1=1 and EmailBccAccountName like '%{0}%'", tbSearch.Text.Trim()));
            }

            LoadBccData(emailList);
        }
    }
}
