using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using LumiSoft.Net.AUTH;
using LumiSoft.Net.Mail;
using LumiSoft.Net.MIME;
using Panther.Email.Entity.Model;
using Panther.Email.Core.Log;
using Panther.Email.Core.Helper;
using System.Threading;

namespace Panther.Email.Services.SendEmail
{

    public class SendEmail
    {
        public bool _isSetEmialInfo = false;
        #region 传统
        private SmtpClient smtp; //实例化一个SmtpClient

        /// <summary>
        /// SmtpClient实体
        /// </summary>
        public SmtpClient Smtp
        {
            get
            {
                if (smtp == null)
                {
                    smtp = new SmtpClient();
                }
                return smtp;
            }
        }
        private MailMessage mail;//实例化一个邮件类

        /// <summary>
        /// 邮件实体
        /// </summary>
        public MailMessage Mail
        {
            get
            {
                if (mail == null)
                {
                    mail = new MailMessage();
                }
                return mail;
            }
        }

        public void InitSmtpClient(string host, string account, string pass, int port = 25, bool ssl = false)
        {
            Smtp.DeliveryMethod = SmtpDeliveryMethod.Network; //将smtp的出站方式设为 Network
            Smtp.EnableSsl = ssl;//smtp服务器是否启用SSL加密
            Smtp.Host = host; //指定 smtp 服务器地址
            Smtp.Port = port;             //指定 smtp 服务器的端口，默认是25，如果采用默认端口，可省去
            //如果你的SMTP服务器不需要身份认证，则使用下面的方式，不过，目前基本没有不需要认证的了
            Smtp.UseDefaultCredentials = true;
            //如果需要认证，则用下面的方式
            Smtp.Credentials = new NetworkCredential(account, pass);
        }

        /// <summary>
        /// 发送
        /// </summary>
        public void Send()
        {
            Smtp.Send(Mail);
        }

        #region 设置邮件基本信息

        private string ToBase64(string instr)
        {
            byte[] bt = Encoding.GetEncoding("BIG5").GetBytes(instr);
            return Convert.ToBase64String(bt);
        }
        public void SetEmailInfo(EmailInfo emailInfo)
        {
            try
            {
                StringBuilder title = new StringBuilder();
                title.Append("=?BIG5?B?");
                title.Append(ToBase64(emailInfo.EmailTitle));
                title.Append("?=");
                Mail.Subject = title.ToString();
                string bodyStr;
                StringBuilder sb = new StringBuilder();
                sb.Append(emailInfo.EmailFilePath);
                bodyStr = sb.ToString();
                List<string> strList = MailHelper.GetHtmlImageUrlList(bodyStr);
                List<string> attachments = new List<string>();
                List<LinkedResource> linkedResources = new List<LinkedResource>();
                foreach (var str in strList)
                {
                    string key = Guid.NewGuid().ToString();
                    string newUrl = "cid:" + key;
                    bodyStr = bodyStr.Replace(str, newUrl);
                    LinkedResource lrImage = new LinkedResource(str, "image/gif");
                    lrImage.ContentId = key;
                    linkedResources.Add(lrImage);
                }

                AlternateView htmlBody = AlternateView.CreateAlternateViewFromString(bodyStr, Encoding.GetEncoding("BIG5"), "text/html");

                foreach (var one in linkedResources)
                {
                    htmlBody.LinkedResources.Add(one);
                }

                Mail.AlternateViews.Add(htmlBody);
                _isSetEmialInfo = true;
            }
            catch (Exception ex)
            {
                LogHelper.Error("Panther.Email.Services.SendEmail.SendEmail", "解析郵件正文出錯", ex.Message, ex);
                _isSetEmialInfo = false;
            }
        }
        /// <summary>
        /// 从eml文件中进行设置
        /// </summary>
        /// <param name="fromAddress"></param>
        /// <param name="password"></param>
        /// <param name="fromName"></param>
        /// <param name="toMails"></param>
        /// <param name="pathEml"></param>
        /// <param name="smtp"></param>
        /// <param name="port"></param>
        /// <param name="successList"></param>
        /// <param name="FailureList"></param>
        /// <param name="ssl"></param>
        public void SendToEmail(short sendMode, string fromAddress, string password, string fromName, List<EmailSendBccAccount> toMails, EmailInfo emailInfo, string smtp, int port, List<EmailSendBccAccount> successList = null, List<EmailSendBccAccount> FailureList = null, bool ssl = false)
        {
            try
            {
                if (!_isSetEmialInfo)
                {
                    SetEmailInfo(emailInfo);
                }
                if (!_isSetEmialInfo)
                {
                    throw new Exception("解析郵件正文出錯");
                }
                Mail.From = new MailAddress(fromAddress, fromName, Encoding.GetEncoding(950));
                Mail.Bcc.Clear();
                foreach (EmailSendBccAccount to in toMails)
                {
                    if (!string.IsNullOrEmpty(to.EmailBccAccountInfo.EmailBccAccountAddress))
                    {
                        try
                        {
                            Mail.Bcc.Add(new MailAddress(to.EmailBccAccountInfo.EmailBccAccountAddress, to.EmailBccAccountInfo.EmailBccAccountAddress, Encoding.GetEncoding("BIG5")));
                            successList.Add(to);
                        }
                        catch (Exception ex)
                        {
                            LogHelper.Error("Panther.Email.Services.SendEmail.SendToEml", "SetBcc", ex.Message, ex);
                            FailureList.Add(to);
                        }
                    }
                }
                StringBuilder bccs = new StringBuilder();
                foreach (var bcc in Mail.Bcc)
                {
                    bccs.Append(bcc.Address + "；");
                }
                LogHelper.Info(string.Format("發送郵箱：{0}，收件箱：{1}", Mail.From.Address, bccs.ToString()));
                Mail.Priority = MailPriority.High;
                Send();
            }
            catch (Exception ex)
            {
                successList.Clear();
                FailureList = toMails;
                LogHelper.Error("Panther.Email.Services.SendEmail.SendEmail", "SendToEml", ex.Message, ex);
                throw ex;
            }
        }


        #endregion 设置邮件基本信息
        #endregion 传统

    }
}
