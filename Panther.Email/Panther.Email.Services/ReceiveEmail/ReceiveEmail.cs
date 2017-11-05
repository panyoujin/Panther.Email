using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LumiSoft.Net.Mail;
using LumiSoft.Net.Mime;
using LumiSoft.Net.POP3.Client;
using System.Net.Mail;
using Panther.Email.Core.Log;

namespace Panther.Email.Services.ReceiveEmail
{
    public class ReceiveEmail
    {
        /// <summary>
        /// 获取指定邮箱的收件箱
        /// </summary>
        /// <param name="pop3Server">POP3邮件服务器</param>
        /// <param name="pop3port"></param>
        /// <param name="emailAddress"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public List<POP3_ClientMessage> GetEmailInfos(string pop3Server, int pop3Port, bool pop3UseSsl, string emailAddress, string password)
        {
            List<POP3_ClientMessage> emailMessage = new List<POP3_ClientMessage>();
            POP3_ClientMessageCollection result = null;
            using (POP3_Client pop3 = new POP3_Client())
            {
                //与Pop3服务器建立连接
                pop3.Connect(pop3Server, pop3Port, pop3UseSsl);
                //验证身份
                pop3.Login(emailAddress, password);
                //获取邮件信息列表
                result = pop3.Messages;
                foreach (POP3_ClientMessage message in pop3.Messages)
                {
                    emailMessage.Add(message);
                    SaveEmail(message);
                    //Mail_Message mime_header = Mail_Message.ParseFromByte(message.HeaderToByte());
                }
            }
            return emailMessage;
        }

        private void SaveEmail(POP3_ClientMessage message)
        {

            var msg = new MailMessage();
            msg.ConvertToMailMessage(message);
            LogHelper.Info(string.Format("From:\"{0}\"{1}" , msg.From.Address , msg.From.DisplayName));
            string tos = "";
            foreach (var to in msg.To)
            {
                tos += string.Format("\"{0}\"{1};" , to.Address , to.DisplayName);
            }
            LogHelper.Info(string.Format("To:{0}", tos));
            string ccs = "";
            foreach (var cc in msg.CC)
            {
                ccs += string.Format("\"{0}\"{1};" , cc.Address , cc.DisplayName);
            }
            LogHelper.Info(string.Format("CC:{0}", ccs));

            LogHelper.Info("Subject" + msg.Subject);
            //LogHelper.Info("Body:" + msg.Body);
            //msg.ToArray();
            //MailWriter 
        }

    }
}
