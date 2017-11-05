using System;
using System.Collections.Generic;
using System.Data;

namespace Panther.Email.Business
{
	/// <summary>
	/// EmailSendFailure
	/// </summary>
	public partial class EmailSendFailureBLL
	{
        public static readonly EmailSendFailureBLL Current = new EmailSendFailureBLL();
		private readonly Panther.Email.DataAccess.EmailSendFailureDAL dal=new Panther.Email.DataAccess.EmailSendFailureDAL();
		public EmailSendFailureBLL()
		{}
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string EmailSendFailureID)
        {
            return dal.Exists(EmailSendFailureID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailSendFailure model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Panther.Email.Entity.Model.EmailSendFailure model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string EmailSendFailureID)
        {

            return dal.Delete(EmailSendFailureID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string EmailSendFailureIDlist)
        {
            return dal.DeleteList(EmailSendFailureIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailSendFailure GetModel(string EmailSendFailureID)
        {

            return dal.GetModel(EmailSendFailureID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Panther.Email.Entity.Model.EmailSendFailure GetModelByCache(string EmailSendFailureID)
        {

            string CacheKey = "EmailSendFailureModel-" + EmailSendFailureID;
            object objModel = null;
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(EmailSendFailureID);
                    
                }
                catch { }
            }
            return (Panther.Email.Entity.Model.EmailSendFailure)objModel;
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
        public List<Panther.Email.Entity.Model.EmailSendFailure> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Panther.Email.Entity.Model.EmailSendFailure> DataTableToList(DataTable dt)
        {
            List<Panther.Email.Entity.Model.EmailSendFailure> modelList = new List<Panther.Email.Entity.Model.EmailSendFailure>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Panther.Email.Entity.Model.EmailSendFailure model;
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

