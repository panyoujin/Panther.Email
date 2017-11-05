using System;
using System.Collections.Generic;
using System.Data;

namespace Panther.Email.Business
{
	/// <summary>
	/// EmailSendAccount
	/// </summary>
	public partial class EmailSendAccountBLL
	{
        public static readonly EmailSendAccountBLL Current = new EmailSendAccountBLL();
		private readonly Panther.Email.DataAccess.EmailSendAccountDAL dal=new Panther.Email.DataAccess.EmailSendAccountDAL();
		public EmailSendAccountBLL()
		{}
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string EmailSendAccountID)
        {
            return dal.Exists(EmailSendAccountID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailSendAccount model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Panther.Email.Entity.Model.EmailSendAccount model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string EmailSendAccountID)
        {

            return dal.Delete(EmailSendAccountID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string EmailSendAccountIDlist)
        {
            return dal.DeleteList(EmailSendAccountIDlist);
        }

        /// <summary>
        /// 删除数据根据EmailID
        /// </summary>
        public bool DeleteByEmailID(string EmailID)
        {
            return dal.DeleteByEmailID(EmailID);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailSendAccount GetModel(string EmailSendAccountID)
        {

            return dal.GetModel(EmailSendAccountID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Panther.Email.Entity.Model.EmailSendAccount GetModelByCache(string EmailSendAccountID)
        {

            string CacheKey = "EmailSendAccountModel-" + EmailSendAccountID;
            object objModel = null;
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(EmailSendAccountID);
                }
                catch { }
            }
            return (Panther.Email.Entity.Model.EmailSendAccount)objModel;
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
        public List<Panther.Email.Entity.Model.EmailSendAccount> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Panther.Email.Entity.Model.EmailSendAccount> DataTableToList(DataTable dt)
        {
            List<Panther.Email.Entity.Model.EmailSendAccount> modelList = new List<Panther.Email.Entity.Model.EmailSendAccount>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Panther.Email.Entity.Model.EmailSendAccount model;
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

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        /// <param name="tableSql">表名，可以是SQL</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="orderby">排序字段，必填，否则无效,如果数据库有重复，可能拿到的数量不一致，请保证排序的字段里有一个字段是唯一</param>
        /// <param name="startIndex">当前页的第一条数据位置</param>
        /// <param name="endIndex">当前页的最后一条数据位置</param>
        /// <param name="columns">需要获取的列</param>
        /// <param name="orderType">排序类型，ASC或者DESC</param>
        /// <returns></returns>
        public DataSet GetListByPage(string tableSql, string strWhere, string orderby, int startIndex, int endIndex, string columns = "*", string orderType = "ASC")
        {
            return dal.GetListByPage(tableSql, strWhere, orderby, startIndex, endIndex, columns, orderType);
        }

         /// <summary>
        /// 获取记录总数
        /// </summary>
        /// <param name="tableSql">表名，可以是SQL</param>
        /// <param name="strWhere">查询条件</param>
        /// <returns></returns>
        public int GetRecordCount(string tableSql, string strWhere)
        {
            return dal.GetRecordCount(tableSql, strWhere);
        }
        #endregion  ExtensionMethod
	}
}

