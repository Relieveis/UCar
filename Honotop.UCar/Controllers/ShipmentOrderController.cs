using Honotop.WMS.Models;
using Honotop.WMS.Models.ShipmentOrders;
using Honotop.WMS.Service.ShipmentOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Honotop.WMS.Controllers
{
    public class ShipmentOrderController : Controller
    {
        private readonly IShipmentService _shipmentService;
        public ShipmentOrderController(IShipmentService shipmentService)
        {
            this._shipmentService = shipmentService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> OrderList(ShipmentOrderSearchModel info, PageModel page)
        {
            var orders = await _shipmentService.GetShipmentOrders(info, page.pageSize, page.pageNumber);
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
            var orders = await _shipmentService.GetShipmentDetail(orderId);
            return Json(new { rows = orders, total = orders?.Count() });
        }
    }
}