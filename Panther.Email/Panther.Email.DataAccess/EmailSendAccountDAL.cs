using System;
using System.Data;
using System.Data.SqlClient;//Please add references
using System.Text;
using Panther.Email.DataAccess.DbBase;

namespace Panther.Email.DataAccess
{
    /// <summary>
    /// 数据访问类:EmailSendAccount
    /// </summary>
    public partial class EmailSendAccountDAL
    {
        public EmailSendAccountDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string EmailSendAccountID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from EmailSendAccount");
            strSql.Append(" where EmailSendAccountID=@EmailSendAccountID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendAccountID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailSendAccountID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailSendAccount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into EmailSendAccount(");
            strSql.Append("EmailSendAccountID,EmailID,EmailAccountID,EmailSendAccountCreateTime)");
            strSql.Append(" values (");
            strSql.Append("@EmailSendAccountID,@EmailID,@EmailAccountID,@EmailSendAccountCreateTime)");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailSendAccountCreateTime", SqlDbType.DateTime)};
            parameters[0].Value = model.EmailSendAccountID;
            parameters[1].Value = model.EmailID;
            parameters[2].Value = model.EmailAccountID;
            parameters[3].Value = model.EmailSendAccountCreateTime;

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
        public bool Update(Panther.Email.Entity.Model.EmailSendAccount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailSendAccount set ");
            strSql.Append("EmailID=@EmailID,");
            strSql.Append("EmailAccountID=@EmailAccountID,");
            strSql.Append("EmailSendAccountCreateTime=@EmailSendAccountCreateTime");
            strSql.Append(" where EmailSendAccountID=@EmailSendAccountID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailSendAccountCreateTime", SqlDbType.DateTime),
					new SqlParameter("@EmailSendAccountID", SqlDbType.VarChar,40)};
            parameters[0].Value = model.EmailID;
            parameters[1].Value = model.EmailAccountID;
            parameters[2].Value = model.EmailSendAccountCreateTime;
            parameters[3].Value = model.EmailSendAccountID;

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
        public bool Delete(string EmailSendAccountID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailSendAccount ");
            strSql.Append(" where EmailSendAccountID=@EmailSendAccountID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendAccountID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailSendAccountID;

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
            strSql.Append("delete from EmailSendAccount ");
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
        public bool DeleteList(string EmailSendAccountIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailSendAccount ");
            strSql.Append(" where EmailSendAccountID in (" + EmailSendAccountIDlist + ")  ");
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
        public Panther.Email.Entity.Model.EmailSendAccount GetModel(string EmailSendAccountID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EmailSendAccountID,EmailID,EmailAccountID,EmailSendAccountCreateTime from EmailSendAccount ");
            strSql.Append(" where EmailSendAccountID=@EmailSendAccountID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailSendAccountID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailSendAccountID;

            Panther.Email.Entity.Model.EmailSendAccount model = new Panther.Email.Entity.Model.EmailSendAccount();
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
        public Panther.Email.Entity.Model.EmailSendAccount DataRowToModel(DataRow row)
        {
            Panther.Email.Entity.Model.EmailSendAccount model = new Panther.Email.Entity.Model.EmailSendAccount();
            if (row != null)
            {
                if (row["EmailSendAccountID"] != null)
                {
                    model.EmailSendAccountID = row["EmailSendAccountID"].ToString();
                }
                if (row["EmailID"] != null)
                {
                    model.EmailID = row["EmailID"].ToString();
                }
                if (row["EmailAccountID"] != null)
                {
                    model.EmailAccountID = row["EmailAccountID"].ToString();
                }
                if (row["EmailSendAccountCreateTime"] != null && row["EmailSendAccountCreateTime"].ToString() != "")
                {
                    model.EmailSendAccountCreateTime = DateTime.Parse(row["EmailSendAccountCreateTime"].ToString());
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
            strSql.Append("select EmailSendAccountID,EmailID,EmailAccountID,EmailSendAccountCreateTime ");
            strSql.Append(" FROM EmailSendAccount ");
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
            strSql.Append("select count(1) FROM EmailSendAccount ");
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
                strSql.Append("order by T.EmailSendAccountID desc");
            }
            strSql.Append(")AS Row, T.*  from EmailSendAccount T ");
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
            parameters[0].Value = "EmailSendAccount";
            parameters[1].Value = "EmailSendAccountID";
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
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("SELECT TOP {0} * FROM ( ", endIndex - startIndex);
            strSql.AppendFormat(" SELECT TOP {0} {1}  from {2} ", endIndex, columns, tableSql);
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.AppendFormat(" WHERE {0} ", strWhere);
            }
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.AppendFormat(" order by {0} {1} ", orderby, orderType);
            }
            strSql.Append(" ) T ");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.AppendFormat(" order by {0} {1} ", orderby, orderType == "ASC" ? "DESC" : "ASC");
            }
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        /// <param name="tableSql">表名，可以是SQL</param>
        /// <param name="strWhere">查询条件</param>
        /// <returns></returns>
        public int GetRecordCount(string tableSql, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select count(1) FROM {0} ", tableSql);
            if (strWhere.Trim() != "")
            {
                strSql.AppendFormat(" where {0} ", strWhere);
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
        #endregion  ExtensionMethod
    }
}

