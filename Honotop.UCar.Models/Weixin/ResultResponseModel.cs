using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.UCar.Models.Weixin
{
   public class ResultResponseModel
    {
        /// <summary>
        /// 错误码
        /// -1	系统繁忙，此时请开发者稍候再试
        /// 0	请求成功
        /// 40029	code 无效
        /// 45011	频率限制，每个用户每分钟100次
        /// </summary>
        public string errcode { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string errmsg { get; set; }
    }
}
