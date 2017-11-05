using Panther.Email.DataAccess.DbBase;
using System.Collections.Generic;
using System.Data;
namespace Panther.Email.Business
{
    /// <summary>
    /// EmailAccount
    /// </summary>
    public partial class EmailAccountBLL
    {
        public static readonly EmailAccountBLL Current = new EmailAccountBLL();
        private readonly Panther.Email.DataAccess.EmailAccountDAL dal = new Panther.Email.DataAccess.EmailAccountDAL();
        public EmailAccountBLL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailAccount model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Panther.Email.Entity.Model.EmailAccount model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Panther.Email.Entity.Model.EmailAccount model, bool isUpdateTime)
        {
            return dal.Update(model, true);

        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string emailAccountID)
        {
            return dal.Delete(emailAccountID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailAccount GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.GetModel();
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Panther.Email.Entity.Model.EmailAccount GetModelByCache()
        {
            //该表无主键信息，请自定义主键/条件字段
            string CacheKey = "EmailAccountModel-";
            object objModel = null;
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel();
                }
                catch { }
            }
            return (Panther.Email.Entity.Model.EmailAccount)objModel;
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
        public List<Panther.Email.Entity.Model.EmailAccount> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Panther.Email.Entity.Model.EmailAccount> DataTableToList(DataTable dt)
        {
            List<Panther.Email.Entity.Model.EmailAccount> modelList = new List<Panther.Email.Entity.Model.EmailAccount>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Panther.Email.Entity.Model.EmailAccount model;
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
        /// 更加邮件ID获取所有有空闲的邮箱信息
        /// </summary>
        /// <param name="emailID"></param>
        /// <returns></returns>
        public List<Panther.Email.Entity.Model.EmailAccount> GetEmailAccounts(string emailID)
        {
            DataSet ds = dal.GetEmailAccounts(emailID);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        ///判斷郵箱是否存在數據庫
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool IsExists(string email)
        {
            return dal.IsExists(email);
        }

        public bool UpdateState(Panther.Email.Entity.Model.EmailAccount model)
        {
            return dal.UpdateState(model);
        }
        #endregion  ExtensionMethod
    }
}

