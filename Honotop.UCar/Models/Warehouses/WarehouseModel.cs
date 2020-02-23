using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Honotop.WMS.Models.Warehouses
{
    public class WarehouseModel
    {
        public string Name { get; set; }
        public string InnerConnecttion { get; set; }

        public string OuterConnecttion { get; set; }
        public bool IsAcive { get; set; } = true;
    }
}