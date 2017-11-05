using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using Panther.Email.Core.Log;

namespace Panther.Email.Services
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            if (DateTime.Now > Convert.ToDateTime(ServerConfig.ServicesDate))
            {
                LogHelper.Error("系統發生未知錯誤請聯繫系統管理員");
                throw new Exception("系統發生未知錯誤請聯繫系統管理員");
            }
            EmailService s = new EmailService();
            s.Start();

            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[] 
            //{ 
            //    new EmailService() 
            //};
            //ServiceBase.Run(ServicesToRun);
        }
    }
}
