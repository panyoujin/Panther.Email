using System;
using System.Collections.Generic;
using System.Data;

namespace Panther.Email.Business
{
    /// <summary>
    /// EmailBccAccount
    /// </summary>
    public partial class EmailBccAccountBLL
    {
        public static readonly EmailBccAccountBLL Current = new EmailBccAccountBLL();
        private readonly Panther.Email.DataAccess.EmailBccAccountDAL dal = new Panther.Email.DataAccess.EmailBccAccountDAL();
        public EmailBccAccountBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string EmailBccAccountID)
        {
            return dal.Exists(EmailBccAccountID);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsEmail(string emailStr)
        {
            return dal.ExistsEmail(emailStr);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailBccAccount model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Panther.Email.Entity.Model.EmailBccAccount model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 批量更新收件人名称
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        /// <returns></returns>
        public bool UpdateName(string oldName, string newName)
        {
            return dal.UpdateName(oldName, newName);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string EmailBccAccountID)
        {

            return dal.Delete(EmailBccAccountID);
        }

        /// <summary>
        /// 根据邮件地址删除邮件
        /// </summary>
        /// <param name="EmailBccAccountAddress"></param>
        /// <returns></returns>
        public bool DeleteByMailAddress(string EmailBccAccountAddress)
        {
            return dal.DeleteByMailAddress(EmailBccAccountAddress);
        }

        /// <summary>
        /// 批量删除邮件地址
        /// </summary>
        /// <param name="EmailBccAccountAddressStr"></param>
        /// <returns></returns>
        public bool DeleteByMailAddressMore(string EmailBccAccountAddressStr)
        {
            return dal.DeleteBymailAddressMore(EmailBccAccountAddressStr);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string EmailBccAccountIDlist)
        {
            return dal.DeleteList(EmailBccAccountIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailBccAccount GetModel(string EmailBccAccountID)
        {

            return dal.GetModel(EmailBccAccountID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Panther.Email.Entity.Model.EmailBccAccount GetModelByCache(string EmailBccAccountID)
        {

            string CacheKey = "EmailBccAccountModel-" + EmailBccAccountID;
            object objModel = null;
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(EmailBccAccountID);
                }
                catch { }
            }
            return (Panther.Email.Entity.Model.EmailBccAccount)objModel;
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
        public List<Panther.Email.Entity.Model.EmailBccAccount> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Panther.Email.Entity.Model.EmailBccAccount> GetModelList(string strWhere, int start, int end)
        {
            DataSet ds = dal.GetList(strWhere, start, end);
            return DataTableToList(ds.Tables[0]);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Panther.Email.Entity.Model.EmailBccAccount> DataTableToList(DataTable dt)
        {
            List<Panther.Email.Entity.Model.EmailBccAccount> modelList = new List<Panther.Email.Entity.Model.EmailBccAccount>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Panther.Email.Entity.Model.EmailBccAccount model;
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
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailBccAccount DataRowToModel(DataRow row)
        {
            return dal.DataRowToModel(row);
        }
        #endregion  ExtensionMethod
    }
}

