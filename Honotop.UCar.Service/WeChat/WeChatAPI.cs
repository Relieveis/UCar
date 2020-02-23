using Honotop.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Service.WeChat
{
   public  class  WeChatAPI
    {
        private readonly string APPID = ConfigurationManager.AppSettings["APPID"].ToString();
        private readonly string APPSECRET = ConfigurationManager.AppSettings["APPSECRET"].ToString();

        public string Authorization(string code)
        {
            try
            {
                string url = $"https://api.weixin.qq.com/sns/jscode2session?appid={APPID}&secret={APPSECRET}&js_code={code}&grant_type=authorization_code";

                string response = HttpRequestUtil.Get(url);

                return response;
            }
            catch (Exception e)
            {

                throw;
            }
          
        }

    }
}
