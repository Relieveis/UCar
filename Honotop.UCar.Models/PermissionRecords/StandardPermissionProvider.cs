using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.UCar.Models.PermissionRecords
{
   public class StandardPermissionProvider
    {
        public static readonly PermissionRecord ManageCustomer =
           new PermissionRecord { DisplayName = "用户管理", SystemName = "ManageCustomer", Category = "system" };
        public static readonly PermissionRecord ManageOrder =
         new PermissionRecord { DisplayName = "订单管理", SystemName = "ManageOrder", Category = "order" };
        public static readonly PermissionRecord ManageCar =
         new PermissionRecord { DisplayName = "车辆管理", SystemName = "ManageCar", Category = "order" };
    }
}
