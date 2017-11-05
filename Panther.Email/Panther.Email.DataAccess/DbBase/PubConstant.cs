using Panther.Email.Core.Log;
using System;
using System.Configuration;
namespace Panther.Email.DataAccess.DbBase
{
    
    public class PubConstant
    {        
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {           
            get 
            {
                string _connectionString = GetAppSettingsValue("DBConfig", @"Provider=Microsoft.Jet.OLEDB.4.0;Data source=D:\\智能郵件系統\\DB\\EmailManager.mdb; User Id=admin; Password=;OLE DB Services=-4");
                //"Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + "D:\\DB\\EmailManager.mdb" + "; User Id=admin; Password=;OLE DB Services=-4";
                //    ConfigurationManager.AppSettings["ConnectionString"];       
                //string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                //if (ConStringEncrypt == "true")
                //{
                //    _connectionString = DESEncrypt.Decrypt(_connectionString);
                //}
                return _connectionString; 
            }
        }

        /// <summary>
        /// 得到web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + AppDomain.CurrentDomain.BaseDirectory + "DB\\EmailManager.mdb" + "; User Id=admin; Password=;";
            //    ConfigurationManager.AppSettings[configName];
            //string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            //if (ConStringEncrypt == "true")
            //{
            //    connectionString = DESEncrypt.Decrypt(connectionString);
            //}
            return connectionString;
        }

        /// <summary>
        /// 根据key从配置文件中获取信息
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="defaultValue">当获取不到或者获取异常的时候，替代的默认值</param>
        /// <returns></returns>
        public static string GetAppSettingsValue(string key, string defaultValue = null)
        {
            try
            {
                return ConfigurationManager.AppSettings[key];
            }
            catch (Exception ex)
            {
                LogHelper.Error("Panther.Email.Services.ServerConfig", "GetAppSettingsValue(" + key + "," + defaultValue + ")", ex.Message, ex);
                return defaultValue;
            }
        }
    }
}
