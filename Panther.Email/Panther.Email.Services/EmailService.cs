using System;
using System.Collections.Generic;
using System.Reflection;
using System.ServiceProcess;
using Panther.Email.Core.Helper;
using Panther.Email.Core.Log;
using Panther.Email.Services.Base;
using Panther.Email.Services.SendEmail;

namespace Panther.Email.Services
{
    public partial class EmailService : ServiceBase
    {

        static Dictionary<string, System.Reflection.Assembly> _dicAssembly = new Dictionary<string, Assembly>();

        public EmailService()
        {
            InitializeComponent();
        }

        public void Start()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                var xe = XmlHelper.XmlLoad(AppDomain.CurrentDomain.BaseDirectory + "/" + ServerConfig.ServiceXmlUrl);
                foreach (var item in XmlHelper.GetElements(xe, "Service"))
                {
                    try
                    {
                        string assembly = XmlHelper.GetElement(item, "Assembly");
                        string methods = XmlHelper.GetElement(item, "Methods");
                        int interval;
                        int.TryParse(XmlHelper.GetElement(item, "Interval"), out interval);
                        if (interval <= 0)
                        {
                            interval = 10;
                        }
                        string dllFunll = AppDomain.CurrentDomain.BaseDirectory + "/" + assembly;
                        Assembly serviceDll;
                        //已经发射过的不再进行反射
                        if (_dicAssembly.ContainsKey(dllFunll))
                        {
                            serviceDll = _dicAssembly[dllFunll];
                            if (serviceDll == null)
                            {
                                serviceDll = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + "/" + assembly);
                                _dicAssembly.Add(dllFunll, serviceDll);
                            }
                        }
                        else
                        {
                            serviceDll = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + "/" + assembly);
                            _dicAssembly.Add(dllFunll, serviceDll);
                        }
                        System.Type t = serviceDll.GetType(methods);//获得类型
                        object o = System.Activator.CreateInstance(t);//创建实例
                        if (o is EmailServerBase)
                        {
                            EmailServerBase service = o as EmailServerBase;
                            service.StartServer(interval);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogHelper.Error("Panther.Email.Services.EmailService", "反射服务类实例", ex.Message, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("Panther.Email.Services.EmailService", "OnStart", ex.Message, ex);
            }
        }

        protected override void OnStop()
        {
            try
            {

            }
            catch (Exception ex)
            {
                LogHelper.Error("Panther.Email.Services.EmailService", "OnStop", ex.Message, ex);
            }
        }
    }
}
