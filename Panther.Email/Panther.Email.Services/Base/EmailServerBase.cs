using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Panther.Email.Core.Log;

namespace Panther.Email.Services.Base
{
    public class EmailServerBase
    {
        Thread _Thread;

        public bool IsStart = false;

        protected Action _Acction;
        public int Interval = 60;

        public void StartServer(int interval = 60)
        {
            Interval = interval;
            if (!IsStart)
            {
                IsStart = true;
                _Thread = new Thread((s) =>
                {
                    while (IsStart)
                    {
                        try
                        {
                            if (_Acction != null)
                            {
                                _Acction();
                            }
                            Run();
                        }
                        finally
                        {
                            SleepInterval(Interval);
                        }
                    }
                });
                _Thread.Start();
            }
        }


        public void StopServer()
        {
            try
            {
                IsStart = false;
                if (_Thread != null)
                {
                    while (_Thread.IsAlive)
                    {
                        try
                        {
                            _Thread.Abort();
                        }
                        catch (Exception ex)
                        {
                            LogHelper.Error("Panther.Email.Services.Base.EmailServerBase", "StopServer->_Thread.Abort();", ex.Message, ex);
                        }
                    }
                    _Thread = null;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("Panther.Email.Services.Base.EmailServerBase", "StopServer", ex.Message, ex);
            }
        }

        /// <summary>
        /// 子类需要开始执行的代码覆盖此方法
        /// </summary>
        public virtual void Run()
        {
            LogHelper.Info("Panther.Email.Services.Base.EmailServerBase->Run()");
        }

        public void SleepInterval(int interval)
        {
            while (interval > 0 && IsStart)
            {
                Thread.Sleep((interval > 10 ? 10 : interval) * 1000);
                interval -= 10;
            }
        }
    }
}
