using System;
namespace Panther.Email.Entity.Model
{
	/// <summary>
	/// EmailInbox:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EmailInbox
	{
		public EmailInbox()
		{}
        #region Model
        private string _emailinboxid;
        private string _emailserveruid;
        private string _emailinboxtitle;
        private string _emailinboxfrom;
        private string _emailinboxfromname;
        private string _emailinboxdate;
        private string _emailinboxfilepath;
        private int _emailinboxstate;
        private bool _emailinboxisdel = false;
        /// <summary>
        /// 
        /// </summary>
        public string EmailInboxID
        {
            set { _emailinboxid = value; }
            get { return _emailinboxid; }
        }
        /// <summary>
        /// 服务器ID
        /// </summary>
        public string EmailServerUID
        {
            set { _emailserveruid = value; }
            get { return _emailserveruid; }
        }
        /// <summary>
        /// 标题
        /// </summary>
        public string EmailInboxTitle
        {
            set { _emailinboxtitle = value; }
            get { return _emailinboxtitle; }
        }
        /// <summary>
        /// 发件人地址
        /// </summary>
        public string EmailInboxFrom
        {
            set { _emailinboxfrom = value; }
            get { return _emailinboxfrom; }
        }
        /// <summary>
        /// 发件人名称
        /// </summary>
        public string EmailInboxFromName
        {
            set { _emailinboxfromname = value; }
            get { return _emailinboxfromname; }
        }
        /// <summary>
        /// 收件时间
        /// </summary>
        public string EmailInboxDate
        {
            set { _emailinboxdate = value; }
            get { return _emailinboxdate; }
        }
        /// <summary>
        /// eml地址
        /// </summary>
        public string EmailInboxFilePath
        {
            set { _emailinboxfilepath = value; }
            get { return _emailinboxfilepath; }
        }
        /// <summary>
        /// 状态1:已阅读;0:未阅读
        /// </summary>
        public int EmailInboxState
        {
            set { _emailinboxstate = value; }
            get { return _emailinboxstate; }
        }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool EmailInboxIsDel
        {
            set { _emailinboxisdel = value; }
            get { return _emailinboxisdel; }
        }
        #endregion Model

	}
}

