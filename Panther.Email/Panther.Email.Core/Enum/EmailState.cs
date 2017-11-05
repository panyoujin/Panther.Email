using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Panther.Email.Core.Enum
{
    public enum EmailState:short
    { 
        /// <summary>
        /// 啟動發送
        /// </summary>
        Start=0,
        /// <summary>
        /// 發送結束
        /// </summary>
        End ,
        /// <summary>
        /// 草稿
        /// </summary>
        Draft
    }
}
