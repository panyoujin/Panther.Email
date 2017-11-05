using System;
using System.Windows.Forms;
using Panther.Email.Business;
using Panther.Email.Core.Log;
using Panther.Email.Entity.Model;

namespace Panther.Email.Winform.Controls
{
    public partial class EditSendMail : UserControl
    {
        private EmailAccount _EmailAccountMode = null;
        public EditSendMail(string mailAddress, EmailAccount ea)
        {
            InitializeComponent();
            gbEditMail.Text = mailAddress;
            _EmailAccountMode = ea;
            this.Load += EditSendMail_Load;
        }

        void EditSendMail_Load(object sender, EventArgs e)
        {
            LoadMode();
        }

        void LoadMode()
        {
            if (_EmailAccountMode == null) return;
            tbName.Text = _EmailAccountMode.EmailAccountName;
            tbSMTP.Text = _EmailAccountMode.EmailAccountSMTP;
            tbSMTPPort.Text = _EmailAccountMode.EmailAccountSMTPPort.ToString();
            tbEmailAddress.Text = _EmailAccountMode.EmailAccountAddress;
            tbEmailCount.Text = _EmailAccountMode.EmailAccountMaxEmailCount.ToString();
            tbPOP3.Text = _EmailAccountMode.EmailAccountPOP3;
            tbPOP3Port.Text = _EmailAccountMode.EmailAccountPOP3Port.ToString();
            tbPassWord.Text = _EmailAccountMode.EmailAccountPassWord;
            cbIsSSL.Text = _EmailAccountMode.EmailAccountIsSSL == true ? "是" : "否";
            tbSpace.Text = _EmailAccountMode.EmailAccountSpace.ToString();
            cbSendMode.Text = _EmailAccountMode.SendMode == 0 ? "發送" : "密送";
            txtSendCounted.Text = _EmailAccountMode.EmailAccountRemainEmailCount.ToString();
            txtTime.Text = _EmailAccountMode.EmailAccountLastTime.ToString();
        }

        private void btnUpdateMail_Click(object sender, EventArgs e)
        {
            try
            {
                LogHelper.Info(DateTime.Now + "修改发件箱：" + _EmailAccountMode.EmailAccountAddress + " -> " + tbEmailAddress.Text);
                _EmailAccountMode.EmailAccountName = tbName.Text.Trim();
                _EmailAccountMode.EmailAccountSMTP = tbSMTP.Text.Trim();
                _EmailAccountMode.EmailAccountSMTPPort = int.Parse(tbSMTPPort.Text.Trim());
                _EmailAccountMode.EmailAccountAddress = tbEmailAddress.Text.Trim();
                _EmailAccountMode.EmailAccountMaxEmailCount = int.Parse(tbEmailCount.Text.Trim());
                _EmailAccountMode.EmailAccountPOP3 = tbPOP3.Text.Trim();
                _EmailAccountMode.EmailAccountPOP3Port = int.Parse(tbPOP3Port.Text.Trim());
                _EmailAccountMode.EmailAccountPassWord = tbPassWord.Text.Trim();
                _EmailAccountMode.EmailAccountIsSSL = cbIsSSL.Text == "是" ? true : false;
                _EmailAccountMode.EmailAccountSpace = int.Parse(tbSpace.Text.Trim());
                _EmailAccountMode.SendMode = int.Parse(cbSendMode.SelectedIndex.ToString());
                _EmailAccountMode.EmailAccountRemainEmailCount = int.Parse(txtSendCounted.Text.Trim());
                _EmailAccountMode.EmailAccountLastTime = DateTime.Parse(txtTime.Text.Trim());
                if (_EmailAccountMode.EmailAccountMaxEmailCount < _EmailAccountMode.EmailAccountRemainEmailCount)
                {
                    _EmailAccountMode.EmailAccountRemainEmailCount = _EmailAccountMode.EmailAccountMaxEmailCount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("郵箱信息修改失敗！");
                return;
            }

            if (EmailAccountBLL.Current.Update(_EmailAccountMode, true) == true)
            {

                MessageBox.Show("郵箱信息修改成功！");
            }
            else
            {
                MessageBox.Show("郵箱信息修改失敗！");
            }
        }
    }
}
