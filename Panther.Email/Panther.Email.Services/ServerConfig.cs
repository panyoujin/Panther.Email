using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Panther.Email.Core.Log;

namespace Panther.Email.Services
{
    public class ServerConfig
    {
        /// <summary>
        /// 获取配置service的配置文件路径
        /// </summary>
        public static string ServiceXmlUrl
        {
            get
            {
                return GetAppSettingsValue("ServiceXmlUrl", @"/Config/ServicesConfig.xml");
            }
        }

        /// <summary>
        /// 获取服务的使用有效期
        /// </summary>
        public static string ServicesDate
        {
            get
            {
                return GetAppSettingsValue("ServicesDate", @"2017-01-01");
            }
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
                LogHelper.Error("Panther.Email.Services.ServerConfig", "GetAppSettingsValue("+key+","+defaultValue+")", ex.Message, ex);
                return defaultValue;
            }
        }
    }
}
