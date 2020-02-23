using Honotop.WMS.Service.WeChat;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Honotop.WMS.Controllers
{

    public class IndexController : Controller
    {
        public ActionResult Index(string redirectUrl)
        { 
            return View();
        }        

        public ActionResult Error()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WeChatLogin()
        {
            var wechatCode = Request.QueryString["code"]?.ToString();
            if (string.IsNullOrWhiteSpace(wechatCode))
                throw new ArgumentNullException("临时登录凭证不能为空");

            //请求微信接口获取openId等信息；
            var weChatApi = new WeChatAPI();
          var result=  weChatApi.Authorization(wechatCode);

            return Json(result);
        }

    }
}