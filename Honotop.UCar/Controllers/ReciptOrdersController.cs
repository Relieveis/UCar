using Honotop.WMS.Models;
using Honotop.WMS.Models.ReceiptOrders;
using Honotop.WMS.Service.ReceiptOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Honotop.WMS.Controllers
{
    /// <summary>
    /// 入库单
    /// </summary>
    public class ReciptOrdersController : Controller
    {
        private readonly IReceiptOrderService _receiptOrderService;
        public ReciptOrdersController(IReceiptOrderService receiptOrderService)
        {
            this._receiptOrderService = receiptOrderService;
        }
        public ActionResult Index()
        {
            //if (Session["wms"] == null)
            //    return RedirectToAction("Index", "Index");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> OrderList(ReceiptOrderSearchModel info, PageModel page)
        {
            var orders = await _receiptOrderService.GetReceiptOrders(info, page.pageSize, page.pageNumber);
            return Json(new { rows = orders, total = orders?.FirstOrDefault()?.TotalCount });
        }

        public ActionResult OrderDetailList(int orderId)
        {
            ViewBag.OrderId = orderId;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> OrderDetailListJson(int orderId)
        {
            if (orderId <= 0)
                throw new ArgumentNullException("orderId无法识别");
            var orders = await _receiptOrderService.GetReceiptDetail(orderId);
            return Json(new { rows = orders, total = orders?.Count() });
        }
    }
}