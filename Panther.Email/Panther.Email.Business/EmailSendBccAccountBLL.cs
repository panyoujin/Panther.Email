using System;
using System.Collections.Generic;
using System.Data;

namespace Panther.Email.Business
{
    /// <summary>
    /// EmailSendBccAccount
    /// </summary>
    public partial class EmailSendBccAccountBLL
    {
        public static readonly EmailSendBccAccountBLL Current = new EmailSendBccAccountBLL();
        private readonly Panther.Email.DataAccess.EmailSendBccAccountDAL dal = new Panther.Email.DataAccess.EmailSendBccAccountDAL();
        public EmailSendBccAccountBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string EmailSendBccAccountID)
        {
            return dal.Exists(EmailSendBccAccountID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailSendBccAccount model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Panther.Email.Entity.Model.EmailSendBccAccount model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string EmailSendBccAccountID)
        {

            return dal.Delete(EmailSendBccAccountID);
        }

        /// <summary>
        /// 删除数据根据EmailID
        /// </summary>
        public bool DeleteByEmailID(string EmailID)
        {
            return dal.DeleteByEmailID(EmailID);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string EmailSendBccAccountIDlist)
        {
            return dal.DeleteList(EmailSendBccAccountIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailSendBccAccount GetModel(string EmailSendBccAccountID)
        {

            return dal.GetModel(EmailSendBccAccountID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Panther.Email.Entity.Model.EmailSendBccAccount GetModelByCache(string EmailSendBccAccountID)
        {

            string CacheKey = "EmailSendBccAccountModel-" + EmailSendBccAccountID;
            object objModel = null;
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(EmailSendBccAccountID);
                }
                catch { }
            }
            return (Panther.Email.Entity.Model.EmailSendBccAccount)objModel;
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
        public List<Panther.Email.Entity.Model.EmailSendBccAccount> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Panther.Email.Entity.Model.EmailSendBccAccount> DataTableToList(DataTable dt)
        {
            List<Panther.Email.Entity.Model.EmailSendBccAccount> modelList = new List<Panther.Email.Entity.Model.EmailSendBccAccount>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Panther.Email.Entity.Model.EmailSendBccAccount model;
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
        /// 获取指定的邮件的未发送或者发送失败的前count条数据
        /// </summary>
        /// <param name="emailID"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<Panther.Email.Entity.Model.EmailSendBccAccount> GetEmailSendBccAccount(string emailID, int count)
        {
            return dal.GetEmailSendBccAccount(emailID, count);
        }

        /// <summary>
        /// 修改发送状态，用于重新发送
        /// </summary>
        /// <param name="emailID">邮件ID</param>
        /// <param name="state">修改後的狀態1:已发送;0:未发送;-1:发送失败;2停止發送:发送失败;</param>
        /// <param name="type">修改的类型，1:已发送;0:未发送;-1:发送失败;2停止發送;空就是全部修改</param>
        /// <returns></returns>
        public bool UpdateSendState(string emailID, short state, string type = "")
        {
            return dal.UpdateSendState(emailID, state, type);
        }

        /// <summary>
        /// 刪除指定郵件和指定發送狀態的發送記錄
        /// </summary>
        /// <param name="emailID"></param>
        /// <param name="type">1:已发送;0:未发送;-1:发送失败;2停止發送;空就是全部刪除</param>
        /// <returns></returns>
        public bool DeleteByEmailID(string emailID, string type = "")
        {
            return dal.DeleteByEmailID(emailID, type);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailSendBccAccount DataRowToModel(DataRow row)
        {
            return dal.DataRowToModel(row);
        }

        /// <summary>
        /// 跟进SQL语句批量插入数据，执行SQL语句
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public bool ExecSql(string strSql)
        {
            return dal.ExecSql(strSql);
        }
        #endregion  ExtensionMethod
    }
}

