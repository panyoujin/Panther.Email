using System;
namespace Panther.Email.Entity.Model
{
	/// <summary>
	/// EmailSendAccount:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EmailSendAccount
	{
		public EmailSendAccount()
		{}
        #region Model
        private string _emailsendaccountid;
        private string _emailid;
        private string _emailaccountid;
        private DateTime? _emailsendaccountcreatetime;
        /// <summary>
        /// 
        /// </summary>
        public string EmailSendAccountID
        {
            set { _emailsendaccountid = value; }
            get { return _emailsendaccountid; }
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
        /// 发件箱ID
        /// </summary>
        public string EmailAccountID
        {
            set { _emailaccountid = value; }
            get { return _emailaccountid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EmailSendAccountCreateTime
        {
            set { _emailsendaccountcreatetime = value; }
            get { return _emailsendaccountcreatetime; }
        }
        #endregion Model

	}
}

