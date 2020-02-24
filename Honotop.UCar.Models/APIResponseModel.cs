using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.UCar.Models
{
    /// <summary>
    /// api定义的返回信息
    /// </summary>
   public class APIResponseModel
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        public string errorcode { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string errormsg { get; set; }
        /// <summary>
        /// 额外信息
        /// </summary>
        public object data { get; set; }
    }
}
