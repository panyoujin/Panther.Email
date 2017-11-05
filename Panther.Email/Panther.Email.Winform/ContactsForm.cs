using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
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
using System.Threading;
using System.Transactions;
using System.Windows.Forms;

namespace Panther.Email.Winform
{
    public partial class ContactsForm : Form
    {
        private List<EmailBccAccount> _EmailBccAccountEntity = null;
        private Stream _OpenFileStream = null;
        private int _countStart = 0;
        private int _countEnd = 100;

        private List<string> _FileNames = new List<string>();     //文件路径
        private List<string> _DeleteFileNames = new List<string>();     //删除文件路径

        public ContactsForm()
        {
            InitializeComponent();
            this.txtCountStart.Text = _countStart.ToString();
            this.txtCountEnd.Text = _countEnd.ToString();
            ContactsForm.CheckForIllegalCrossThreadCalls = false;

            EventHelper.RegisteredEvent("ContactInitData", InitData);
            this.Load += ContactsForm_Load;
        }

        void ContactsForm_Load(object sender, EventArgs e)
        {
            EventHelper.ExecuteEvent("ContactInitData");
        }

        public void InitData()
        {
            this.BeginInvoke(new MethodInvoker(delegate()
            {
                LoadData(" 1=1 ");
            }));
        }

        void LoadData(string emailStr)
        {
            this.Refresh();
            dgvContact.Rows.Clear();
            int count = EmailBccAccountBLL.Current.GetRecordCount(emailStr);

            if (Convert.ToInt32(this.txtCountStart.Text) < 0)
            {
                this.txtCountStart.Text = "0";
            }
            _countStart = Convert.ToInt32(this.txtCountStart.Text);

            if (Convert.ToInt32(this.txtCountEnd.Text) < 10)
            {
                this.txtCountEnd.Text = "10";
            }
            _countEnd = Convert.ToInt32(this.txtCountEnd.Text);
            if (count < _countEnd)
            {
                _countEnd = count;
            }
            if (_countEnd <= 0)
            {
                _countEnd = 10;
            }
            if (_countStart >= _countEnd)
            {
                _countStart = _countEnd - 1;
            }
            if (_countStart < 0)
            {
                _countStart = 0;
            }

            _EmailBccAccountEntity = EmailBccAccountBLL.Current.GetModelList(emailStr, _countStart, _countEnd);


            this.txtCountStart.Text = _countStart.ToString();
            this.txtCountEnd.Text = _countEnd.ToString();
            for (int i = 0; i < _EmailBccAccountEntity.Count; i++)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                check.Value = false;
                dgvr.Cells.Add(check);
                DataGridViewTextBoxCell EmailBccAccountID = new DataGridViewTextBoxCell();
                EmailBccAccountID.Value = _EmailBccAccountEntity[i].EmailBccAccountID;
                dgvr.Cells.Add(EmailBccAccountID);
                DataGridViewTextBoxCell EmailBccAccountName = new DataGridViewTextBoxCell();
                EmailBccAccountName.Value = _EmailBccAccountEntity[i].EmailBccAccountName;
                dgvr.Cells.Add(EmailBccAccountName);
                DataGridViewTextBoxCell EmailBccAccountAddress = new DataGridViewTextBoxCell();
                EmailBccAccountAddress.Value = _EmailBccAccountEntity[i].EmailBccAccountAddress;
                dgvr.Cells.Add(EmailBccAccountAddress);
                DataGridViewTextBoxCell EmailBccAccountCreateTime = new DataGridViewTextBoxCell();
                EmailBccAccountCreateTime.Value = _EmailBccAccountEntity[i].EmailBccAccountCreateTime;
                dgvr.Cells.Add(EmailBccAccountCreateTime);
                DataGridViewTextBoxCell state = new DataGridViewTextBoxCell();
                state.Value = _EmailBccAccountEntity[i].EmailBccAccountIsDel ? "失效" : "正常";
                dgvr.Cells.Add(state);

                DataGridViewTextBoxCell index = new DataGridViewTextBoxCell();
                index.Value = (i + 1);
                dgvr.Cells.Add(index);
                dgvContact.Rows.Add(dgvr);
            }
            lbCount.Text = string.Format("總數：{0}", count);
            dgvContact.Refresh();
        }

        private void btnShowOneContactForm_Click(object sender, EventArgs e)
        {
            AddOneContactForm one = new AddOneContactForm();
            btnShowOneContactForm.Enabled = false;
            one.FormClosed += one_FormClosed;
            one.Show();
        }

        void one_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnShowOneContactForm.Enabled = true;
            EventHelper.ExecuteEvent("ContactInitData");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StringBuilder deleteStr = new StringBuilder("");
            try
            {
                int i = 1;
                int count = dgvContact.Rows.Count;
                foreach (DataGridViewRow rowOne in dgvContact.Rows)
                {
                    DataGridViewCheckBoxCell one = rowOne.Cells[0] as DataGridViewCheckBoxCell;
                    if (one != null && one.Value != null && (bool)one.Value == true)
                    {
                        DataGridViewTextBoxCell two = rowOne.Cells[1] as DataGridViewTextBoxCell;
                        deleteStr.Append(string.Format("'{0}',", two.Value));
                    }
                    if ((count == i) || ((i / 1000) > 0 && (i % 1000) == 0))
                    {
                        using (TransactionScope scope = new TransactionScope())
                        {
                            string delStr = deleteStr.ToString();
                            if (!string.IsNullOrEmpty(delStr))
                            {
                                if (delStr.LastIndexOf(',') == delStr.Length - 1)
                                {
                                    delStr = delStr.Substring(0, delStr.Length - 1);
                                }
                                if (EmailBccAccountBLL.Current.DeleteList(delStr))
                                {
                                    List<EmailSendBccAccount> EmailSendBccAccountList = EmailSendBccAccountBLL.Current.GetModelList(string.Format(" EmailBccAccountID in ({0})", delStr));
                                    foreach (var EmailSendBccAccountOne in EmailSendBccAccountList)
                                    {
                                        EmailSendBccAccountBLL.Current.Delete(EmailSendBccAccountOne.EmailSendBccAccountID);
                                    }
                                    //删除EmailSendFailur
                                    List<EmailSendFailure> EmailSendFailureList = EmailSendFailureBLL.Current.GetModelList(string.Format(" EmailBccAccountID in ({0})", delStr));
                                    foreach (EmailSendFailure emailSendFailureOne in EmailSendFailureList)
                                    {
                                        EmailSendFailureBLL.Current.Delete(emailSendFailureOne.EmailSendFailureID);
                                    }

                                    scope.Complete();
                                }
                            }
                        }
                        deleteStr.Clear();
                    }
                    i++;
                }
                MessageBox.Show("刪除完成！");
                EventHelper.ExecuteEvent("ContactInitData");
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
                MessageBox.Show("刪除失敗！");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            StringBuilder deleteStr = new StringBuilder("");
            try
            {
                foreach (DataGridViewRow rowOne in dgvContact.Rows)
                {
                    DataGridViewCheckBoxCell one = rowOne.Cells[0] as DataGridViewCheckBoxCell;

                    DataGridViewTextBoxCell two = rowOne.Cells[1] as DataGridViewTextBoxCell;
                    deleteStr.Append(string.Format("'{0}',", two.Value));
                }
                using (TransactionScope scope = new TransactionScope())
                {
                    if (EmailBccAccountBLL.Current.DeleteList(deleteStr.ToString()))
                    {
                        List<EmailSendBccAccount> EmailSendBccAccountList = EmailSendBccAccountBLL.Current.GetModelList(string.Format(" EmailBccAccountID in ({0})", deleteStr));
                        foreach (var EmailSendBccAccountOne in EmailSendBccAccountList)
                        {
                            EmailSendBccAccountBLL.Current.Delete(EmailSendBccAccountOne.EmailSendBccAccountID);
                        }
                        //删除EmailSendFailur
                        List<EmailSendFailure> EmailSendFailureList = EmailSendFailureBLL.Current.GetModelList(string.Format(" EmailBccAccountID in ({0})", deleteStr));
                        foreach (EmailSendFailure emailSendFailureOne in EmailSendFailureList)
                        {
                            EmailSendFailureBLL.Current.Delete(emailSendFailureOne.EmailSendFailureID);
                        }
                        MessageBox.Show("刪除成功！");
                        scope.Complete();
                    }
                }

                EventHelper.ExecuteEvent("ContactInitData");
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
                MessageBox.Show("刪除失敗！");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchContent = tbEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchContent))
            {
                EventHelper.ExecuteEvent("ContactInitData");
                return;
            }
            LoadData(string.Format(" EmailBccAccountName like '%{0}%'", searchContent));
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
                _FileNames.Clear();
                op.Multiselect = true;
                if (op.ShowDialog() == DialogResult.OK)
                {
                    _FileNames.AddRange(op.FileNames);
                    Thread thread = new Thread(s =>
                    {
                        int count = _FileNames.Count;
                        for (int i = 0; i < count; i++)
                        {
                            ImportData(_FileNames[i]);
                        }
                    });
                    thread.Start();

                    MessageBox.Show("正在後臺進行批量導入！（读取excel文档时间60000条数据需要10分钟左右的时间，插入数据库60000条数据接近70秒。）");
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
                MessageBox.Show("批量導入失敗！");
            }
        }

        private void ImportData(string filePath)
        {
            try
            {
                //Thread thread = new Thread(s =>
                //{
                //LogHelper.Info("處理excel開始時間" + DateTime.Now);
                List<EmailBccAccount> entity = new List<EmailBccAccount>();

                FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                //根据路径通过已存在的excel来创建HSSFWorkbook，即整个excel文档
                HSSFWorkbook workbook = new HSSFWorkbook(stream);
                //获取excel的第一个sheet
                HSSFSheet sheet = (HSSFSheet)workbook.GetSheetAt(0);

                //最后一列的标号  即总的行数
                int rowCount = sheet.LastRowNum;
                int rowFirst = sheet.FirstRowNum;
                int count = EmailBccAccountBLL.Current.GetRecordCount("");
                List<EmailBccAccount> emailBccAccountEntity = EmailBccAccountBLL.Current.GetModelList("", 0, count);

                for (int i = (rowFirst + 1); i < rowCount + 1; i++)
                {
                    HSSFRow row = (HSSFRow)sheet.GetRow(i);
                    if (row.GetCell(1) != null && !string.IsNullOrEmpty(row.GetCell(1).ToString()))//&& MailHelper.IsEmail(row.GetCell(1).ToString().Trim()))
                    {
                        string bccAccountAddress = row.GetCell(1).ToString().Trim();
                        //if (emailBccAccountEntity.Where(b => b.EmailBccAccountAddress == bccAccountAddress).Count() <= 0 && entity.Where(e => e.EmailBccAccountAddress == bccAccountAddress).Count() <= 0)
                        //{
                        string bccAccountName = "";
                        if (row.GetCell(0) != null)
                        {
                            bccAccountName = row.GetCell(0).ToString().Trim();
                        }
                        entity.Add(new EmailBccAccount() { EmailBccAccountName = bccAccountName, EmailBccAccountAddress = bccAccountAddress });
                        //}
                    }
                }
                stream.Close();
                //LogHelper.Info("處理excel數量" + rowCount + "完成時間" + DateTime.Now);
                //LogHelper.Info("導入開始時間" + DateTime.Now + ",導入數量：" + entity.Count);
                GetAddBccSQL(entity);
                DeleteRepeatData();
                //LogHelper.Info("導入完成時間" + DateTime.Now);
                EventHelper.ExecuteEvent("ContactInitData");
            }
            catch (Exception ex)
            {
                LogHelper.Error(string.Format("導入失敗，文件：{0},錯誤信息:{1}", filePath, ex.Message));
            }
            //});
            //thread.Start();
            //MessageBox.Show("正在後臺進行批量導入！（读取excel文档时间60000条数据需要10分钟左右的时间，插入数据库60000条数据接近70秒。）");
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "excel\\ReceiptMail.xls";

            if (File.Exists(path))
            {
                FileInfo fi = new FileInfo(path);
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

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelectAll.Checked == true)
            {
                foreach (DataGridViewRow rowOne in dgvContact.Rows)
                {
                    (rowOne.Cells[0] as DataGridViewCheckBoxCell).Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow rowOne in dgvContact.Rows)
                {
                    (rowOne.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbOld.Text.Trim()))
            {
                MessageBox.Show("請填寫要替換的名稱！");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbNew.Text.Trim()))
            {
                MessageBox.Show("請填寫替換的名稱！");
                return;
            }
            try
            {
                EmailBccAccountBLL.Current.UpdateName(tbOld.Text.Trim(), tbNew.Text.Trim());
                MessageBox.Show("替換成功！");

                EventHelper.ExecuteEvent("ContactInitData");
            }
            catch (Exception ex)
            {
                MessageBox.Show("替換失敗！");
            }
        }

        private void btnDataExport_Click(object sender, EventArgs e)
        {
            if (_EmailBccAccountEntity == null)
            {
                MessageBox.Show("請選擇要導出的數據!");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _OpenFileStream = sfd.OpenFile();
                    CreateSheet();
                    MessageBox.Show("數據導出成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("數據導出失敗！");
                }
            }
        }

        void CreateSheet()
        {
            IWorkbook workbook = new HSSFWorkbook();//创建Workbook对象
            ISheet sheet = workbook.CreateSheet("Sheet1");//创建工作表
            IRow row = sheet.CreateRow(0);//在工作表中添加一行
            ICell cellName = row.CreateCell(0);//在行中添加一列
            cellName.SetCellValue("名稱");//设置列的内容
            ICell cellEmail = row.CreateCell(1);//在行中添加一列
            cellEmail.SetCellValue("郵箱地址");//设置列的内容
            int i = 1;
            foreach (var one in _EmailBccAccountEntity)
            {
                IRow newRow = sheet.CreateRow(i);//在工作表中添加一行
                ICell newCellName = newRow.CreateCell(0);//在行中添加一列
                newCellName.SetCellValue(one.EmailBccAccountName);//设置列的内容
                ICell newCellEmail = newRow.CreateCell(1);//在行中添加一列
                newCellEmail.SetCellValue(one.EmailBccAccountAddress);//设置列的内容
                i++;
            }
            if (_OpenFileStream == null)
            {
                return;
            }
            workbook.Write(_OpenFileStream);
            _OpenFileStream.Close();
            _OpenFileStream.Dispose();
        }

        private void btnDeleteExport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
                op.Multiselect = true;
                _DeleteFileNames.Clear();
                if (op.ShowDialog() == DialogResult.OK)
                {
                    _DeleteFileNames.AddRange(op.FileNames);

                    Thread thread = new Thread(s =>
                    {
                        int count = _DeleteFileNames.Count;
                        for (int j = 0; j < count; j++)
                        {
                            DeleteData(_DeleteFileNames[j]);
                        }
                    });
                    thread.Start();
                    MessageBox.Show("正在後臺進行批量刪除！");
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
                MessageBox.Show("批量刪除失效郵箱失敗！");
            }
        }

        private void DeleteData(string filePath)
        {
            try
            {
                //LogHelper.Info("删除excel開始時間（1）" + DateTime.Now);
                List<EmailBccAccount> entity = new List<EmailBccAccount>();

                FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                //根据路径通过已存在的excel来创建HSSFWorkbook，即整个excel文档
                HSSFWorkbook workbook = new HSSFWorkbook(stream);
                //获取excel的第一个sheet
                HSSFSheet sheet = (HSSFSheet)workbook.GetSheetAt(0);
                //最后一列的标号  即总的行数
                int rowCount = sheet.LastRowNum;
                int rowFirst = sheet.FirstRowNum;

                for (int i = (rowFirst + 1); i < (rowCount + 1); i++)
                {
                    HSSFRow row = (HSSFRow)sheet.GetRow(i);
                    EmailBccAccount eba = new EmailBccAccount();
                    eba.EmailBccAccountID = Guid.NewGuid().ToString();
                    if (row.GetCell(0) != null)
                        eba.EmailBccAccountName = row.GetCell(0).ToString();
                    if (row.GetCell(1) != null)
                        eba.EmailBccAccountAddress = row.GetCell(1).ToString();
                    eba.EmailBccAccountCreateTime = DateTime.Now;
                    eba.EmailBccAccountLastTime = DateTime.Now;
                    entity.Add(eba);
                }
                //LogHelper.Info("删除excel结束時間（1）" + DateTime.Now);
                //Thread thread = new Thread(s =>
                //{
                int k = 0;
                int count = entity.Count;
                StringBuilder sb = new StringBuilder("");
                //LogHelper.Info("（2）删除開始時間" + DateTime.Now + ",删除數量：" + count);
                foreach (var one in entity)
                {
                    k++;
                    sb.Append("'");
                    sb.Append(one.EmailBccAccountAddress);
                    sb.Append("'");
                    if ((k % 2000 == 0) || (k == count))
                    {
                        try
                        {
                            EmailBccAccountBLL.Current.DeleteByMailAddressMore(sb.ToString());
                            sb.Clear();
                        }
                        catch (Exception ex)
                        {
                            LogHelper.Error(ex.Message);
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(sb.ToString()))
                    {
                        sb.Append(",");
                    }
                }
                //LogHelper.Info("（2）删除结束時間" + DateTime.Now);

                EventHelper.ExecuteEvent("ContactInitData");
            }
            catch (Exception ex)
            {
                LogHelper.Error(string.Format("删除文件失败，文件：{0},錯誤信息:{1}", filePath, ex.Message));
            }
            //});
            //thread.Start();
            //MessageBox.Show("正在後臺進行批量刪除！");
        }



        void GetAddBccSQL(List<EmailBccAccount> entity)
        {
            StringBuilder sbSql = new StringBuilder();
            int count = 0;
            foreach (var bcc in entity)
            {
                try
                {
                    count++;

                    sbSql.AppendFormat("insert into EmailBccAccount(EmailBccAccountID,EmailBccAccountAddress,EmailBccAccountName,EmailBccAccountCreateTime,EmailBccAccountLastTime,EmailBccAccountIsDel) values ('{0}','{1}','{2}','{3}','{4}',{5});", Guid.NewGuid().ToString(), bcc.EmailBccAccountAddress, bcc.EmailBccAccountName, DateTime.Now, DateTime.Now, 0);
                    if (count >= 1000)
                    {
                        EmailSendBccAccountBLL.Current.ExecSql(sbSql.ToString());
                        sbSql = new StringBuilder();
                        count = 0;
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error("導入收件箱", "生成批量腳本出錯", ex.Message, null);
                }
            }
            if (sbSql.Length > 0 && !string.IsNullOrEmpty(sbSql.ToString()))
            {
                EmailSendBccAccountBLL.Current.ExecSql(sbSql.ToString());
            }
        }

        void DeleteRepeatData()
        {
            EmailSendBccAccountBLL.Current.ExecSql(@"DELETE FROM EmailBccAccount WHERE EmailBccAccountID IN ( SELECT EBA.EmailBccAccountID FROM (SELECT EmailBccAccountAddress,MIN(EmailBccAccountID) AS MinEmailBccAccountID  FROM EmailBccAccount  GROUP BY EmailBccAccountAddress HAVING COUNT(EmailBccAccountAddress)>1) AS TEMP LEFT JOIN EmailBccAccount AS EBA ON EBA.EmailBccAccountAddress = TEMP.EmailBccAccountAddress AND EBA.EmailBccAccountID<>TEMP.MinEmailBccAccountID)
");
        }
    }
}
