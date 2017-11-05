using System;
using System.Data;
using System.Data.SqlClient;//Please add references
using System.Text;
using Panther.Email.DataAccess.DbBase;

namespace Panther.Email.DataAccess
{
	/// <summary>
	/// 数据访问类:EmailSendFailure
	/// </summary>
	public partial class EmailSendFailureDAL
	{
		public EmailSendFailureDAL()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string EmailSendFailureID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from EmailSendFailure");
            strSql.Append(" where EmailSendFailureID=@EmailSendFailureID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendFailureID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailSendFailureID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailSendFailure model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into EmailSendFailure(");
            strSql.Append("EmailSendFailureID,EmailID,EmailBccAccountID,EmailAccountID,EmailSendFailureSendTime)");
            strSql.Append(" values (");
            strSql.Append("@EmailSendFailureID,@EmailID,@EmailBccAccountID,@EmailAccountID,@EmailSendFailureSendTime)");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendFailureID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailBccAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailSendFailureSendTime", SqlDbType.DateTime)};
            parameters[0].Value = model.EmailSendFailureID;
            parameters[1].Value = model.EmailID;
            parameters[2].Value = model.EmailBccAccountID;
            parameters[3].Value = model.EmailAccountID;
            parameters[4].Value = model.EmailSendFailureSendTime;

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
        public bool Update(Panther.Email.Entity.Model.EmailSendFailure model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailSendFailure set ");
            strSql.Append("EmailID=@EmailID,");
            strSql.Append("EmailBccAccountID=@EmailBccAccountID,");
            strSql.Append("EmailAccountID=@EmailAccountID,");
            strSql.Append("EmailSendFailureSendTime=@EmailSendFailureSendTime");
            strSql.Append(" where EmailSendFailureID=@EmailSendFailureID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailBccAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailSendFailureSendTime", SqlDbType.DateTime),
					new SqlParameter("@EmailSendFailureID", SqlDbType.VarChar,40)};
            parameters[0].Value = model.EmailID;
            parameters[1].Value = model.EmailBccAccountID;
            parameters[2].Value = model.EmailAccountID;
            parameters[3].Value = model.EmailSendFailureSendTime;
            parameters[4].Value = model.EmailSendFailureID;

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
        public bool Delete(string EmailSendFailureID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailSendFailure ");
            strSql.Append(" where EmailSendFailureID=@EmailSendFailureID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendFailureID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailSendFailureID;

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
        public bool DeleteList(string EmailSendFailureIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailSendFailure ");
            strSql.Append(" where EmailSendFailureID in (" + EmailSendFailureIDlist + ")  ");
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
        public Panther.Email.Entity.Model.EmailSendFailure GetModel(string EmailSendFailureID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EmailSendFailureID,EmailID,EmailBccAccountID,EmailAccountID,EmailSendFailureSendTime from EmailSendFailure ");
            strSql.Append(" where EmailSendFailureID=@EmailSendFailureID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendFailureID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailSendFailureID;

            Panther.Email.Entity.Model.EmailSendFailure model = new Panther.Email.Entity.Model.EmailSendFailure();
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
        public Panther.Email.Entity.Model.EmailSendFailure DataRowToModel(DataRow row)
        {
            Panther.Email.Entity.Model.EmailSendFailure model = new Panther.Email.Entity.Model.EmailSendFailure();
            if (row != null)
            {
                if (row["EmailSendFailureID"] != null)
                {
                    model.EmailSendFailureID = row["EmailSendFailureID"].ToString();
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
                if (row["EmailSendFailureSendTime"] != null && row["EmailSendFailureSendTime"].ToString() != "")
                {
                    model.EmailSendFailureSendTime = DateTime.Parse(row["EmailSendFailureSendTime"].ToString());
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
            strSql.Append("select EmailSendFailureID,EmailID,EmailBccAccountID,EmailAccountID,EmailSendFailureSendTime ");
            strSql.Append(" FROM EmailSendFailure ");
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
            strSql.Append("select count(1) FROM EmailSendFailure ");
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
                strSql.Append("order by T.EmailSendFailureID desc");
            }
            strSql.Append(")AS Row, T.*  from EmailSendFailure T ");
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
            parameters[0].Value = "EmailSendFailure";
            parameters[1].Value = "EmailSendFailureID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
	}
}

