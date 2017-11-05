using System;
using System.Data;
using System.Data.SqlClient;//Please add references
using System.Text;
using Panther.Email.DataAccess.DbBase;
using Panther.Email.Entity.Model;
using System.Collections.Generic;

namespace Panther.Email.DataAccess
{
    /// <summary>
    /// 数据访问类:EmailInfo
    /// </summary>
    public partial class EmailInfoDAL
    {
        public EmailInfoDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string EmailID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from EmailInfo");
            strSql.Append(" where EmailID=@EmailID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into EmailInfo(");
            strSql.Append("EmailID,EmailTitle,EmailCreateTime,EmailLastTime,EmailFilePath,EmailIsDel,EmailState,EmailStartSendTime)");
            strSql.Append(" values (");
            strSql.Append("@EmailID,@EmailTitle,@EmailCreateTime,@EmailLastTime,@EmailFilePath,@EmailIsDel,@EmailState,@EmailStartSendTime)");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailTitle", SqlDbType.VarChar,0),
					new SqlParameter("@EmailCreateTime", SqlDbType.DateTime),
					new SqlParameter("@EmailLastTime", SqlDbType.DateTime),
					new SqlParameter("@EmailFilePath", SqlDbType.VarChar,0),
					new SqlParameter("@EmailIsDel", SqlDbType.Int,1),
					new SqlParameter("@EmailState", SqlDbType.Int),
					new SqlParameter("@EmailStartSendTime", SqlDbType.DateTime)};
            parameters[0].Value = model.EmailID;
            parameters[1].Value = model.EmailTitle;
            parameters[2].Value = model.EmailCreateTime;
            parameters[3].Value = model.EmailLastTime;
            parameters[4].Value = model.EmailFilePath;
            parameters[5].Value = model.EmailIsDel;
            parameters[6].Value = model.EmailState;
            parameters[7].Value = model.EmailStartSendTime;

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
        public bool Update(Panther.Email.Entity.Model.EmailInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailInfo set ");
            strSql.Append("EmailTitle=@EmailTitle,");
            strSql.Append("EmailCreateTime=@EmailCreateTime,");
            strSql.Append("EmailLastTime=@EmailLastTime,");
            strSql.Append("EmailFilePath=@EmailFilePath,");
            strSql.Append("EmailIsDel=@EmailIsDel,");
            strSql.Append("EmailState=@EmailState,");
            strSql.Append("EmailStartSendTime=@EmailStartSendTime");
            strSql.Append(" where EmailID=@EmailID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailTitle", SqlDbType.VarChar,0),
					new SqlParameter("@EmailCreateTime", SqlDbType.DateTime),
					new SqlParameter("@EmailLastTime", SqlDbType.DateTime),
					new SqlParameter("@EmailFilePath", SqlDbType.VarChar,0),
					new SqlParameter("@EmailIsDel", SqlDbType.Int,1),
					new SqlParameter("@EmailState", SqlDbType.Int),
					new SqlParameter("@EmailStartSendTime", SqlDbType.DateTime),
					new SqlParameter("@EmailID", SqlDbType.VarChar,40)};
            parameters[0].Value = model.EmailTitle;
            parameters[1].Value = model.EmailCreateTime;
            parameters[2].Value = model.EmailLastTime;
            parameters[3].Value = model.EmailFilePath;
            parameters[4].Value = model.EmailIsDel;
            parameters[5].Value = model.EmailState;
            parameters[6].Value = model.EmailStartSendTime;
            parameters[7].Value = model.EmailID;

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
        public bool Delete(string EmailID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailInfo ");
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
        public bool DeleteList(string EmailIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailInfo ");
            strSql.Append(" where EmailID in (" + EmailIDlist + ")  ");
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
        public Panther.Email.Entity.Model.EmailInfo GetModel(string EmailID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EmailID,EmailTitle,EmailCreateTime,EmailLastTime,EmailFilePath,EmailIsDel,EmailState,EmailStartSendTime from EmailInfo ");
            strSql.Append(" where EmailID=@EmailID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailID", SqlDbType.VarChar,40)			};
            parameters[0].Value = EmailID;

            Panther.Email.Entity.Model.EmailInfo model = new Panther.Email.Entity.Model.EmailInfo();
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
        public Panther.Email.Entity.Model.EmailInfo DataRowToModel(DataRow row)
        {
            Panther.Email.Entity.Model.EmailInfo model = new Panther.Email.Entity.Model.EmailInfo();
            if (row != null)
            {
                if (row["EmailID"] != null)
                {
                    model.EmailID = row["EmailID"].ToString();
                }
                if (row["EmailTitle"] != null)
                {
                    model.EmailTitle = row["EmailTitle"].ToString();
                }
                if (row["EmailCreateTime"] != null && row["EmailCreateTime"].ToString() != "")
                {
                    model.EmailCreateTime = DateTime.Parse(row["EmailCreateTime"].ToString());
                }
                if (row["EmailLastTime"] != null && row["EmailLastTime"].ToString() != "")
                {
                    model.EmailLastTime = DateTime.Parse(row["EmailLastTime"].ToString());
                }
                if (row["EmailFilePath"] != null)
                {
                    model.EmailFilePath = row["EmailFilePath"].ToString();
                }
                if (row["EmailIsDel"] != null && row["EmailIsDel"].ToString() != "")
                {
                    if ((row["EmailIsDel"].ToString() == "1") || (row["EmailIsDel"].ToString().ToLower() == "true"))
                    {
                        model.EmailIsDel = true;
                    }
                    else
                    {
                        model.EmailIsDel = false;
                    }
                }
                //model.EmailState=row["EmailState"].ToString();
                if (row["EmailStartSendTime"] != null && row["EmailStartSendTime"].ToString() != "")
                {
                    model.EmailStartSendTime = DateTime.Parse(row["EmailStartSendTime"].ToString());
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
            strSql.Append("select EmailID,EmailTitle,EmailCreateTime,EmailLastTime,EmailFilePath,EmailIsDel,EmailState,EmailStartSendTime ");
            strSql.Append(" FROM EmailInfo ");
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
            strSql.Append("select count(1) FROM EmailInfo ");
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
                strSql.Append("order by T.EmailID desc");
            }
            strSql.Append(")AS Row, T.*  from EmailInfo T ");
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
                    new SqlParameter("@IsReCount", SqlDbType.Int),
                    new SqlParameter("@OrderType", SqlDbType.Int),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "EmailInfo";
            parameters[1].Value = "EmailID";
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
        /// 得到一个最早的待发送的邮件
        /// </summary>
        public Panther.Email.Entity.Model.EmailInfo GetNextEmailModel()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select EmailID,EmailTitle,EmailCreateTime,EmailLastTime,EmailFilePath,EmailIsDel,EmailState,EmailStartSendTime from EmailInfo where EmailState = 0 and EmailStartSendTime < getdate() and EmailIsDel = 0 and EmailID in (select EmailSendAccount.EmailID from EmailSendAccount where  EmailSendAccount.EmailAccountID in (select EmailAccountID from EmailAccount where EmailAccount.EmailAccountRemainEmailCount>0 and EmailAccount.EmailAccountLastTime<getdate() and EmailAccount.SendState = 0 ) ) order by EmailStartSendTime ");

            Panther.Email.Entity.Model.EmailInfo model = new Panther.Email.Entity.Model.EmailInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
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
        /// 得到待发送的邮件列表
        /// </summary>
        public List<EmailInfo> GetSendEmailListModel()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select EmailID,EmailTitle,EmailCreateTime,EmailLastTime,EmailFilePath,EmailIsDel,EmailState,EmailStartSendTime from EmailInfo where EmailState = 0 and EmailStartSendTime < getdate() and EmailIsDel = 0 and EmailID in (select EmailSendAccount.EmailID from EmailSendAccount where  EmailSendAccount.EmailAccountID in (select EmailAccountID from EmailAccount where EmailAccount.EmailAccountRemainEmailCount>0 and EmailAccount.EmailAccountLastTime<getdate() and EmailAccount.SendState = 0 ) ) order by EmailStartSendTime ");

            Panther.Email.Entity.Model.EmailInfo model = new Panther.Email.Entity.Model.EmailInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds == null || ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
            {
                return null;
            }
            List<EmailInfo> emailList = new List<EmailInfo>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                emailList.Add(DataRowToModel(dr));
            }
            return emailList;
        }

        /// <summary>
        /// 更新邮件发送状态
        /// </summary>
        /// <param name="emailID">郵件ID</param>
        /// <param name="state">狀態0:启动发送;1:发送完毕;2:草稿</param>
        /// <returns></returns>
        public bool UpdateEmailState(string emailID,int state)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailInfo set ");
            strSql.Append("EmailLastTime=@EmailLastTime,");
            strSql.Append("EmailState=@EmailState");
            strSql.Append(" where EmailID=@EmailID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailLastTime", SqlDbType.DateTime),
					new SqlParameter("@EmailState", SqlDbType.Int),
					new SqlParameter("@EmailID", SqlDbType.VarChar,40)};
            parameters[0].Value = DateTime.Now;
            parameters[1].Value = state;
            parameters[2].Value = emailID;

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
        #endregion  ExtensionMethod
    }
}

