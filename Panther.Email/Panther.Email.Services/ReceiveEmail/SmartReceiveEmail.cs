using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LumiSoft.Net.Mime;
using Panther.Email.Core.Log;
using Panther.Email.Entity.Model;
using Panther.Email.Services.Base;
using System.Net.Mail;
using LumiSoft.Net.POP3.Client;

namespace Panther.Email.Services.ReceiveEmail
{
    public class SmartReceiveEmail : EmailServerBase
    {

        ReceiveEmail _receiveEmail = new ReceiveEmail();

        public SmartReceiveEmail()
        {

        }

        public override void Run()
        {
            LogHelper.Info("Panther.Email.Services.ReceiveEmail.SmartReceiveEmail->Run()");
            List<EmailAccount> eamilAccount = GetReceiveEmailAccount();
            foreach (EmailAccount account in eamilAccount)
            {
                GetEmailInfo(account);
            }
        }

        /// <summary>
        /// 获取所有的发件箱
        /// </summary>
        /// <returns></returns>
        private List<EmailAccount> GetReceiveEmailAccount()
        {
            List<EmailAccount> emailAccountList = new List<EmailAccount>();
            //数据库访问
            emailAccountList.Add(new EmailAccount()
            {
                EmailAccountAddress = "904709108@qq.com",
                EmailAccountPassWord = "131427131427pyj",
                EmailAccountPOP3 = "pop.qq.com",
                EmailAccountPOP3Port = 110,
                EmailAccountIsSSL = false
            });
            return emailAccountList;
        }


        private void GetEmailInfo(EmailAccount emailAccount)
        {
            var emailInfos = _receiveEmail.GetEmailInfos(emailAccount.EmailAccountPOP3, emailAccount.EmailAccountPOP3Port, emailAccount.EmailAccountIsSSL, emailAccount.EmailAccountAddress, emailAccount.EmailAccountPassWord);
            //foreach (POP3_ClientMessage info in emailInfos)
            //{
            //    SaveEmail(info);
            //}
        }

        private void SaveEmail(POP3_ClientMessage message)
        {

            var msg = new MailMessage();
            msg.ConvertToMailMessage(message);
            LogHelper.Info(msg.From);
            LogHelper.Info(msg.To);
            LogHelper.Info(msg.CC);
            LogHelper.Info(msg.Body);
            LogHelper.Info(msg.Subject);
            msg.ToArray();
            //MailWriter 
        }
    }
}
