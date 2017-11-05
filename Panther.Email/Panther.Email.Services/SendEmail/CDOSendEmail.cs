using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CDO;
using Panther.Email.Core.Helper;
using Panther.Email.Core.Log;
using Panther.Email.Entity.Model;

namespace Panther.Email.Services.SendEmail
{
    public class CDOSendEmail
    {
        public void SendEmail(EmailInfo emailInfo, EmailAccount emailAccount, List<EmailSendBccAccount> toMails, List<EmailSendBccAccount> successList = null, List<EmailSendBccAccount> FailureList = null)
        {
            try
            {
                #region 设置基本信息
                CDO.Message oMsg = new CDO.Message();

                Configuration conf = new ConfigurationClass();
                conf.Fields[CdoConfiguration.cdoSendUsingMethod].Value = CdoSendUsing.cdoSendUsingPort;
                conf.Fields[CdoConfiguration.cdoSMTPAuthenticate].Value = CdoProtocolsAuthentication.cdoBasic;
                conf.Fields[CdoConfiguration.cdoSMTPUseSSL].Value = false;
                conf.Fields[CdoConfiguration.cdoSMTPServer].Value = emailAccount.EmailAccountSMTP;//必填，而且要真实可用   
                conf.Fields[CdoConfiguration.cdoSMTPServerPort].Value = emailAccount.EmailAccountSMTPPort;
                conf.Fields[CdoConfiguration.cdoSendEmailAddress].Value = emailAccount.EmailAccountAddress;
                conf.Fields[CdoConfiguration.cdoSendUserName].Value = emailAccount.EmailAccountAddress;//真实的邮件地址   
                conf.Fields[CdoConfiguration.cdoSendPassword].Value = emailAccount.EmailAccountPassWord;   //为邮箱密码，必须真实   

                conf.Fields.Update();
                oMsg.Configuration = conf;
                #endregion 设置基本信息

                #region htmlbody

                string bodyStr = emailInfo.EmailFilePath;
                List<string> strList = MailHelper.GetHtmlImageUrlList(bodyStr);
                Dictionary<string, string> dicImage = new Dictionary<string, string>();
                foreach (var str in strList)
                {
                    string key = Guid.NewGuid().ToString();
                    string newUrl = "cid:" + key;
                    bodyStr = bodyStr.Replace(str, newUrl);
                    dicImage.Add(key, str);
                }
                oMsg.HTMLBody = bodyStr;
                #endregion
                StringBuilder title = new StringBuilder();
                title.Append("=?BIG5?B?");
                title.Append(ToBase64(emailInfo.EmailTitle));
                title.Append("?=");
                oMsg.Subject = title.ToString();
                oMsg.From = "\"" + emailAccount.EmailAccountName + "\"" + emailAccount.EmailAccountAddress;
                ;//真实的邮件地址   
                #region BCC
                StringBuilder bccs = new StringBuilder();
                foreach (EmailSendBccAccount to in toMails)
                {

                    try
                    {
                        //还要加上邮箱的正确性检验
                        if (!string.IsNullOrEmpty(to.EmailBccAccountInfo.EmailBccAccountAddress)) //&& MailHelper.IsEmail(to.EmailBccAccountInfo.EmailBccAccountAddress))
                        {
                            bccs.Append(to.EmailBccAccountInfo.EmailBccAccountAddress + ";");
                            successList.Add(to);
                        }
                        else
                        {
                            FailureList.Add(to);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogHelper.Error("Panther.Email.Services.SendEmail.CDOSendEmail", "SetBcc", ex.Message, ex);
                        FailureList.Add(to);
                    }
                }

                oMsg.BCC = bccs.ToString();
                LogHelper.Info(string.Format("發送郵箱：{0}，收件箱：{1}", oMsg.From, oMsg.BCC));
                #endregion BCC
                oMsg.HTMLBodyPart.Charset = "BIG5";

                foreach (var imgUrl in dicImage)
                {
                    oMsg.AddRelatedBodyPart(imgUrl.Value, imgUrl.Key, CdoReferenceType.cdoRefTypeId);
                }

                oMsg.Send();
             }
            catch (Exception ex)
            {
                successList.Clear();
                FailureList = toMails;
                LogHelper.Error("Panther.Email.Services.SendEmail.CDOSendEmail", "SendEmail", ex.Message, ex);
                throw ex;
            }
        }

        private string ToBase64(string instr)
        {
            byte[] bt = Encoding.GetEncoding("BIG5").GetBytes(instr);
            return Convert.ToBase64String(bt);
        }
    }
}
