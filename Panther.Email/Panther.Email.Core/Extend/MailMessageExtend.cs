using LumiSoft.Net.Mail;
using LumiSoft.Net.MIME;
using LumiSoft.Net.POP3.Client;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace System.Net.Mail
{
    public static class MailMessageExtend
    {
        public static byte[] ToArray(this MailMessage msg)
        {
            const BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
            using (var ms = new MemoryStream())
            {
                var assembly = typeof(System.Net.Mail.SmtpClient).Assembly;
                var writerType = assembly.GetType("System.Net.Mail.MailWriter");
                var writer = Activator.CreateInstance(writerType, flags, null, new object[] { ms },
                                                      CultureInfo.InvariantCulture);
                msg.GetType().GetMethod("Send", flags).Invoke(msg, new[] { writer, true });
                return ms.ToArray();
            }
        }

        public static void ConvertToMailMessage(this MailMessage msg, POP3_ClientMessage message)
        {
            Mail_Message mime_header = Mail_Message.ParseFromByte(message.HeaderToByte());
            if (mime_header.From != null)
            {
                msg.From = new MailAddress(mime_header.From[0].Address, mime_header.From[0].DisplayName, Encoding.UTF8); ;
            }
            if (mime_header.To != null)
            {
                foreach (Mail_t_Mailbox recipient in mime_header.To.Mailboxes)
                {
                    msg.To.Add(new MailAddress(recipient.Address, recipient.DisplayName, Encoding.UTF8));
                }
            }
            if (mime_header.Cc != null)
            {
                foreach (Mail_t_Mailbox recipient in mime_header.Cc.Mailboxes)
                {
                    msg.CC.Add(new MailAddress(recipient.Address, recipient.DisplayName, Encoding.UTF8));
                }
            }
            msg.Subject = mime_header.Subject;
            Mail_Message mime_message = Mail_Message.ParseFromByte(message.MessageToByte());
            if (mime_message == null) return;
            msg.Body = mime_message.BodyText;
            //info.Body = mime_message.BodyText;
            try
            {
                if (!string.IsNullOrEmpty(mime_message.BodyHtmlText))
                {
                    msg.Body = mime_message.BodyHtmlText;
                }
            }
            catch
            {
                //屏蔽编码出现错误的问题，错误在BodyText存在而BodyHtmlText不存在的时候，访问BodyHtmlText会出现
            }
            #region 邮件附件内容
            foreach (MIME_Entity entity in mime_message.GetAttachments(true, true))
            {
                if (entity.ContentDisposition != null && entity.ContentDisposition.Param_FileName != null)
                {
                    if (entity.ContentDisposition.DispositionType == MIME_DispositionTypes.Attachment)
                    {
                        string fileName = entity.ContentDisposition.Param_FileName;
                        MIME_b_SinglepartBase byteObj = (MIME_b_SinglepartBase)entity.Body;
                        if (byteObj != null)
                        {
                            //可将字节保存到文件
                            int fileSize = byteObj.Data.Length;
                        }
                        //msg.Attachments.Add(new Attachment(fileName, System.Net.Mime.MediaTypeNames.Application.Rtf));

                    }
                }
            }
            #endregion 邮件附件内容
        }

    }
}
