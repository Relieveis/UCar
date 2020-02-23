using Honotop.WMS.Models;
using Honotop.WMS.Models.Inventory;
using Honotop.WMS.Service.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Honotop.WMS.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryService _inventoryService;
        public InventoryController(IInventoryService inventoryService)
        {
            this._inventoryService = inventoryService;
        }
        // GET: Inventory
        public ActionResult Index()
        {
            var model = new InventorySearchModel();
            return View(model);
        }


        [HttpPost]
        public async Task<ActionResult> OrderList(InventorySearchModel info, PageModel page)
        {
            var orders = await _inventoryService.GetInventoryList(info, page.pageSize, page.pageNumber);
            return Json(new { rows = orders, total = orders?.FirstOrDefault()?.TotalCount });
        }
    }
}