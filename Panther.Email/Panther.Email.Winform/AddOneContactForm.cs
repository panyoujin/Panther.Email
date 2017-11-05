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
using Panther.Email.Core.Helper;

namespace Panther.Email.Winform
{
    public partial class AddOneContactForm : Form
    {
        public AddOneContactForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("該郵箱不能為空！");
                return;
            }
            if (!MailHelper.IsEmail(tbEmail.Text))
            {
                MessageBox.Show("请填写正确的邮箱地址！");
                return;
            }
            if (EmailBccAccountBLL.Current.ExistsEmail(tbEmail.Text.Trim()))
            {
                MessageBox.Show("該郵箱已經存在數據庫！");
                return;
            }

            EmailBccAccount bcc = new EmailBccAccount();
            bcc.EmailBccAccountID = Guid.NewGuid().ToString();
            bcc.EmailBccAccountName = tbName.Text.Trim();
            bcc.EmailBccAccountAddress = tbEmail.Text.Trim();
            bcc.EmailBccAccountCreateTime = DateTime.Now;
            bcc.EmailBccAccountLastTime = DateTime.Now;
            if (EmailBccAccountBLL.Current.Add(bcc))
            {
                MessageBox.Show("數據添加成功！");
            }
            else
            {
                MessageBox.Show("數據添加失敗！");
            }
        }
    }
}
