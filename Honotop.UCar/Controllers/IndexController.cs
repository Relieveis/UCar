using Honotop.UCar.Models;
using Honotop.UCar.Models.Customers;
using Honotop.UCar.Models.PermissionRecords;
using Honotop.UCar.Models.Weixin;
using Honotop.UCar.Service.Cache;
using Honotop.UCar.Service.Customers;
using Honotop.UCar.Service.Permissions;
using Honotop.Utils;
using Honotop.WMS.Service.WeChat;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Honotop.WMS.Controllers
{

    public class IndexController : Controller
    {
        private readonly ICacheService _cacheService;
        private readonly ICustomerService _customerService;
        private readonly IPermissionService _permissionService;

        public IndexController(ICacheService cacheService
            , ICustomerService customerService
           , IPermissionService permissionService)
        {
            this._cacheService = cacheService;
            this._customerService = customerService;
            this._permissionService = permissionService;
        }

        public ActionResult Index(string redirectUrl)
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WeChatLogin(string code)
        {
            var apiResponseModel = new APIResponseModel();
            if (string.IsNullOrWhiteSpace(code))
            {
                apiResponseModel.errorcode = "-1";
                apiResponseModel.errormsg = "临时登录凭证不能为空";
                return Json(apiResponseModel);
            }

            try
            {
                var weChatApi = new WeChatAPI();
                var result = weChatApi.Authorization(code);
                var authModel = JsonUtil.Deserialize<AuthResponseModel>(result);
                if (string.IsNullOrWhiteSpace(authModel.openid))
                {
                    apiResponseModel.errorcode = "-1";
                    apiResponseModel.errormsg = "错误";
                    apiResponseModel.data = authModel;
                    return Json(apiResponseModel);
                }

                var customer = _customerService.GetCustomerByOpenId(authModel.openid);
                if (customer == null)
                {
                    customer = new Customer()
                    {
                        OpenId = authModel.openid,
                        CreatedOnUtc = DateTime.Now,
                        LastLoginDateUtc = DateTime.Now,
                        LastActivityDateUtc = DateTime.Now
                    };
                    _customerService.InsertCustomer(customer);
                }

                var token = Guid.NewGuid().ToString();
                if (_cacheService.IsSet(token))
                    _cacheService.Remove(token);

                _cacheService.Set(token, customer, 60);

                apiResponseModel.errorcode = "0";
                apiResponseModel.errormsg = "登录成功";
                apiResponseModel.data = token;
                return Json(apiResponseModel);
            }
            catch (Exception e)
            {
                apiResponseModel.errorcode = "11";
                apiResponseModel.errormsg = e.Message;
                apiResponseModel.data = null;
                return Json(apiResponseModel);
            }
        }

        [HttpPost]
        public ActionResult CanManageCarOrNot()
        {
            var apiResponseModel = new APIResponseModel();
            try
            {
                var token = Request.Params["TOKEN"]?.ToString();

                var currentCustomer = _cacheService.Get<Customer>(token);
                if (currentCustomer == null)
                {
                    apiResponseModel.errorcode = "-1";
                    apiResponseModel.errormsg = "重新登录";
                    return Json(apiResponseModel);
                }
                bool canManagerCarOrNot = _permissionService.Authorize(StandardPermissionProvider.ManageCar, currentCustomer);
                apiResponseModel.errorcode = canManagerCarOrNot ? "0" : "-1";
                apiResponseModel.errormsg = canManagerCarOrNot ? "成功" : "无权限";
                return Json(apiResponseModel);
            }
            catch (Exception e)
            {
                apiResponseModel.errorcode = "-1";
                apiResponseModel.errormsg = e.Message;
                return Json(apiResponseModel);
            }

        }
    }
}