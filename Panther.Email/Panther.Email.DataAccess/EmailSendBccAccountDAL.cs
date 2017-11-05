using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;//Please add references
using System.Text;
using Panther.Email.DataAccess.DbBase;

namespace Panther.Email.DataAccess
{
    /// <summary>
    /// 数据访问类:EmailSendBccAccount
    /// </summary>
    public partial class EmailSendBccAccountDAL
    {
        public EmailSendBccAccountDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string EmailSendBccAccountID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from EmailSendBccAccount");
            strSql.Append(" where EmailSendBccAccountID=@EmailSendBccAccountID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendBccAccountID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailSendBccAccountID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailSendBccAccount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into EmailSendBccAccount(");
            strSql.Append("EmailSendBccAccountID,EmailID,EmailBccAccountID,EmailAccountID,EmailSendBccAccountState,EmailSendBccAccountCreateTime,EmailSendBccAccountLastTime)");
            strSql.Append(" values (");
            strSql.Append("@EmailSendBccAccountID,@EmailID,@EmailBccAccountID,@EmailAccountID,@EmailSendBccAccountState,@EmailSendBccAccountCreateTime,@EmailSendBccAccountLastTime)");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendBccAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailBccAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailSendBccAccountState", SqlDbType.Int),
					new SqlParameter("@EmailSendBccAccountCreateTime", SqlDbType.DateTime),
					new SqlParameter("@EmailSendBccAccountLastTime", SqlDbType.DateTime)};
            parameters[0].Value = model.EmailSendBccAccountID;
            parameters[1].Value = model.EmailID;
            parameters[2].Value = model.EmailBccAccountID;
            parameters[3].Value = model.EmailAccountID;
            parameters[4].Value = model.EmailSendBccAccountState;
            parameters[5].Value = model.EmailSendBccAccountCreateTime;
            parameters[6].Value = model.EmailSendBccAccountLastTime;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Panther.Email.Entity.Model.EmailSendBccAccount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailSendBccAccount set ");
            strSql.Append("EmailID=@EmailID,");
            strSql.Append("EmailBccAccountID=@EmailBccAccountID,");
            strSql.Append("EmailAccountID=@EmailAccountID,");
            strSql.Append("EmailSendBccAccountState=@EmailSendBccAccountState,");
            strSql.Append("EmailSendBccAccountCreateTime=@EmailSendBccAccountCreateTime,");
            strSql.Append("EmailSendBccAccountLastTime=@EmailSendBccAccountLastTime,");
            strSql.Append("EmailSendBccAccountSendTIme=@EmailSendBccAccountSendTIme");
            strSql.Append(" where EmailSendBccAccountID=@EmailSendBccAccountID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailBccAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailSendBccAccountState", SqlDbType.Int),
					new SqlParameter("@EmailSendBccAccountCreateTime", SqlDbType.DateTime),
					new SqlParameter("@EmailSendBccAccountLastTime", SqlDbType.DateTime),
					new SqlParameter("@EmailSendBccAccountSendTIme", SqlDbType.DateTime),
					new SqlParameter("@EmailSendBccAccountID", SqlDbType.VarChar,40)};
            parameters[0].Value = model.EmailID;
            parameters[1].Value = model.EmailBccAccountID;
            parameters[2].Value = model.EmailAccountID;
            parameters[3].Value = model.EmailSendBccAccountState;
            parameters[4].Value = model.EmailSendBccAccountCreateTime;
            parameters[5].Value = model.EmailSendBccAccountLastTime;
            parameters[6].Value = model.EmailSendBccAccountSendTIme;
            parameters[7].Value = model.EmailSendBccAccountID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string EmailSendBccAccountID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailSendBccAccount ");
            strSql.Append(" where EmailSendBccAccountID=@EmailSendBccAccountID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendBccAccountID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailSendBccAccountID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除数据根据EmailID
        /// </summary>
        public bool DeleteByEmailID(string EmailID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailSendBccAccount ");
            strSql.Append(" where EmailID=@EmailID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string EmailSendBccAccountIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailSendBccAccount ");
            strSql.Append(" where EmailSendBccAccountID in (" + EmailSendBccAccountIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailSendBccAccount GetModel(string EmailSendBccAccountID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EmailSendBccAccountID,EmailID,EmailBccAccountID,EmailAccountID,EmailSendBccAccountState,EmailSendBccAccountCreateTime,EmailSendBccAccountLastTime,EmailSendBccAccountSendTIme from EmailSendBccAccount ");
            strSql.Append(" where EmailSendBccAccountID=@EmailSendBccAccountID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendBccAccountID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailSendBccAccountID;

            Panther.Email.Entity.Model.EmailSendBccAccount model = new Panther.Email.Entity.Model.EmailSendBccAccount();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailSendBccAccount DataRowToModel(DataRow row)
        {
            Panther.Email.Entity.Model.EmailSendBccAccount model = new Panther.Email.Entity.Model.EmailSendBccAccount();
            if (row != null)
            {
                if (row["EmailSendBccAccountID"] != null)
                {
                    model.EmailSendBccAccountID = row["EmailSendBccAccountID"].ToString();
                }
                if (row["EmailID"] != null)
                {
                    model.EmailID = row["EmailID"].ToString();
                }
                if (row["EmailBccAccountID"] != null)
                {
                    model.EmailBccAccountID = row["EmailBccAccountID"].ToString();
                }
                if (row["EmailAccountID"] != null)
                {
                    model.EmailAccountID = row["EmailAccountID"].ToString();
                }
                //model.EmailSendBccAccountState=row["EmailSendBccAccountState"].ToString();
                if (row["EmailSendBccAccountCreateTime"] != null && row["EmailSendBccAccountCreateTime"].ToString() != "")
                {
                    model.EmailSendBccAccountCreateTime = DateTime.Parse(row["EmailSendBccAccountCreateTime"].ToString());
                }
                if (row["EmailSendBccAccountLastTime"] != null && row["EmailSendBccAccountLastTime"].ToString() != "")
                {
                    model.EmailSendBccAccountLastTime = DateTime.Parse(row["EmailSendBccAccountLastTime"].ToString());
                }
                if (row["EmailSendBccAccountSendTIme"] != null && row["EmailSendBccAccountSendTIme"].ToString() != "")
                {
                    model.EmailSendBccAccountSendTIme = DateTime.Parse(row["EmailSendBccAccountSendTIme"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EmailSendBccAccountID,EmailID,EmailBccAccountID,EmailAccountID,EmailSendBccAccountState,EmailSendBccAccountCreateTime,EmailSendBccAccountLastTime,EmailSendBccAccountSendTIme ");
            strSql.Append(" FROM EmailSendBccAccount ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM EmailSendBccAccount ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.EmailSendBccAccountID desc");
            }
            strSql.Append(")AS Row, T.*  from EmailSendBccAccount T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Integer),
                    new SqlParameter("@PageIndex", SqlDbType.Integer),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "EmailSendBccAccount";
            parameters[1].Value = "EmailSendBccAccountID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

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
            List<Panther.Email.Entity.Model.EmailSendBccAccount> modelList = null;
            string strSql = string.Format(@"select top {0} esba.*,eba.EmailBccAccountAddress,eba.EmailBccAccountName from EmailSendBccAccount as esba inner join EmailBccAccount as eba on eba.EmailBccAccountID = esba.EmailBccAccountID where esba.EmailID = @EmailID and esba.EmailSendBccAccountState in (0) ", count);
            SqlParameter[] parameters = {
					new SqlParameter("@EmailID", SqlDbType.VarChar,40)};
            parameters[0].Value = emailID;
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRowCollection drc = ds.Tables[0].Rows;
                modelList = new List<Entity.Model.EmailSendBccAccount>();
                foreach (DataRow dr in drc)
                {
                    var model = DataRowToModelAndBcc(dr);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;

        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailSendBccAccount DataRowToModelAndBcc(DataRow row)
        {
            Panther.Email.Entity.Model.EmailSendBccAccount model = new Panther.Email.Entity.Model.EmailSendBccAccount();
            model.EmailBccAccountInfo = new Entity.Model.EmailBccAccount();
            if (row != null)
            {
                if (row["EmailSendBccAccountID"] != null)
                {
                    model.EmailSendBccAccountID = row["EmailSendBccAccountID"].ToString();
                }
                if (row["EmailID"] != null)
                {
                    model.EmailID = row["EmailID"].ToString();
                }
                if (row["EmailBccAccountID"] != null)
                {
                    model.EmailBccAccountID = row["EmailBccAccountID"].ToString();
                    model.EmailBccAccountInfo.EmailBccAccountID = model.EmailBccAccountID;
                }
                if (row["EmailAccountID"] != null)
                {
                    model.EmailAccountID = row["EmailAccountID"].ToString();
                }
                model.EmailSendBccAccountState = (int)(row["EmailSendBccAccountState"]);
                if (row["EmailSendBccAccountCreateTime"] != null && row["EmailSendBccAccountCreateTime"].ToString() != "")
                {
                    model.EmailSendBccAccountCreateTime = DateTime.Parse(row["EmailSendBccAccountCreateTime"].ToString());
                }
                if (row["EmailSendBccAccountLastTime"] != null && row["EmailSendBccAccountLastTime"].ToString() != "")
                {
                    model.EmailSendBccAccountLastTime = DateTime.Parse(row["EmailSendBccAccountLastTime"].ToString());
                }
                if (row["EmailSendBccAccountSendTIme"] != null && row["EmailSendBccAccountSendTIme"].ToString() != "")
                {
                    model.EmailSendBccAccountSendTIme = DateTime.Parse(row["EmailSendBccAccountSendTIme"].ToString());
                }
                if (row["EmailBccAccountAddress"] != null)
                {
                    model.EmailBccAccountInfo.EmailBccAccountAddress = row["EmailBccAccountAddress"].ToString();
                }
                if (row["EmailBccAccountName"] != null)
                {
                    model.EmailBccAccountInfo.EmailBccAccountName = row["EmailBccAccountName"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 修改发送状态，用于重新发送
        /// </summary>
        /// <param name="emailID">邮件ID</param>
        /// <param name="state">修改後的狀態1:已发送;0:未发送;-1:发送失败;2停止發送:发送失败;</param>
        /// <param name="type">修改的类型，1:已发送;0:未发送;-1:发送失败;2停止發送;空就是全部修改</param>
        /// <returns></returns>
        public bool UpdateSendState(string emailID, int state, string type = "")
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailSendBccAccount set ");
            strSql.Append("EmailSendBccAccountState=@EmailSendBccAccountState");
            strSql.Append(" where EmailID=@EmailID ");
            if (!string.IsNullOrEmpty(type))
            {
                strSql.Append(" and EmailSendBccAccountState in (" + type + ")  ");
            }
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendBccAccountState", SqlDbType.Int),
					new SqlParameter("@EmailID", SqlDbType.VarChar,40)};
            parameters[0].Value = state;
            parameters[1].Value = emailID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 刪除指定郵件和指定發送狀態的發送記錄
        /// </summary>
        /// <param name="emailID"></param>
        /// <param name="type">1:已发送;0:未发送;-1:发送失败;2停止發送;空就是全部刪除</param>
        /// <returns></returns>
        public bool DeleteByEmailID(string emailID, string type = "")
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailSendBccAccount ");
            strSql.Append(" where EmailID=@EmailID ");
            if (!string.IsNullOrEmpty(type))
            {
                strSql.Append(" and EmailSendBccAccountState in (" + type + ")  ");
            }
            SqlParameter[] parameters = {
					new SqlParameter("@EmailID", SqlDbType.VarChar,40)			};
            parameters[0].Value = emailID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 跟进SQL语句批量插入数据，执行SQL语句
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public bool ExecSql(string strSql)
        {
            if (string.IsNullOrEmpty(strSql))
            {
                return false;
            }
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion  ExtensionMethod
    }
}

