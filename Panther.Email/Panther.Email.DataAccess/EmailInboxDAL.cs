using System;
using System.Data;
using System.Data.SqlClient;//Please add references
using System.Text;
using Panther.Email.DataAccess.DbBase;

namespace Panther.Email.DataAccess
{
	/// <summary>
	/// 数据访问类:EmailInbox
	/// </summary>
	public partial class EmailInboxDAL
	{
		public EmailInboxDAL()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string EmailInboxID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from EmailInbox");
            strSql.Append(" where EmailInboxID=@EmailInboxID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailInboxID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailInboxID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailInbox model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into EmailInbox(");
            strSql.Append("EmailInboxID,EmailServerUID,EmailInboxTitle,EmailInboxFrom,EmailInboxFromName,EmailInboxDate,EmailInboxFilePath,EmailInboxState,EmailInboxIsDel)");
            strSql.Append(" values (");
            strSql.Append("@EmailInboxID,@EmailServerUID,@EmailInboxTitle,@EmailInboxFrom,@EmailInboxFromName,@EmailInboxDate,@EmailInboxFilePath,@EmailInboxState,@EmailInboxIsDel)");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailInboxID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailServerUID", SqlDbType.VarChar,255),
					new SqlParameter("@EmailInboxTitle", SqlDbType.VarChar,255),
					new SqlParameter("@EmailInboxFrom", SqlDbType.VarChar,255),
					new SqlParameter("@EmailInboxFromName", SqlDbType.VarChar,255),
					new SqlParameter("@EmailInboxDate", SqlDbType.VarChar,255),
					new SqlParameter("@EmailInboxFilePath", SqlDbType.VarChar,255),
					new SqlParameter("@EmailInboxState", SqlDbType.Int),
					new SqlParameter("@EmailInboxIsDel", SqlDbType.Bit,1)};
            parameters[0].Value = model.EmailInboxID;
            parameters[1].Value = model.EmailServerUID;
            parameters[2].Value = model.EmailInboxTitle;
            parameters[3].Value = model.EmailInboxFrom;
            parameters[4].Value = model.EmailInboxFromName;
            parameters[5].Value = model.EmailInboxDate;
            parameters[6].Value = model.EmailInboxFilePath;
            parameters[7].Value = model.EmailInboxState;
            parameters[8].Value = model.EmailInboxIsDel;

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
        public bool Update(Panther.Email.Entity.Model.EmailInbox model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailInbox set ");
            strSql.Append("EmailServerUID=@EmailServerUID,");
            strSql.Append("EmailInboxTitle=@EmailInboxTitle,");
            strSql.Append("EmailInboxFrom=@EmailInboxFrom,");
            strSql.Append("EmailInboxFromName=@EmailInboxFromName,");
            strSql.Append("EmailInboxDate=@EmailInboxDate,");
            strSql.Append("EmailInboxFilePath=@EmailInboxFilePath,");
            strSql.Append("EmailInboxState=@EmailInboxState,");
            strSql.Append("EmailInboxIsDel=@EmailInboxIsDel");
            strSql.Append(" where EmailInboxID=@EmailInboxID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailServerUID", SqlDbType.VarChar,255),
					new SqlParameter("@EmailInboxTitle", SqlDbType.VarChar,255),
					new SqlParameter("@EmailInboxFrom", SqlDbType.VarChar,255),
					new SqlParameter("@EmailInboxFromName", SqlDbType.VarChar,255),
					new SqlParameter("@EmailInboxDate", SqlDbType.VarChar,255),
					new SqlParameter("@EmailInboxFilePath", SqlDbType.VarChar,255),
					new SqlParameter("@EmailInboxState", SqlDbType.Int),
					new SqlParameter("@EmailInboxIsDel", SqlDbType.Bit,1),
					new SqlParameter("@EmailInboxID", SqlDbType.VarChar,40)};
            parameters[0].Value = model.EmailServerUID;
            parameters[1].Value = model.EmailInboxTitle;
            parameters[2].Value = model.EmailInboxFrom;
            parameters[3].Value = model.EmailInboxFromName;
            parameters[4].Value = model.EmailInboxDate;
            parameters[5].Value = model.EmailInboxFilePath;
            parameters[6].Value = model.EmailInboxState;
            parameters[7].Value = model.EmailInboxIsDel;
            parameters[8].Value = model.EmailInboxID;

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
        public bool Delete(string EmailInboxID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailInbox ");
            strSql.Append(" where EmailInboxID=@EmailInboxID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailInboxID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailInboxID;

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
        public bool DeleteList(string EmailInboxIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailInbox ");
            strSql.Append(" where EmailInboxID in (" + EmailInboxIDlist + ")  ");
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
        public Panther.Email.Entity.Model.EmailInbox GetModel(string EmailInboxID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EmailInboxID,EmailServerUID,EmailInboxTitle,EmailInboxFrom,EmailInboxFromName,EmailInboxDate,EmailInboxFilePath,EmailInboxState,EmailInboxIsDel from EmailInbox ");
            strSql.Append(" where EmailInboxID=@EmailInboxID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailInboxID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailInboxID;

            Panther.Email.Entity.Model.EmailInbox model = new Panther.Email.Entity.Model.EmailInbox();
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
        public Panther.Email.Entity.Model.EmailInbox DataRowToModel(DataRow row)
        {
            Panther.Email.Entity.Model.EmailInbox model = new Panther.Email.Entity.Model.EmailInbox();
            if (row != null)
            {
                if (row["EmailInboxID"] != null)
                {
                    model.EmailInboxID = row["EmailInboxID"].ToString();
                }
                if (row["EmailServerUID"] != null)
                {
                    model.EmailServerUID = row["EmailServerUID"].ToString();
                }
                if (row["EmailInboxTitle"] != null)
                {
                    model.EmailInboxTitle = row["EmailInboxTitle"].ToString();
                }
                if (row["EmailInboxFrom"] != null)
                {
                    model.EmailInboxFrom = row["EmailInboxFrom"].ToString();
                }
                if (row["EmailInboxFromName"] != null)
                {
                    model.EmailInboxFromName = row["EmailInboxFromName"].ToString();
                }
                if (row["EmailInboxDate"] != null)
                {
                    model.EmailInboxDate = row["EmailInboxDate"].ToString();
                }
                if (row["EmailInboxFilePath"] != null)
                {
                    model.EmailInboxFilePath = row["EmailInboxFilePath"].ToString();
                }
                //model.EmailInboxState=row["EmailInboxState"].ToString();
                if (row["EmailInboxIsDel"] != null && row["EmailInboxIsDel"].ToString() != "")
                {
                    if ((row["EmailInboxIsDel"].ToString() == "1") || (row["EmailInboxIsDel"].ToString().ToLower() == "true"))
                    {
                        model.EmailInboxIsDel = true;
                    }
                    else
                    {
                        model.EmailInboxIsDel = false;
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
            strSql.Append("select EmailInboxID,EmailServerUID,EmailInboxTitle,EmailInboxFrom,EmailInboxFromName,EmailInboxDate,EmailInboxFilePath,EmailInboxState,EmailInboxIsDel ");
            strSql.Append(" FROM EmailInbox ");
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
            strSql.Append("select count(1) FROM EmailInbox ");
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
                strSql.Append("order by T.EmailInboxID desc");
            }
            strSql.Append(")AS Row, T.*  from EmailInbox T ");
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
            parameters[0].Value = "EmailInbox";
            parameters[1].Value = "EmailInboxID";
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

