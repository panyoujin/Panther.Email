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
    public partial class SelectReceptForm : Form
    {
        public SelectReceptForm()
        {
            InitializeComponent();
            this.Load += SelectReceptForm_Load;
        }

        void SelectReceptForm_Load(object sender, EventArgs e)
        {
            List<EmailBccAccount> emailList = EmailBccAccountBLL.Current.GetModelList("");

            for (int i = 0; i < emailList.Count; i++)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                check.Value = false;
                dgvr.Cells.Add(check);
                DataGridViewTextBoxCell EmailBccAccountAddress = new DataGridViewTextBoxCell();
                EmailBccAccountAddress.Value = emailList[i].EmailBccAccountAddress;
                dgvr.Cells.Add(EmailBccAccountAddress);

                DataGridViewTextBoxCell EmailBccAccountID = new DataGridViewTextBoxCell();
                EmailBccAccountID.Value = emailList[i].EmailBccAccountID;
                dgvr.Cells.Add(EmailBccAccountID);

                var single = NewMessageForm._ReceptMailList.SingleOrDefault(p => p.EmailBccAccountID == emailList[i].EmailBccAccountID);
                if (single != null)
                {
                    check.Value = true;
                }

                dgvReceptEmail.Rows.Add(dgvr);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            NewMessageForm._ReceptMailList.Clear();
            foreach (DataGridViewRow rowOne in dgvReceptEmail.Rows)
            {
                DataGridViewCheckBoxCell one = rowOne.Cells[0] as DataGridViewCheckBoxCell;
                if (one != null && one.Value != null && (bool)one.Value == true)
                {
                    DataGridViewTextBoxCell two = rowOne.Cells[1] as DataGridViewTextBoxCell;
                    DataGridViewTextBoxCell three = rowOne.Cells[2] as DataGridViewTextBoxCell;

                    NewMessageForm._ReceptMailList.Add(new EmailBccAccount { EmailBccAccountID = three.Value.ToString(), EmailBccAccountAddress = two.Value.ToString() });
                }
            }
            this.Close();
        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelectAll.Checked == true)
            {
                foreach (DataGridViewRow rowOne in dgvReceptEmail.Rows)
                {
                    (rowOne.Cells[0] as DataGridViewCheckBoxCell).Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow rowOne in dgvReceptEmail.Rows)
                {
                    (rowOne.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }
    
    
    }
}
