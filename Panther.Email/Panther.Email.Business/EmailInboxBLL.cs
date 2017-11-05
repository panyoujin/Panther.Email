using System;
using System.Collections.Generic;
using System.Data;

namespace Panther.Email.Business
{
	/// <summary>
	/// EmailInbox
	/// </summary>
	public partial class EmailInboxBLL
	{
		private readonly Panther.Email.DataAccess.EmailInboxDAL dal=new Panther.Email.DataAccess.EmailInboxDAL();
		public EmailInboxBLL()
		{}
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string EmailInboxID)
        {
            return dal.Exists(EmailInboxID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailInbox model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Panther.Email.Entity.Model.EmailInbox model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string EmailInboxID)
        {

            return dal.Delete(EmailInboxID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string EmailInboxIDlist)
        {
            return dal.DeleteList(EmailInboxIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailInbox GetModel(string EmailInboxID)
        {

            return dal.GetModel(EmailInboxID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Panther.Email.Entity.Model.EmailInbox GetModelByCache(string EmailInboxID)
        {

            string CacheKey = "EmailInboxModel-" + EmailInboxID;
            object objModel = null;
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(EmailInboxID);
                }
                catch { }
            }
            return (Panther.Email.Entity.Model.EmailInbox)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Panther.Email.Entity.Model.EmailInbox> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Panther.Email.Entity.Model.EmailInbox> DataTableToList(DataTable dt)
        {
            List<Panther.Email.Entity.Model.EmailInbox> modelList = new List<Panther.Email.Entity.Model.EmailInbox>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Panther.Email.Entity.Model.EmailInbox model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
	}
}

