using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Panther.Email.Core.Enum
{
    public enum SendBccAccountState : short
    {
        /// <summary>
        /// 已發送
        /// </summary>
        Sended = 1,
        /// <summary>
        /// 未發送
        /// </summary>
        Unsent = 0,
        /// <summary>
        /// 發送失敗
        /// </summary>
        SendFial = -1
    }
}
