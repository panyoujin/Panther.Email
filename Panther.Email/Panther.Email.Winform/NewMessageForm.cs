using LumiSoft.Net.AUTH;
using LumiSoft.Net.Mail;
using LumiSoft.Net.Mime;
using LumiSoft.Net.MIME;
using Panther.Email.Business;
using Panther.Email.Core.Enum;
using Panther.Email.Core.Helper;
using Panther.Email.Core.Log;
using Panther.Email.Entity.Model;
using Panther.Email.Winform.Controls.MessageControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Transactions;
using System.Windows.Forms;

namespace Panther.Email.Winform
{
    public partial class NewMessageForm : Form
    {
        /// <summary>
        /// 發件人
        /// </summary>
        public static List<EmailAccount> _SendMailList = new List<EmailAccount>();
        /// <summary>
        /// 收件人
        /// </summary>
        public static List<EmailBccAccount> _ReceptMailList = new List<EmailBccAccount>();
        /// <summary>
        /// 密送人
        /// </summary>
        public static List<EmailBccAccount> _BccMailList = new List<EmailBccAccount>();

        public NewMessageForm()
        {
            InitializeComponent();
            this.Load += NewMessageForm_Load;
        }

        public NewMessageForm(EmailInfo emailInfo)
        {
            InitializeComponent();
            htmlEditUserControl1.HtmlEditControl.SetDocumentText(emailInfo.EmailFilePath);
            tbTheme.Text = emailInfo.EmailTitle;
            tbTheme.ReadOnly = true;

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        void NewMessageForm_Load(object sender, EventArgs e)
        {
            _SendMailList.Clear();
            _ReceptMailList.Clear();
            _BccMailList.Clear();
            htmlEditUserControl1.Focus();
        }

        /// <summary>
        /// 导入按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportEml_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "邮件文件(*.eml)|*.eml|所有文件(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                AnalyzeEmlFile(op.FileName);
            }
        }

        /// <summary>
        /// 解析eml內容到編輯器上
        /// </summary>
        private void AnalyzeEmlFile(string emlFile)
        {
            tbPath.Text = emlFile;

            var msg = LumiSoft.Net.Mail.Mail_Message.ParseFromFile(emlFile);
            MIME_Entity[] mimeEntity = null;
            //if (msg.Attachments == null || msg.Attachments.Count() == 0)
            //{
            mimeEntity = msg.AllEntities;
            //}
            //else
            //{
            //    mimeEntity = msg.Attachments;
            //}

            Dictionary<string, string> pic = MailHelper.GetPathByImage(mimeEntity);

            string BodyHtmlText = msg.BodyHtmlText;
            foreach (var one in pic)
            {
                BodyHtmlText = BodyHtmlText.Replace(one.Key, one.Value);
            }
            tbTheme.Text = msg.Subject;
            htmlEditUserControl1.HtmlEditControl.SetDocumentText(BodyHtmlText);
        }

        /// <summary>
        /// 发送按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            DateTime? startDatetime = dtpdateTime.Value;
            #region 判斷有沒填寫發件人抄送人
            if (_SendMailList.Count == 0)
            {
                MessageBox.Show("你還沒填寫發件人！");
                return;
            }
            if (_BccMailList.Count == 0)
            {
                MessageBox.Show("你還沒填寫抄送人！");
                return;
            }
            #endregion

            string htmlStr = htmlEditUserControl1.HtmlEditControl.Text;
            if (string.IsNullOrEmpty(htmlStr))
            {
                htmlStr = ((System.Windows.Forms.WebBrowser)(htmlEditUserControl1.HtmlEditControl)).DocumentText;
            }
            Thread thread = new Thread(s =>
            {
                #region 插入数据库
                //using (TransactionScope scope = new TransactionScope())
                //{
                try
                {
                    EmailInfo info = null;

                    if (string.IsNullOrWhiteSpace(tbTheme.Text))
                    {
                        MessageBox.Show("主題不能為空！");
                        return;
                    }
                    LogHelper.Info(DateTime.Now + "添加郵件：" + tbTheme.Text);
                    info = SaveEmlToLocal(tbTheme.Text, htmlStr);
                    if (info != null)
                    {
                        info.EmailStartSendTime = startDatetime;//如果是定时发送，该值才有
                        info.EmailState = 2;
                        if (EmailInfoBLL.Current.Add(info))
                        {
                            foreach (var send in _SendMailList)
                            {
                                EmailSendAccount one = new EmailSendAccount();
                                one.EmailSendAccountID = Guid.NewGuid().ToString();
                                one.EmailID = info.EmailID;
                                one.EmailAccountID = send.EmailAccountID;
                                one.EmailSendAccountCreateTime = DateTime.Now;
                                EmailSendAccountBLL.Current.Add(one);
                            }
                            LogHelper.Info("插入發送信息時間：" + DateTime.Now + ",插入密送人數量：" + _BccMailList.Count);
                            GetAddBccSQL(info);
                            LogHelper.Info("完成插入發送信息時間：" + DateTime.Now);
                            //LogHelper.Info("插入發送信息時間：" + DateTime.Now);
                            //foreach (var bcc in _BccMailList)
                            //{
                            //    EmailSendBccAccount one = new EmailSendBccAccount();
                            //    one.EmailSendBccAccountID = Guid.NewGuid().ToString();
                            //    one.EmailID = info.EmailID;
                            //    one.EmailBccAccountID = bcc.EmailBccAccountID;
                            //    one.EmailSendBccAccountState = (short)SendBccAccountState.Unsent;
                            //    one.EmailSendBccAccountLastTime = DateTime.Now;
                            //    one.EmailSendBccAccountCreateTime = DateTime.Now;
                            //    //one.EmailSendBccAccountSendTIme = DateTime.Now;//這個要去掉
                            //    one.EmailAccountID = "";
                            //    EmailSendBccAccountBLL.Current.Add(one);
                            //}
                            //LogHelper.Info("完成插入發送信息時間：" + DateTime.Now);
                            info.EmailState = 0;
                            EmailInfoBLL.Current.UpdateEmailState(info.EmailID, info.EmailState);
                        }
                    }
                    //scope.Complete();
                    LogHelper.Info(string.Format("郵件:{0},新建成功", info.EmailTitle));
                }
                catch (Exception ex)
                {
                    LogHelper.Error("新建郵件", string.Format("郵件:{0},新建失败", tbTheme.Text), ex.Message, ex);
                    //MessageBox.Show("新建失败");
                }
                //}
                #endregion
            });
            thread.Start();
            MessageBox.Show("正在後臺進行郵件新建！");
            this.Close();
        }

        /// <summary>
        /// 保存郵箱在本地
        /// </summary>
        /// <param name="path"></param>
        /// <param name="subject"></param>
        /// <param name="htmlBody"></param>
        /// <returns></returns>
        private EmailInfo SaveEmlToLocal(string subject, string htmlBody)
        {
            EmailInfo info = new EmailInfo();

            try
            {
                string fileName = Guid.NewGuid().ToString();
                info.EmailID = fileName;
                //path = string.Format("{0}\\{1}.eml", path, fileName);

                //List<string> attachments = new List<string>();
                //Dictionary<string, string> embedList = new Dictionary<string, string>();

                //List<string> strList = MailHelper.GetHtmlImageUrlList(htmlBody);
                //foreach (var str in strList)
                //{
                //    string key = Guid.NewGuid().ToString();
                //    embedList.Add(key, str);
                //    string newUrl = "cid:" + key;
                //    htmlBody = htmlBody.Replace(str, newUrl);
                //}

                //Mime m = MailHelper.Create_HtmlBody_Attachment_Image(null, null, "", "", subject, htmlBody, attachments, embedList);
                //m.ToFile(path);

                info.EmailTitle = subject;
                info.EmailFilePath = htmlBody;
                info.EmailCreateTime = DateTime.Now;
                info.EmailLastTime = DateTime.Now;
                info.EmailStartSendTime = DateTime.Now;
                info.EmailState = (short)EmailState.Start;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return info;
        }

        /// <summary>
        /// 保存郵箱在本地
        /// </summary>
        /// <param name="savePath">保存路劲</param>
        /// <param name="urlPath">打开路径</param>
        /// <returns></returns>
        //private EmailInfo SaveEmlToLocal(string savePath, string urlPath)
        //{
        //    EmailInfo info = new EmailInfo();
        //    string fileName = Guid.NewGuid().ToString();
        //    info.EmailID = fileName;
        //    savePath = string.Format("{0}\\{1}.eml", savePath, fileName);

        //    var msg = LumiSoft.Net.Mail.Mail_Message.ParseFromFile(urlPath);
        //    msg.ToFile(savePath, null, Encoding.UTF8);

        //    info.EmailTitle = msg.Subject;
        //    info.EmailFilePath = savePath;
        //    info.EmailCreateTime = DateTime.Now;
        //    info.EmailLastTime = DateTime.Now;
        //    info.EmailStartSendTime = DateTime.Now;
        //    info.EmailState = (short)EmailState.Start;
        //    return info;
        //}
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型   
            sfd.Filter = "郵件文件(*.eml)|*.eml|All files(*.*)|*.*";
            //保存对话框是否记忆上次打开的目录   
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                //MessageBox.Show(sfd.FileName.ToString()); 
                string htmlText = htmlEditUserControl1.Text;

            }
        }


        #region 選擇發件人
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            SelectSendForm ssf = new SelectSendForm();
            ssf.FormClosed += ssf_FormClosed;
            btnSendMail.Enabled = false;
            ssf.Show();
        }

        void ssf_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnSendMail.Enabled = true;
            tbSend.Text = "";
            foreach (var one in _SendMailList)
            {
                tbSend.Text += one.EmailAccountAddress + ";";
            }
        }
        #endregion

        #region 選擇收件人
        private void btnReceptMeail_Click(object sender, EventArgs e)
        {
            SelectReceptForm srf = new SelectReceptForm();
            btnReceptMeail.Enabled = false;
            srf.FormClosed += srf_FormClosed;
            srf.Show();
        }

        void srf_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnReceptMeail.Enabled = true;
            tbReceipt.Text = "";
            foreach (var one in _ReceptMailList)
            {
                tbReceipt.Text += one.EmailBccAccountAddress + ";";
            }
        }
        #endregion

        #region 選擇密炒人
        private void btnBccMeail_Click(object sender, EventArgs e)
        {
            SelectBccForm sbf = new SelectBccForm();
            btnBccMeail.Enabled = false;
            sbf.FormClosed += sbf_FormClosed;
            sbf.Show();
        }

        void sbf_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnBccMeail.Enabled = true;
            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (var one in _BccMailList)
            {
                count++;
                sb.Append(one.EmailBccAccountAddress);
                sb.Append(";");
                if (count >= 1000)
                {
                    break;
                }
            }
            tbBcc.Text = sb.ToString();
        }
        #endregion


        void GetAddBccSQL(EmailInfo info)
        {
            StringBuilder sbSql = new StringBuilder();
            int count = 0;
            foreach (var bcc in _BccMailList)
            {
                try
                {
                    count++;

                    sbSql.AppendFormat("insert into EmailSendBccAccount(EmailSendBccAccountID,EmailID,EmailBccAccountID,EmailAccountID,EmailSendBccAccountState,EmailSendBccAccountCreateTime,EmailSendBccAccountLastTime) values ('{0}','{1}','{2}','{3}',{4},'{5}','{6}');", Guid.NewGuid().ToString(), info.EmailID, bcc.EmailBccAccountID, "", (short)SendBccAccountState.Unsent, DateTime.Now, DateTime.Now);
                    if (count >= 5000)
                    {
                        EmailSendBccAccountBLL.Current.ExecSql(sbSql.ToString());
                        sbSql = new StringBuilder();
                        count = 0;
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error("新建郵件", "生成批量語句出錯", ex.Message, ex);
                    continue;
                }
            }
            if (sbSql.Length > 0 && !string.IsNullOrEmpty(sbSql.ToString()))
            {
                EmailSendBccAccountBLL.Current.ExecSql(sbSql.ToString());
            }
        }
    }
}
