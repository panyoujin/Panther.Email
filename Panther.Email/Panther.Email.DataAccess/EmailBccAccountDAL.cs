using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text;
using Panther.Email.DataAccess.DbBase;

namespace Panther.Email.DataAccess
{
    /// <summary>
    /// 数据访问类:EmailBccAccount
    /// </summary>
    public partial class EmailBccAccountDAL
    {
        public EmailBccAccountDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string EmailBccAccountID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from EmailBccAccount");
            strSql.Append(" where EmailBccAccountID=@EmailBccAccountID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailBccAccountID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailBccAccountID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在該郵箱
        /// </summary>
        /// <param name="emailStr"></param>
        /// <returns></returns>
        public bool ExistsEmail(string emailStr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from EmailBccAccount");
            strSql.Append(" where EmailBccAccountAddress=@EmailBccAccountAddress ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailBccAccountAddress", SqlDbType.VarChar,40)			};
            parameters[0].Value = emailStr;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailBccAccount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into EmailBccAccount(");
            strSql.Append("EmailBccAccountID,EmailBccAccountAddress,EmailBccAccountName,EmailBccAccountCreateTime,EmailBccAccountLastTime,EmailBccAccountIsDel)");
            strSql.Append(" values (");
            strSql.Append("@EmailBccAccountID,@EmailBccAccountAddress,@EmailBccAccountName,@EmailBccAccountCreateTime,@EmailBccAccountLastTime,@EmailBccAccountIsDel)");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailBccAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailBccAccountAddress", SqlDbType.VarChar,1000),
					new SqlParameter("@EmailBccAccountName", SqlDbType.VarChar,255),
					new SqlParameter("@EmailBccAccountCreateTime", SqlDbType.DateTime),
					new SqlParameter("@EmailBccAccountLastTime", SqlDbType.DateTime),
					new SqlParameter("@EmailBccAccountIsDel", SqlDbType.Bit,1)};
            parameters[0].Value = model.EmailBccAccountID;
            parameters[1].Value = model.EmailBccAccountAddress;
            parameters[2].Value = model.EmailBccAccountName ?? "";
            parameters[3].Value = model.EmailBccAccountCreateTime;
            parameters[4].Value = model.EmailBccAccountLastTime;
            parameters[5].Value = model.EmailBccAccountIsDel;

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
        public bool Update(Panther.Email.Entity.Model.EmailBccAccount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailBccAccount set ");
            strSql.Append("EmailBccAccountAddress=@EmailBccAccountAddress,");
            strSql.Append("EmailBccAccountName=@EmailBccAccountName,");
            strSql.Append("EmailBccAccountCreateTime=@EmailBccAccountCreateTime,");
            strSql.Append("EmailBccAccountLastTime=@EmailBccAccountLastTime,");
            strSql.Append("EmailBccAccountIsDel=@EmailBccAccountIsDel");
            strSql.Append(" where EmailBccAccountID=@EmailBccAccountID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailBccAccountAddress", SqlDbType.VarChar,1000),
					new SqlParameter("@EmailBccAccountName", SqlDbType.VarChar,255),
					new SqlParameter("@EmailBccAccountCreateTime", SqlDbType.DateTime),
					new SqlParameter("@EmailBccAccountLastTime", SqlDbType.DateTime),
					new SqlParameter("@EmailBccAccountIsDel", SqlDbType.Bit,1),
					new SqlParameter("@EmailBccAccountID", SqlDbType.VarChar,40)};
            parameters[0].Value = model.EmailBccAccountAddress;
            parameters[1].Value = model.EmailBccAccountName;
            parameters[2].Value = model.EmailBccAccountCreateTime;
            parameters[3].Value = model.EmailBccAccountLastTime;
            parameters[4].Value = model.EmailBccAccountIsDel;
            parameters[5].Value = model.EmailBccAccountID;

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
        /// 更新收件人名称
        /// </summary>
        public bool UpdateName(string oldName, string newName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailBccAccount set ");
            strSql.Append(string.Format("EmailBccAccountName='{0}'", newName));
            strSql.Append(string.Format(" where EmailBccAccountName='{0}'", oldName));

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
        /// 删除一条数据
        /// </summary>
        public bool DeleteByEmailID(string EmailID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailBccAccount ");
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
        /// 删除一条数据
        /// </summary>
        public bool DeleteByMailAddress(string EmailBccAccountAddress)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailBccAccount ");
            strSql.Append(" where EmailBccAccountAddress=@EmailBccAccountAddress ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailBccAccountAddress", SqlDbType.VarChar,1000)			};
            parameters[0].Value = EmailBccAccountAddress;

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

        public bool DeleteBymailAddressMore(string EmailBccAccountAddressStr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailBccAccount ");
            strSql.Append(" where EmailBccAccountAddress in (" + EmailBccAccountAddressStr + ")");
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string EmailBccAccountID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailBccAccount ");
            strSql.Append(" where EmailBccAccountID=@EmailBccAccountID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailBccAccountID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailBccAccountID;

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
        public bool DeleteList(string EmailBccAccountIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailBccAccount ");
            strSql.Append(" where EmailBccAccountID in (" + EmailBccAccountIDlist + ")  ");
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
        public Panther.Email.Entity.Model.EmailBccAccount GetModel(string EmailBccAccountID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EmailBccAccountID,EmailBccAccountAddress,EmailBccAccountName,EmailBccAccountCreateTime,EmailBccAccountLastTime,EmailBccAccountIsDel from EmailBccAccount ");
            strSql.Append(" where EmailBccAccountID=@EmailBccAccountID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailBccAccountID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailBccAccountID;

            Panther.Email.Entity.Model.EmailBccAccount model = new Panther.Email.Entity.Model.EmailBccAccount();
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
        public Panther.Email.Entity.Model.EmailBccAccount DataRowToModel(DataRow row)
        {
            Panther.Email.Entity.Model.EmailBccAccount model = new Panther.Email.Entity.Model.EmailBccAccount();
            if (row != null)
            {
                if (row["EmailBccAccountID"] != null)
                {
                    model.EmailBccAccountID = row["EmailBccAccountID"].ToString();
                }
                if (row["EmailBccAccountAddress"] != null)
                {
                    model.EmailBccAccountAddress = row["EmailBccAccountAddress"].ToString();
                }
                if (row["EmailBccAccountName"] != null)
                {
                    model.EmailBccAccountName = row["EmailBccAccountName"].ToString();
                }
                if (row["EmailBccAccountCreateTime"] != null && row["EmailBccAccountCreateTime"].ToString() != "")
                {
                    model.EmailBccAccountCreateTime = DateTime.Parse(row["EmailBccAccountCreateTime"].ToString());
                }
                if (row["EmailBccAccountLastTime"] != null && row["EmailBccAccountLastTime"].ToString() != "")
                {
                    model.EmailBccAccountLastTime = DateTime.Parse(row["EmailBccAccountLastTime"].ToString());
                }
                if (row["EmailBccAccountIsDel"] != null && row["EmailBccAccountIsDel"].ToString() != "")
                {
                    if ((row["EmailBccAccountIsDel"].ToString() == "1") || (row["EmailBccAccountIsDel"].ToString().ToLower() == "true"))
                    {
                        model.EmailBccAccountIsDel = true;
                    }
                    else
                    {
                        model.EmailBccAccountIsDel = false;
                    }
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
            strSql.Append("select EmailBccAccountID,EmailBccAccountAddress,EmailBccAccountName,EmailBccAccountCreateTime,EmailBccAccountLastTime,EmailBccAccountIsDel ");
            strSql.Append(" FROM EmailBccAccount ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere, int start, int end)
        {
            StringBuilder strSql = new StringBuilder();
            string strWhe = "";
            if (strWhere.Trim() != "")
            {
                strWhe = " where " + strWhere;
            }
            strSql.AppendFormat("select TOP {0} * FROM (select TOP {1}  EmailBccAccountID,EmailBccAccountAddress,EmailBccAccountName,EmailBccAccountCreateTime,EmailBccAccountLastTime,EmailBccAccountIsDel FROM EmailBccAccount  {2} order by EmailBccAccountCreateTime desc ) as temp", end - start, end, strWhe);
            
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM EmailBccAccount ");
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
                strSql.Append("order by T.EmailBccAccountID desc");
            }
            strSql.Append(")AS Row, T.*  from EmailBccAccount T ");
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
            parameters[0].Value = "EmailBccAccount";
            parameters[1].Value = "EmailBccAccountID";
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

