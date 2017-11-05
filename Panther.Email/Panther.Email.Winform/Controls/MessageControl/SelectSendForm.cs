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
    public partial class SelectSendForm : Form
    {
        public SelectSendForm()
        {
            InitializeComponent();
            this.Load += SelectSendForm_Load;
        }

        void SelectSendForm_Load(object sender, EventArgs e)
        {
            List<EmailAccount> emailList = EmailAccountBLL.Current.GetModelList("");

            for (int i = 0; i < emailList.Count; i++)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                check.Value = false;
                dgvr.Cells.Add(check);

                DataGridViewTextBoxCell EmailAccountAddress = new DataGridViewTextBoxCell();
                EmailAccountAddress.Value = emailList[i].EmailAccountAddress;
                dgvr.Cells.Add(EmailAccountAddress);

                DataGridViewTextBoxCell EmailAccountID = new DataGridViewTextBoxCell();
                EmailAccountID.Value = emailList[i].EmailAccountID;

                var single = NewMessageForm._SendMailList.SingleOrDefault(p => p.EmailAccountID == emailList[i].EmailAccountID);
                if (single != null)
                {
                    check.Value = true;
                }
                dgvr.Cells.Add(EmailAccountID);
                dgvSendEmail.Rows.Add(dgvr);
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            NewMessageForm._SendMailList.Clear();
            foreach (DataGridViewRow rowOne in dgvSendEmail.Rows)
            {
                DataGridViewCheckBoxCell one = rowOne.Cells[0] as DataGridViewCheckBoxCell;
                if (one != null && one.Value != null && (bool)one.Value == true)
                {
                    DataGridViewTextBoxCell two = rowOne.Cells[1] as DataGridViewTextBoxCell;
                    DataGridViewTextBoxCell three = rowOne.Cells[2] as DataGridViewTextBoxCell;

                    NewMessageForm._SendMailList.Add(new EmailAccount { EmailAccountID = three.Value.ToString(),EmailAccountAddress=two.Value.ToString()});
                }
            }
            this.Close();
        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelectAll.Checked == true)
            {
                foreach (DataGridViewRow rowOne in dgvSendEmail.Rows)
                {
                    (rowOne.Cells[0] as DataGridViewCheckBoxCell).Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow rowOne in dgvSendEmail.Rows)
                {
                    (rowOne.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }
    }
}
