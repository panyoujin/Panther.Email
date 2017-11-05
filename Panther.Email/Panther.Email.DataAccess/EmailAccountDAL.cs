using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text;
using Panther.Email.DataAccess.DbBase;

namespace Panther.Email.DataAccess
{
    /// <summary>
    /// 数据访问类:EmailAccount
    /// </summary>
    public partial class EmailAccountDAL
    {
        public EmailAccountDAL()
        { }
        #region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Panther.Email.Entity.Model.EmailAccount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into EmailAccount(");
            strSql.Append("EmailAccountID,EmailAccountAddress,EmailAccountPassWord,EmailAccountName,EmailAccountSMTP,EmailAccountSMTPPort,EmailAccountPOP3,EmailAccountPOP3Port,EmailAccountIsSSL,EmailAccountMaxEmailCount,EmailAccountRemainEmailCount,EmailAccountSpace,EmailAccountCreateTime,EmailAccountLastTime,SendState,SendMode)");
            strSql.Append(" values (");
            strSql.Append("@EmailAccountID,@EmailAccountAddress,@EmailAccountPassWord,@EmailAccountName,@EmailAccountSMTP,@EmailAccountSMTPPort,@EmailAccountPOP3,@EmailAccountPOP3Port,@EmailAccountIsSSL,@EmailAccountMaxEmailCount,@EmailAccountRemainEmailCount,@EmailAccountSpace,@EmailAccountCreateTime,@EmailAccountLastTime,0,@SendMode)");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailAccountAddress", SqlDbType.VarChar,0),
					new SqlParameter("@EmailAccountPassWord", SqlDbType.VarChar,255),
					new SqlParameter("@EmailAccountName", SqlDbType.VarChar,255),
					new SqlParameter("@EmailAccountSMTP", SqlDbType.VarChar,255),
					new SqlParameter("@EmailAccountSMTPPort", SqlDbType.Int),
					new SqlParameter("@EmailAccountPOP3", SqlDbType.VarChar,255),
					new SqlParameter("@EmailAccountPOP3Port", SqlDbType.Int),
					new SqlParameter("@EmailAccountIsSSL", SqlDbType.Bit,1),
					new SqlParameter("@EmailAccountMaxEmailCount", SqlDbType.Int),
					new SqlParameter("@EmailAccountRemainEmailCount", SqlDbType.Int),
					new SqlParameter("@EmailAccountSpace", SqlDbType.Int),
					new SqlParameter("@EmailAccountCreateTime", SqlDbType.Date),
					new SqlParameter("@EmailAccountLastTime", SqlDbType.Date),
					new SqlParameter("@SendMode", SqlDbType.Int)};
            parameters[0].Value = model.EmailAccountID;
            parameters[1].Value = model.EmailAccountAddress;
            parameters[2].Value = model.EmailAccountPassWord;
            parameters[3].Value = model.EmailAccountName == null ? "" : model.EmailAccountName;
            parameters[4].Value = model.EmailAccountSMTP == null ? "" : model.EmailAccountSMTP;
            parameters[5].Value = model.EmailAccountSMTPPort;
            parameters[6].Value = model.EmailAccountPOP3 == null ? "" : model.EmailAccountPOP3;
            parameters[7].Value = model.EmailAccountPOP3Port;
            parameters[8].Value = model.EmailAccountIsSSL;
            parameters[9].Value = model.EmailAccountMaxEmailCount;
            parameters[10].Value = model.EmailAccountMaxEmailCount;
            parameters[11].Value = model.EmailAccountSpace;
            parameters[12].Value = model.EmailAccountCreateTime;
            parameters[13].Value = model.EmailAccountLastTime;
            parameters[14].Value = model.SendMode;

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
        public bool Update(Panther.Email.Entity.Model.EmailAccount model, bool isupdate)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailAccount set ");
            strSql.Append("EmailAccountAddress=@EmailAccountAddress,");
            strSql.Append("EmailAccountPassWord=@EmailAccountPassWord,");
            strSql.Append("EmailAccountName=@EmailAccountName,");
            strSql.Append("EmailAccountSMTP=@EmailAccountSMTP,");
            strSql.Append("EmailAccountSMTPPort=@EmailAccountSMTPPort,");
            strSql.Append("EmailAccountPOP3=@EmailAccountPOP3,");
            strSql.Append("EmailAccountPOP3Port=@EmailAccountPOP3Port,");
            strSql.Append("EmailAccountIsSSL=@EmailAccountIsSSL,");
            strSql.Append("EmailAccountMaxEmailCount=@EmailAccountMaxEmailCount,");
            strSql.Append("EmailAccountRemainEmailCount=@EmailAccountRemainEmailCount,");
            strSql.Append("EmailAccountSpace=@EmailAccountSpace,");
            strSql.Append("EmailAccountCreateTime=@EmailAccountCreateTime,");
            //strSql.Append("EmailAccountLastTime=@EmailAccountLastTime,");
            strSql.Append("SendState=0,");
            strSql.Append("SendMode=@SendMode ");
            strSql.Append(" where EmailAccountID=@EmailAccountID");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailAccountAddress", SqlDbType.VarChar,1000),
					new SqlParameter("@EmailAccountPassWord", SqlDbType.VarChar,255),
					new SqlParameter("@EmailAccountName", SqlDbType.VarChar,255),
					new SqlParameter("@EmailAccountSMTP", SqlDbType.VarChar,255),
					new SqlParameter("@EmailAccountSMTPPort", SqlDbType.Int),
					new SqlParameter("@EmailAccountPOP3", SqlDbType.VarChar,255),
					new SqlParameter("@EmailAccountPOP3Port", SqlDbType.Int),
					new SqlParameter("@EmailAccountIsSSL", SqlDbType.Bit,1),
					new SqlParameter("@EmailAccountMaxEmailCount", SqlDbType.Int),
					new SqlParameter("@EmailAccountRemainEmailCount", SqlDbType.Int),
					new SqlParameter("@EmailAccountSpace", SqlDbType.Int),
					new SqlParameter("@EmailAccountCreateTime", SqlDbType.DateTime),
					//new SqlParameter("@EmailAccountLastTime", SqlDbType.DateTime),
					new SqlParameter("@SendMode", SqlDbType.Int),
					new SqlParameter("@EmailAccountID", SqlDbType.VarChar,40)};
            parameters[0].Value = model.EmailAccountAddress;
            parameters[1].Value = model.EmailAccountPassWord;
            parameters[2].Value = model.EmailAccountName;
            parameters[3].Value = model.EmailAccountSMTP;
            parameters[4].Value = model.EmailAccountSMTPPort;
            parameters[5].Value = model.EmailAccountPOP3;
            parameters[6].Value = model.EmailAccountPOP3Port;
            parameters[7].Value = model.EmailAccountIsSSL;
            parameters[8].Value = model.EmailAccountMaxEmailCount;
            parameters[9].Value = model.EmailAccountRemainEmailCount;
            parameters[10].Value = model.EmailAccountSpace;
            parameters[11].Value = model.EmailAccountCreateTime;
            //parameters[12].Value = model.EmailAccountLastTime;
            parameters[12].Value = model.SendMode;
            parameters[13].Value = model.EmailAccountID;

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
        public bool Update(Panther.Email.Entity.Model.EmailAccount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailAccount set ");
            strSql.Append("EmailAccountAddress=@EmailAccountAddress,");
            strSql.Append("EmailAccountPassWord=@EmailAccountPassWord,");
            strSql.Append("EmailAccountName=@EmailAccountName,");
            strSql.Append("EmailAccountSMTP=@EmailAccountSMTP,");
            strSql.Append("EmailAccountSMTPPort=@EmailAccountSMTPPort,");
            strSql.Append("EmailAccountPOP3=@EmailAccountPOP3,");
            strSql.Append("EmailAccountPOP3Port=@EmailAccountPOP3Port,");
            strSql.Append("EmailAccountIsSSL=@EmailAccountIsSSL,");
            strSql.Append("EmailAccountMaxEmailCount=@EmailAccountMaxEmailCount,");
            strSql.Append("EmailAccountRemainEmailCount=@EmailAccountRemainEmailCount,");
            strSql.Append("EmailAccountSpace=@EmailAccountSpace,");
            strSql.Append("EmailAccountCreateTime=@EmailAccountCreateTime,");
            strSql.Append("EmailAccountLastTime=@EmailAccountLastTime,");
            strSql.Append("SendState=0,");
            strSql.Append("SendMode=@SendMode ");
            strSql.Append(" where EmailAccountID=@EmailAccountID");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailAccountAddress", SqlDbType.VarChar,1000),
					new SqlParameter("@EmailAccountPassWord", SqlDbType.VarChar,255),
					new SqlParameter("@EmailAccountName", SqlDbType.VarChar,255),
					new SqlParameter("@EmailAccountSMTP", SqlDbType.VarChar,255),
					new SqlParameter("@EmailAccountSMTPPort", SqlDbType.Int),
					new SqlParameter("@EmailAccountPOP3", SqlDbType.VarChar,255),
					new SqlParameter("@EmailAccountPOP3Port", SqlDbType.Int),
					new SqlParameter("@EmailAccountIsSSL", SqlDbType.Bit,1),
					new SqlParameter("@EmailAccountMaxEmailCount", SqlDbType.Int),
					new SqlParameter("@EmailAccountRemainEmailCount", SqlDbType.Int),
					new SqlParameter("@EmailAccountSpace", SqlDbType.Int),
					new SqlParameter("@EmailAccountCreateTime", SqlDbType.DateTime),
					new SqlParameter("@EmailAccountLastTime", SqlDbType.DateTime),
					new SqlParameter("@SendMode", SqlDbType.Int),
					new SqlParameter("@EmailAccountID", SqlDbType.VarChar,40)};
            parameters[0].Value = model.EmailAccountAddress;
            parameters[1].Value = model.EmailAccountPassWord;
            parameters[2].Value = model.EmailAccountName;
            parameters[3].Value = model.EmailAccountSMTP;
            parameters[4].Value = model.EmailAccountSMTPPort;
            parameters[5].Value = model.EmailAccountPOP3;
            parameters[6].Value = model.EmailAccountPOP3Port;
            parameters[7].Value = model.EmailAccountIsSSL;
            parameters[8].Value = model.EmailAccountMaxEmailCount;
            parameters[9].Value = model.EmailAccountRemainEmailCount;
            parameters[10].Value = model.EmailAccountSpace;
            parameters[11].Value = model.EmailAccountCreateTime;
            parameters[12].Value = model.EmailAccountLastTime;
            parameters[13].Value = model.SendMode;
            parameters[14].Value = model.EmailAccountID;

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
        public bool Delete(string emailAccountID)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmailAccount ");
            strSql.Append(" where EmailAccountID=@EmailAccountID");
            SqlParameter[] parameters = {
               new SqlParameter("@EmailAccountID", SqlDbType.VarChar,40)
			};
            parameters[0].Value = emailAccountID;

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
        /// 得到一个对象实体
        /// </summary>
        public Panther.Email.Entity.Model.EmailAccount GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EmailAccountID,EmailAccountAddress,EmailAccountPassWord,EmailAccountName,EmailAccountSMTP,EmailAccountSMTPPort,EmailAccountPOP3,EmailAccountPOP3Port,EmailAccountIsSSL,EmailAccountMaxEmailCount,EmailAccountRemainEmailCount,EmailAccountSpace,EmailAccountCreateTime,EmailAccountLastTime,SendMode,SendState from EmailAccount ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
			};

            Panther.Email.Entity.Model.EmailAccount model = new Panther.Email.Entity.Model.EmailAccount();
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
        public Panther.Email.Entity.Model.EmailAccount DataRowToModel(DataRow row)
        {
            Panther.Email.Entity.Model.EmailAccount model = new Panther.Email.Entity.Model.EmailAccount();
            if (row != null)
            {
                if (row["EmailAccountID"] != null)
                {
                    model.EmailAccountID = row["EmailAccountID"].ToString();
                }
                if (row["EmailAccountAddress"] != null)
                {
                    model.EmailAccountAddress = row["EmailAccountAddress"].ToString();
                }
                if (row["EmailAccountPassWord"] != null)
                {
                    model.EmailAccountPassWord = row["EmailAccountPassWord"].ToString();
                }
                if (row["EmailAccountName"] != null)
                {
                    model.EmailAccountName = row["EmailAccountName"].ToString();
                }
                if (row["EmailAccountSMTP"] != null)
                {
                    model.EmailAccountSMTP = row["EmailAccountSMTP"].ToString();
                }
                if (row["EmailAccountSMTPPort"] != null)
                {
                    model.EmailAccountSMTPPort = (int)(row["EmailAccountSMTPPort"]);
                }
                if (row["EmailAccountPOP3"] != null)
                {
                    model.EmailAccountPOP3 = row["EmailAccountPOP3"].ToString();
                }
                if (row["EmailAccountPOP3Port"] != null)
                {
                    model.EmailAccountPOP3Port = (int)(row["EmailAccountPOP3Port"]);
                }
                if (row["SendState"] != null)
                {
                    model.SendState = (int)(row["SendState"]);
                }
                if (row["SendMode"] != null)
                {
                    model.SendMode = (int)(row["SendMode"]);
                }
                if (row["EmailAccountIsSSL"] != null && row["EmailAccountIsSSL"].ToString() != "")
                {
                    if ((row["EmailAccountIsSSL"].ToString() == "1") || (row["EmailAccountIsSSL"].ToString().ToLower() == "true"))
                    {
                        model.EmailAccountIsSSL = true;
                    }
                    else
                    {
                        model.EmailAccountIsSSL = false;
                    }
                }
                model.EmailAccountMaxEmailCount = (int)(row["EmailAccountMaxEmailCount"]);
                model.EmailAccountRemainEmailCount = (int)(row["EmailAccountRemainEmailCount"]);
                model.EmailAccountSpace = (int)(row["EmailAccountSpace"]);
                if (row["EmailAccountCreateTime"] != null && row["EmailAccountCreateTime"].ToString() != "")
                {
                    model.EmailAccountCreateTime = DateTime.Parse(row["EmailAccountCreateTime"].ToString());
                }
                if (row["EmailAccountLastTime"] != null && row["EmailAccountLastTime"].ToString() != "")
                {
                    model.EmailAccountLastTime = DateTime.Parse(row["EmailAccountLastTime"].ToString());
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
            strSql.Append("select EmailAccountID,EmailAccountAddress,EmailAccountPassWord,EmailAccountName,EmailAccountSMTP,EmailAccountSMTPPort,EmailAccountPOP3,EmailAccountPOP3Port,EmailAccountIsSSL,EmailAccountMaxEmailCount,EmailAccountRemainEmailCount,EmailAccountSpace,EmailAccountCreateTime,EmailAccountLastTime,SendMode,SendState ");
            strSql.Append(" FROM EmailAccount ");
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
            strSql.Append("select count(1) FROM EmailAccount ");
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
                strSql.Append("order by T. desc");
            }
            strSql.Append(")AS Row, T.*  from EmailAccount T ");
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
            parameters[0].Value = "EmailAccount";
            parameters[1].Value = "";
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
        /// 更加邮件ID获取所有有空闲的邮箱信息
        /// </summary>
        /// <param name="emailID"></param>
        /// <returns></returns>
        public DataSet GetEmailAccounts(string emailID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EmailAccountID,EmailAccountAddress,EmailAccountPassWord,EmailAccountName,EmailAccountSMTP,EmailAccountSMTPPort,EmailAccountPOP3,EmailAccountPOP3Port,EmailAccountIsSSL,EmailAccountMaxEmailCount,EmailAccountRemainEmailCount,EmailAccountSpace,EmailAccountCreateTime,EmailAccountLastTime,SendMode,SendState ");
            strSql.Append(" FROM EmailAccount ");

            strSql.Append(@" where  EmailAccount.EmailAccountRemainEmailCount>0 and EmailAccount.EmailAccountLastTime<getdate()  and EmailAccount.SendState = 0 
 and EmailAccountID in (select EmailSendAccount.EmailAccountID from EmailSendAccount where  EmailSendAccount.EmailID =@EmailID )");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailID", SqlDbType.VarChar,40)};
            parameters[0].Value = emailID;
            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }

        public bool IsExists(string emailAddress)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from EmailAccount where EmailAccountAddress=@EmailAccountAddress");
            SqlParameter[] parameters = { new SqlParameter("@EmailAccountAddress", SqlDbType.VarChar, 1000) };
            parameters[0].Value = emailAddress;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool UpdateTime(Panther.Email.Entity.Model.EmailAccount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailAccount set ");
            strSql.Append("EmailAccountRemainEmailCount=@EmailAccountRemainEmailCount,");
            strSql.Append("EmailAccountLastTime=@EmailAccountLastTime");
            strSql.Append(" where EmailAccountID=@EmailAccountID");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailAccountID", SqlDbType.VarChar,40),
					new SqlParameter("@EmailAccountRemainEmailCount", SqlDbType.Int),
					new SqlParameter("@EmailAccountLastTime", SqlDbType.Date)};
            parameters[0].Value = model.EmailAccountID;
            parameters[1].Value = model.EmailAccountRemainEmailCount;
            parameters[3].Value = model.EmailAccountLastTime;

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

        public bool UpdateState(Panther.Email.Entity.Model.EmailAccount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update EmailAccount set ");
            strSql.Append(" SendState=1 ");
            strSql.Append(" where EmailAccountID=@EmailAccountID");
            SqlParameter[] parameters = {
					new SqlParameter("@EmailAccountID", SqlDbType.VarChar,40)};
            parameters[0].Value = model.EmailAccountID;

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

