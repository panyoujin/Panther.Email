using System;
namespace Panther.Email.Entity.Model
{
	/// <summary>
	/// EmailSendBccAccount:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EmailSendBccAccount
	{
		public EmailSendBccAccount()
		{}
        #region Model
        private string _emailsendbccaccountid;
        private string _emailid;
        private string _emailbccaccountid;
        private string _emailaccountid;
        private int _emailsendbccaccountstate;
        private DateTime? _emailsendbccaccountcreatetime;
        private DateTime? _emailsendbccaccountlasttime;
        private DateTime? _emailsendbccaccountsendtime;
        /// <summary>
        /// 
        /// </summary>
        public string EmailSendBccAccountID
        {
            set { _emailsendbccaccountid = value; }
            get { return _emailsendbccaccountid; }
        }
        /// <summary>
        /// 邮件ID
        /// </summary>
        public string EmailID
        {
            set { _emailid = value; }
            get { return _emailid; }
        }
        /// <summary>
        /// 密送邮箱ID
        /// </summary>
        public string EmailBccAccountID
        {
            set { _emailbccaccountid = value; }
            get { return _emailbccaccountid; }
        }

        public EmailBccAccount EmailBccAccountInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 发件箱ID
        /// </summary>
        public string EmailAccountID
        {
            set { _emailaccountid = value; }
            get { return _emailaccountid; }
        }
        /// <summary>
        /// 1:已发送;0:未发送;-1:发送失败
        /// </summary>
        public int EmailSendBccAccountState
        {
            set { _emailsendbccaccountstate = value; }
            get { return _emailsendbccaccountstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EmailSendBccAccountCreateTime
        {
            set { _emailsendbccaccountcreatetime = value; }
            get { return _emailsendbccaccountcreatetime; }
        }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime? EmailSendBccAccountLastTime
        {
            set { _emailsendbccaccountlasttime = value; }
            get { return _emailsendbccaccountlasttime; }
        }
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime? EmailSendBccAccountSendTIme
        {
            set { _emailsendbccaccountsendtime = value; }
            get { return _emailsendbccaccountsendtime; }
        }
        #endregion Model

	}
}

