using System;
using System.Collections.Generic;
using LumiSoft.Net.AUTH;
using Panther.Email.Business;
using Panther.Email.Core.Log;
using Panther.Email.Entity.Model;
using Panther.Email.Services.Base;
using System.IO;
using System.Threading;
using Panther.Email.Core.Helper;
using System.Linq;

namespace Panther.Email.Services.SendEmail
{
    public class SmartSendEmail : EmailServerBase
    {

        Dictionary<string, Thread> _threadDic = new Dictionary<string, Thread>();
        List<EmailInfo> SendingEmailInfo = new List<EmailInfo>();
        public SmartSendEmail()
        {
            //this._Acction = Run;
        }


        public override void Run()
        {
            LogHelper.Info("Panther.Email.Services.SendEmail.SmartSendEmail->Run()");
            //ping
            if (!PingHelper.TryConnect("www.baidu.com") && !PingHelper.TryConnect("www.google.cn"))
            {
                LogHelper.Error("无法连接連接網絡。");
                return;
            }
            while (IsStart)
            {
                List<EmailInfo> emailList = GetSendEmailList();
                if (emailList == null || emailList.Count <= 0)
                {
                    LogHelper.Info("本次掃描完畢，沒有符合條件的發送郵件");
                }
                else
                {
                    foreach (var emailInfo in emailList)
                    {
                        //获取需要发送的邮件
                        //EmailInfo emailInfo = GetNextEmail();
                        if (emailInfo == null || emailInfo.EmailID == null)
                        {
                            LogHelper.Info("本次掃描完畢，沒有符合條件的發送郵件2");
                            continue;
                        }
                        //检测eml是否存在
                        if (string.IsNullOrEmpty(emailInfo.EmailFilePath))
                        {
                            //修改状态
                            emailInfo.EmailState = -1;
                            EmailInfoBLL emailinfobll = new EmailInfoBLL();
                            emailinfobll.Update(emailInfo);
                            LogHelper.Info("邮件正文為空，无法发送");
                            continue;
                        }
                        var t = new Thread(s =>
                            {
                                var info = s as EmailInfo;
                                SendEmail(info);
                            });
                        t.Start(emailInfo);
                    }
                }
                SleepInterval(Interval);
            }
        }

        void SendEmail(EmailInfo emailInfo)
        {
            if (SendingEmailInfo.Where(e => e.EmailID == emailInfo.EmailID).Count() > 0)
            {
                //如果已经在发送队列里面了
                return;
            }
            //获取发送邮件的邮箱集合
            List<EmailAccount> emailAccountList = GetEmailSendAccount(emailInfo);
            if (emailAccountList == null || emailAccountList.Count <= 0)
            {
                return;
            }
            //判断是否有邮箱是可用状态
            if (emailAccountList.Where(a => a.EmailAccountLastTime <= DateTime.Now && a.EmailAccountRemainEmailCount > 0).Count() <= 0)
            {
                return;
            }
            //如果待发送bcc一个人都没，直接返回
            var tempBccAccount = GetEmailSendBccAccounts(emailInfo, 1);
            if (tempBccAccount == null || tempBccAccount.Count <= 0)
            {
                return;
            }
            SendingEmailInfo.Add(emailInfo);
            var complete = false;
            foreach (EmailAccount emailAccount in emailAccountList)
            {
                LogHelper.Info(string.Format("發送帳號為：{0},發送郵件：{1}", emailAccount.EmailAccountAddress, emailInfo.EmailTitle));
            }
            while (!complete && IsStart)
            {
                foreach (EmailAccount emailAccount in emailAccountList)
                {
                    //当前邮箱的下次发送时间小等于当前时间，并且剩余发送数量大于0
                    if (emailAccount.EmailAccountLastTime <= DateTime.Now && emailAccount.EmailAccountRemainEmailCount > 0)
                    {
                        //如果上一次发送时间离当前时间大于1个间隔时间，就将可发生数量改为最大可发送数量
                        if (emailAccount.EmailAccountCreateTime.Value.AddMinutes(emailAccount.EmailAccountSpace) < DateTime.Now)
                        {
                            emailAccount.EmailAccountRemainEmailCount = emailAccount.EmailAccountMaxEmailCount;
                        }
                        var emailBccAccount = GetEmailSendBccAccounts(emailInfo, emailAccount.EmailAccountRemainEmailCount);
                        //判断邮件发送是否完成,获取到的邮件数量为0或者为空，就相当于发送完毕
                        if (emailBccAccount == null || emailBccAccount.Count <= 0)
                        {
                            //修改为已完成
                            emailInfo.EmailState = 1;
                            EmailInfoBLL emailinfoBLL = new EmailInfoBLL();
                            emailinfoBLL.Update(emailInfo);
                            complete = true;
                            break;
                        }
                        //发送状态0未发送，1已发送，-1发送失败,3正在发送
                        try
                        {
                            SendEmailBCCAccount(emailInfo, emailAccount, emailBccAccount);
                        }
                        catch (Exception ex)
                        {
                            LogHelper.Error("發送郵件", "線程操作", ex.Message, ex);
                        }
                        SleepInterval(Interval * 2);
                    }
                }
                SleepInterval(Interval * 2);
            }
            SendingEmailInfo.Remove(emailInfo);
        }
        /// <summary>
        /// 读取下一个能进行发送的邮件
        /// 能进行发送的邮件是指：邮件的发送时间小于等于当前时间，状态为启动发送，并且有空闲的邮箱
        /// </summary>
        /// <returns></returns>
        public EmailInfo GetNextEmail()
        {
            EmailInfo email = null;
            //获取数据库
            email = EmailInfoBLL.Current.GetNextEmailModel();
            return email;
        }

        /// <summary>
        /// 读取下一个能进行发送的邮件
        /// 能进行发送的邮件是指：邮件的发送时间小于等于当前时间，状态为启动发送，并且有空闲的邮箱
        /// </summary>
        /// <returns></returns>
        public List<EmailInfo> GetSendEmailList()
        {
            //获取数据库
            var emailList = EmailInfoBLL.Current.GetSendEmailListModel();
            return emailList;
        }

        /// <summary>
        /// 获取对应的邮件能使用的邮箱
        /// 能使用的邮箱是指：指定为该邮件的发送邮箱，并且在此之前未被使用
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public List<EmailAccount> GetEmailSendAccount(EmailInfo email)
        {
            List<EmailAccount> emailAccountList = new List<EmailAccount>();
            //获取数据库
            emailAccountList = EmailAccountBLL.Current.GetEmailAccounts(email.EmailID);
            return emailAccountList;
        }

        public List<EmailSendBccAccount> GetEmailSendBccAccounts(EmailInfo email, int count)
        {
            List<EmailSendBccAccount> emailbccAccountList = new List<EmailSendBccAccount>();
            //获取数据库
            EmailSendBccAccountBLL emailSendBccBLL = new EmailSendBccAccountBLL();
            emailbccAccountList = emailSendBccBLL.GetEmailSendBccAccount(email.EmailID, count);
            return emailbccAccountList;
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="emailInfo"></param>
        /// <param name="emailAccount"></param>
        /// <param name="emailbccAccountList"></param>
        private void SendEmailBCCAccount(EmailInfo emailInfo, EmailAccount emailAccount, List<EmailSendBccAccount> emailbccAccountList)
        {
            //事务
            //批量修改数据库发送邮箱信息
            LogHelper.Info(string.Format("當前發送郵箱為：{0},發送數量為：{1},發送郵件為：{2}", emailAccount.EmailAccountAddress, emailbccAccountList.Count, emailInfo.EmailTitle));
            int state;

            List<EmailSendBccAccount> successList = new List<EmailSendBccAccount>();
            List<EmailSendBccAccount> FailureList = new List<EmailSendBccAccount>();
            //发送
            try
            {
                //SendEmail sendEmail = new SendEmail();
                //sendEmail.SetEmailInfo(emailInfo);
                //sendEmail.InitSmtpClient(emailAccount.EmailAccountSMTP, emailAccount.EmailAccountAddress, emailAccount.EmailAccountPassWord, emailAccount.EmailAccountSMTPPort, emailAccount.EmailAccountIsSSL);
                //sendEmail.SendToEmail(emailAccount.SendMode, emailAccount.EmailAccountAddress, emailAccount.EmailAccountPassWord, emailAccount.EmailAccountName, emailbccAccountList, emailInfo, emailAccount.EmailAccountSMTP, emailAccount.EmailAccountSMTPPort, successList, FailureList, emailAccount.EmailAccountIsSSL);
                CDOSendEmail cdoSend = new CDOSendEmail();
                cdoSend.SendEmail(emailInfo, emailAccount, emailbccAccountList, successList, FailureList);
                state = 1;
            }
            catch (Exception ex)
            {
                LogHelper.Error(string.Format("郵件：{0} 發送失敗，失敗原因：{1}", emailInfo.EmailTitle, ex.Message));
                state = -1;
                UpdateEmailSendBccAccount(emailAccount, emailbccAccountList, state);
                InsertFailureByList(emailInfo, emailbccAccountList, emailAccount);
                UpdateEmailAccount(emailAccount, (int)(successList.Count));
                return;
            }
            //批量修改发送时间和发送状态

            UpdateEmailSendBccAccount(emailAccount, successList, state);
            UpdateEmailSendBccAccount(emailAccount, FailureList, -1);
            InsertFailureByList(emailInfo, FailureList, emailAccount);

            //修改邮箱剩余数量和下次发送时间
            //if (state == 1)
            //{
            UpdateEmailAccount(emailAccount, (int)(successList.Count));
            //}

        }

        /// <summary>
        /// 修改邮件和收件箱的关联表的状态和时间
        /// </summary>
        /// <param name="emailAccount"></param>
        /// <param name="successList"></param>
        /// <param name="state"></param>
        private void UpdateEmailSendBccAccount(EmailAccount emailAccount, List<EmailSendBccAccount> successList, int state = 0)
        {
            foreach (EmailSendBccAccount model in successList)
            {
                model.EmailAccountID = emailAccount.EmailAccountID;
                model.EmailSendBccAccountState = state;
                model.EmailSendBccAccountSendTIme = DateTime.Now;
                model.EmailSendBccAccountLastTime = DateTime.Now;
                EmailSendBccAccountBLL.Current.Update(model);
            }
        }

        /// <summary>
        /// 修改发件箱信息
        /// </summary>
        /// <param name="emailAccount"></param>
        /// <param name="count"></param>
        private void UpdateEmailAccount(EmailAccount emailAccount, int count)
        {
            if (emailAccount.EmailAccountRemainEmailCount > count)
            {
                emailAccount.EmailAccountRemainEmailCount = (int)(emailAccount.EmailAccountRemainEmailCount - count);
                //emailAccount.EmailAccountLastTime = DateTime.Now.AddMinutes(5);
            }
            else
            {
                emailAccount.EmailAccountRemainEmailCount = emailAccount.EmailAccountMaxEmailCount;
                emailAccount.EmailAccountLastTime = DateTime.Now.AddMinutes(emailAccount.EmailAccountSpace);
            }
            emailAccount.EmailAccountCreateTime = DateTime.Now;
            emailAccount.SendState = 0;
            EmailAccountBLL.Current.Update(emailAccount);
        }

        /// <summary>
        /// 单个添加失败记录
        /// </summary>
        /// <param name="emailInfo"></param>
        /// <param name="bccAccountID"></param>
        /// <param name="emailAccount"></param>
        private void InsertFailure(EmailInfo emailInfo, string bccAccountID, EmailAccount emailAccount)
        {
            //foreach (EmailSendBccAccount emailSendBccAccount in emailbccAccountList)
            //{
            EmailSendFailure model = new EmailSendFailure();
            model.EmailAccountID = emailAccount.EmailAccountID;
            model.EmailID = emailInfo.EmailID;
            model.EmailSendFailureID = Guid.NewGuid().ToString();
            model.EmailSendFailureSendTime = DateTime.Now;
            model.EmailBccAccountID = bccAccountID;
            EmailSendFailureBLL.Current.Add(model);
            //}
        }

        /// <summary>
        /// 批量添加失败记录
        /// </summary>
        /// <param name="emailInfo"></param>
        /// <param name="bccAccountID"></param>
        /// <param name="emailAccount"></param>
        private void InsertFailureByList(EmailInfo emailInfo, List<EmailSendBccAccount> emailbccAccountList, EmailAccount emailAccount)
        {
            foreach (EmailSendBccAccount emailSendBccAccount in emailbccAccountList)
            {
                EmailSendFailure model = new EmailSendFailure();
                model.EmailAccountID = emailAccount.EmailAccountID;
                model.EmailID = emailInfo.EmailID;
                model.EmailSendFailureID = Guid.NewGuid().ToString();
                model.EmailSendFailureSendTime = DateTime.Now;
                model.EmailBccAccountID = emailSendBccAccount.EmailBccAccountID; ;
                EmailSendFailureBLL.Current.Add(model);
            }
        }
    }
}
