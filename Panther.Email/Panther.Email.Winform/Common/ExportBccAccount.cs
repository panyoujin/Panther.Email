using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using Panther.Email.Core.Log;
using Panther.Email.Entity.Model;

namespace Panther.Email.Winform.Common
{
    public class ExportBccAccount
    {
        public void Export(List<EmailBccAccount> _EmailBccAccountEntity)
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
                    Stream _OpenFileStream = sfd.OpenFile();
                    CreateSheet(_EmailBccAccountEntity, _OpenFileStream);
                    MessageBox.Show("數據導出成功！");
                }
                catch (Exception ex)
                {
                    LogHelper.Error("數據導出", "數據導出", ex.Message, ex);
                    MessageBox.Show("數據導出失敗！");
                }
            }
        }
        void CreateSheet(List<EmailBccAccount> _EmailBccAccountEntity, Stream _OpenFileStream)
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
    }
}
