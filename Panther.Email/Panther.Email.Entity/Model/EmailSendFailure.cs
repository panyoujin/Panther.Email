using System;
namespace Panther.Email.Entity.Model
{
	/// <summary>
	/// EmailSendFailure:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EmailSendFailure
	{
		public EmailSendFailure()
		{}
        #region Model
        private string _emailsendfailureid;
        private string _emailid;
        private string _emailbccaccountid;
        private string _emailaccountid;
        private DateTime? _emailsendfailuresendtime;
        /// <summary>
        /// 
        /// </summary>
        public string EmailSendFailureID
        {
            set { _emailsendfailureid = value; }
            get { return _emailsendfailureid; }
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
        /// 
        /// </summary>
        public string EmailBccAccountID
        {
            set { _emailbccaccountid = value; }
            get { return _emailbccaccountid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EmailAccountID
        {
            set { _emailaccountid = value; }
            get { return _emailaccountid; }
        }
        /// <summary>
        /// 发送失败时间
        /// </summary>
        public DateTime? EmailSendFailureSendTime
        {
            set { _emailsendfailuresendtime = value; }
            get { return _emailsendfailuresendtime; }
        }
        #endregion Model

	}
}

