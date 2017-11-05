using NPOI.HSSF.UserModel;
using Panther.Email.Business;
using Panther.Email.Core.Helper;
using Panther.Email.Core.Log;
using Panther.Email.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Panther.Email.Winform
{
    public partial class AddSendMail : Form
    {
        public AddSendMail()
        {
            InitializeComponent();
            cbIsSSL.SelectedIndex = 1;
            cbSendMode.SelectedIndex = 1;
        }

        private void btnAddSendMail_Click(object sender, EventArgs e)
        {
            if (!Verification()) return;
            try
            {
                if (EmailAccountBLL.Current.IsExists(tbEmailAddress.Text.Trim()))
                {
                    MessageBox.Show("郵件已經存在！");
                    return;
                }
                LogHelper.Info(DateTime.Now + "添加发件箱：" + tbEmailAddress.Text);
                EmailAccount ea = new EmailAccount();
                ea.EmailAccountName = tbName.Text.Trim();
                ea.EmailAccountAddress = tbEmailAddress.Text.Trim();
                ea.EmailAccountPassWord = tbPassWord.Text.Trim();
                ea.EmailAccountSMTP = tbSMTP.Text.Trim();
                ea.EmailAccountSMTPPort = int.Parse(tbSMTPPort.Text.Trim());
                ea.EmailAccountPOP3 = tbPOP3.Text.Trim();
                ea.EmailAccountPOP3Port = int.Parse(tbPOP3Port.Text.Trim());
                ea.EmailAccountIsSSL = cbIsSSL.SelectedItem.ToString().Trim().Equals("是") ? true : false;
                ea.EmailAccountMaxEmailCount = int.Parse(tbEmailCount.Text.Trim());
                ea.EmailAccountSpace = int.Parse(tbSpace.Text.Trim());
                ea.EmailAccountID = Guid.NewGuid().ToString();
                ea.EmailAccountCreateTime = DateTime.Now;
                ea.EmailAccountLastTime = DateTime.Now;
                ea.SendMode = int.Parse(cbSendMode.SelectedIndex.ToString());
                EmailAccountBLL.Current.Add(ea);
                MessageBox.Show("郵箱添加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("郵箱添加失败！");
                LogHelper.Error(ex.Message);
            }

        }

        #region Method
        /// <summary>
        /// 驗證輸入框
        /// </summary>
        private bool Verification()
        {
            if (string.IsNullOrWhiteSpace(tbName.Text.Trim()))
            {
                MessageBox.Show("请输入名称！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbEmailAddress.Text.Trim()) || !MailHelper.IsEmail(tbEmailAddress.Text.Trim()))
            {
                MessageBox.Show("请输入郵箱地址(郵箱地址要正確)！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbPassWord.Text.Trim()))
            {
                MessageBox.Show("请输入密碼！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbSMTP.Text.Trim()))
            {
                MessageBox.Show("请输入SMTP！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbPOP3.Text.Trim()))
            {
                MessageBox.Show("请输入POP3！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbSMTPPort.Text.Trim()))
            {
                MessageBox.Show("请输入SMTP端口！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbPOP3Port.Text.Trim()))
            {
                MessageBox.Show("请输入POP3Port端口！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbIsSSL.SelectedItem.ToString().Trim()))
            {
                MessageBox.Show("请選擇是否SSL！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbEmailCount.Text.Trim()))
            {
                MessageBox.Show("请输最多發送數量！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbSpace.Text.Trim()))
            {
                MessageBox.Show("请選擇發送間隔！");
                return false;
            }
            return true;
        }

        private void LoadMoreData(string filePath)
        {
            List<EmailAccount> emailAccountList = new List<EmailAccount>();

            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            //根据路径通过已存在的excel来创建HSSFWorkbook，即整个excel文档
            HSSFWorkbook workbook = new HSSFWorkbook(stream);
            //获取excel的第一个sheet
            HSSFSheet sheet = (HSSFSheet)workbook.GetSheetAt(0);
            //最后一列的标号  即总的行数
            int rowCount = sheet.LastRowNum;

            for (int i = (sheet.FirstRowNum + 1); i < sheet.LastRowNum + 1; i++)
            {
                HSSFRow row = (HSSFRow)sheet.GetRow(i);
                EmailAccount ea = new EmailAccount();
                ea.EmailAccountID = Guid.NewGuid().ToString();
                if (row.GetCell(0) != null)
                    ea.EmailAccountName = row.GetCell(0).ToString();
                if (row.GetCell(1) != null)
                    ea.EmailAccountAddress = row.GetCell(1).ToString();
                if (row.GetCell(2) != null)
                    ea.EmailAccountPassWord = row.GetCell(2).ToString();
                if (row.GetCell(3) != null)
                    ea.EmailAccountSMTP = row.GetCell(3).ToString();
                if (row.GetCell(4) != null)
                    ea.EmailAccountSMTPPort = int.Parse(row.GetCell(4).ToString());
                if (row.GetCell(5) != null)
                    ea.EmailAccountPOP3 = row.GetCell(5).ToString();
                if (row.GetCell(6) != null)
                    ea.EmailAccountPOP3Port = int.Parse(row.GetCell(6).ToString());
                if (row.GetCell(7) != null)
                    ea.EmailAccountIsSSL = row.GetCell(7).ToString() == "是" ? true : false;
                if (row.GetCell(8) != null)
                    ea.EmailAccountMaxEmailCount = int.Parse(row.GetCell(8).ToString());
                if (row.GetCell(9) != null)
                    ea.EmailAccountSpace = int.Parse(row.GetCell(9).ToString());
                //if (row.GetCell(10) != null)
                //{
                //    if (row.GetCell(10).ToString() == "發送")
                //    {
                //        ea.SendMode = 0;
                //    }
                //    else
                //    {
                //        ea.SendMode = 1;
                //    }
                //}
                ea.SendMode = 1;//密送
                ea.EmailAccountCreateTime = DateTime.Now;
                ea.EmailAccountLastTime = DateTime.Now;
                emailAccountList.Add(ea);
            }
            dgvSendEmail.DataSource = emailAccountList;
        }
        #endregion

        private void btnImportSends_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadMoreData(op.FileName);
                }
                catch (Exception ex)
                {
                    LogHelper.Error(ex.Message);
                    MessageBox.Show("數據導入失敗！");
                }
            }
        }

        private void btnImportSendMail_Click(object sender, EventArgs e)
        {
            List<EmailAccount> entity = dgvSendEmail.DataSource as List<EmailAccount>;
            List<EmailAccount> failEntity = new List<EmailAccount>();
            if (entity == null)
            {
                MessageBox.Show("請先導入");
                return;
            }
            foreach (var one in entity)
            {
                if (string.IsNullOrWhiteSpace(one.EmailAccountAddress) || EmailAccountBLL.Current.IsExists(one.EmailAccountAddress))
                {
                    failEntity.Add(one);
                    continue;
                }
                EmailAccountBLL.Current.Add(one);
            }
            if (failEntity.Count > 0)
            {
                MessageBox.Show("下面是導入失敗的列表！");
                dgvSendEmail.DataSource = failEntity;
            }
            else
            {
                MessageBox.Show("全部導入成功！");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "excel\\SendMail.xls";

            if (File.Exists(path))
            {
                FileInfo fi = new FileInfo(path);
                //MessageBox.Show(fi.Name);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
                sfd.FileName = fi.Name.Split('.')[0];
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportExcel(fi, sfd.FileName);
                }
            }
            else
            {
                MessageBox.Show("沒有模板文件！");
            }
        }

        void ExportExcel(FileInfo fi, string savePath)
        {
            try
            {
                fi.CopyTo(savePath, true);
                MessageBox.Show("模板導出成功！");
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
                MessageBox.Show("模板導出失敗！");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂时还未实现");
        }

    }
}
