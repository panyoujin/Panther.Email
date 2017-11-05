using System;
namespace Panther.Email.Entity.Model
{
	/// <summary>
	/// EmailBccAccount:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EmailBccAccount
	{
		public EmailBccAccount()
		{}
        #region Model
        private string _emailbccaccountid;
        private string _emailbccaccountaddress;
        private string _emailbccaccountname;
        private DateTime? _emailbccaccountcreatetime;
        private DateTime? _emailbccaccountlasttime;
        private bool _emailbccaccountisdel = false;
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
        public string EmailBccAccountAddress
        {
            set { _emailbccaccountaddress = value; }
            get { return _emailbccaccountaddress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EmailBccAccountName
        {
            set { _emailbccaccountname = value; }
            get { return _emailbccaccountname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EmailBccAccountCreateTime
        {
            set { _emailbccaccountcreatetime = value; }
            get { return _emailbccaccountcreatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EmailBccAccountLastTime
        {
            set { _emailbccaccountlasttime = value; }
            get { return _emailbccaccountlasttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool EmailBccAccountIsDel
        {
            set { _emailbccaccountisdel = value; }
            get { return _emailbccaccountisdel; }
        }
        #endregion Model

	}
}

