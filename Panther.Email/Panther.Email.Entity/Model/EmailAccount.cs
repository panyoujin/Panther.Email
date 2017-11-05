using System;
namespace Panther.Email.Entity.Model
{
	/// <summary>
	/// EmailAccount:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EmailAccount
	{
		public EmailAccount()
		{}

        #region Model
        private string _emailaccountid;
        private string _emailaccountaddress;
        private string _emailaccountpassword;
        private string _emailaccountname;
        private string _emailaccountsmtp;
        private int _emailaccountsmtpport;
        private string _emailaccountpop3;
        private int _emailaccountpop3port;
        private bool _emailaccountisssl = false;
        private int _emailaccountmaxemailcount;
        private int _emailaccountremainemailcount;
        private int _emailaccountspace;
        private DateTime? _emailaccountcreatetime;
        private DateTime? _emailaccountlasttime;
        private int _sendState;
        private int _sendMode;

        /// <summary>
        /// 
        /// </summary>
        public string EmailAccountID
        {
            set { _emailaccountid = value; }
            get { return _emailaccountid; }
        }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string EmailAccountAddress
        {
            set { _emailaccountaddress = value; }
            get { return _emailaccountaddress; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string EmailAccountPassWord
        {
            set { _emailaccountpassword = value; }
            get { return _emailaccountpassword; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EmailAccountName
        {
            set { _emailaccountname = value; }
            get { return _emailaccountname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EmailAccountSMTP
        {
            set { _emailaccountsmtp = value; }
            get { return _emailaccountsmtp; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int EmailAccountSMTPPort
        {
            set { _emailaccountsmtpport = value; }
            get { return _emailaccountsmtpport; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EmailAccountPOP3
        {
            set { _emailaccountpop3 = value; }
            get { return _emailaccountpop3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int EmailAccountPOP3Port
        {
            set { _emailaccountpop3port = value; }
            get { return _emailaccountpop3port; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool EmailAccountIsSSL
        {
            set { _emailaccountisssl = value; }
            get { return _emailaccountisssl; }
        }
        /// <summary>
        /// 每次最大发送数量
        /// </summary>
        public int EmailAccountMaxEmailCount
        {
            set { _emailaccountmaxemailcount = value; }
            get { return _emailaccountmaxemailcount; }
        }
        /// <summary>
        /// 剩余数量
        /// </summary>
        public int EmailAccountRemainEmailCount
        {
            set { _emailaccountremainemailcount = value; }
            get { return _emailaccountremainemailcount; }
        }
        /// <summary>
        /// 间隔时间：分钟
        /// </summary>
        public int EmailAccountSpace
        {
            set { _emailaccountspace = value; }
            get { return _emailaccountspace; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EmailAccountCreateTime
        {
            set { _emailaccountcreatetime = value; }
            get { return _emailaccountcreatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EmailAccountLastTime
        {
            set { _emailaccountlasttime = value; }
            get { return _emailaccountlasttime; }
        }
        /// <summary>
        /// 状态，0空闲，1正在发送，-1停用
        /// </summary>
        public int SendState
        {
            get { return _sendState; }
            set { _sendState = value; }
        }

        /// <summary>
        /// 发送方式0发送，1密送
        /// </summary>
        public int SendMode
        {
            get { return _sendMode; }
            set { _sendMode = value; }
        }
        #endregion Model

	}
}

