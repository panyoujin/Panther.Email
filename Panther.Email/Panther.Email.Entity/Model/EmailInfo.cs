using System;
namespace Panther.Email.Entity.Model
{
	/// <summary>
	/// EmailInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EmailInfo
	{
		public EmailInfo()
		{}
        #region Model
        private string _emailid;
        private string _emailtitle;
        private DateTime _emailcreatetime;
        private DateTime? _emaillasttime;
        private string _emailfilepath;
        private bool _emailisdel = false;
        private int _emailstate;
        private DateTime? _emailstartsendtime;
        /// <summary>
        /// 
        /// </summary>
        public string EmailID
        {
            set { _emailid = value; }
            get { return _emailid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EmailTitle
        {
            set { _emailtitle = value; }
            get { return _emailtitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime EmailCreateTime
        {
            set { _emailcreatetime = value; }
            get { return _emailcreatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EmailLastTime
        {
            set { _emaillasttime = value; }
            get { return _emaillasttime; }
        }
        /// <summary>
        /// 正文內容
        /// </summary>
        public string EmailFilePath
        {
            set { _emailfilepath = value; }
            get { return _emailfilepath; }
        }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool EmailIsDel
        {
            set { _emailisdel = value; }
            get { return _emailisdel; }
        }
        /// <summary>
        /// 0:启动发送;1:发送完毕;2:草稿;-1发送失败
        /// </summary>
        public int EmailState
        {
            set { _emailstate = value; }
            get { return _emailstate; }
        }
        /// <summary>
        /// 启动发送的时间
        /// </summary>
        public DateTime? EmailStartSendTime
        {
            set { _emailstartsendtime = value; }
            get { return _emailstartsendtime; }
        }
        #endregion Model

	}
}

