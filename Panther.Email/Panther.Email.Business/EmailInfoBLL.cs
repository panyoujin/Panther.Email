using Panther.Email.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Panther.Email.Business
{
    /// <summary>
    /// EmailInfo
    /// </summary>
    public partial class EmailInfoBLL
    {
        public static readonly EmailInfoBLL Current = new EmailInfoBLL();
        private readonly Panther.Email.DataAccess.EmailInfoDAL dal = new Panther.Email.DataAccess.EmailInfoDAL();
        public EmailInfoBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string EmailID)
        {
            return dal.Exists(EmailID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Panther.Email.Entity.Model.EmailInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string EmailID)
        {

            return dal.Delete(EmailID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string EmailIDlist)
        {
            return dal.DeleteList(EmailIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailInfo GetModel(string EmailID)
        {

            return dal.GetModel(EmailID);
        }


        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Panther.Email.Entity.Model.EmailInfo GetModelByCache(string EmailID)
        {

            string CacheKey = "EmailInfoModel-" + EmailID;
            object objModel = null;
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(EmailID);
                }
                catch { }
            }
            return (Panther.Email.Entity.Model.EmailInfo)objModel;
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
        public List<Panther.Email.Entity.Model.EmailInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Panther.Email.Entity.Model.EmailInfo> DataTableToList(DataTable dt)
        {
            List<Panther.Email.Entity.Model.EmailInfo> modelList = new List<Panther.Email.Entity.Model.EmailInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Panther.Email.Entity.Model.EmailInfo model;
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
        /// 得到一个最早的待发送的邮件
        /// </summary>
        public Panther.Email.Entity.Model.EmailInfo GetNextEmailModel()
        {
            return dal.GetNextEmailModel();
        }

        /// <summary>
        /// 得到待发送的邮件列表
        /// </summary>
        public List<EmailInfo> GetSendEmailListModel()
        {
            return dal.GetSendEmailListModel();
        }

        /// <summary>
        /// 更新邮件发送状态
        /// </summary>
        /// <param name="emailID">郵件ID</param>
        /// <param name="state">狀態0:启动发送;1:发送完毕;2:草稿</param>
        /// <returns></returns>
        public bool UpdateEmailState(string emailID, int state)
        {
            return dal.UpdateEmailState(emailID, state);
        }
        #endregion  ExtensionMethod
    }
}

