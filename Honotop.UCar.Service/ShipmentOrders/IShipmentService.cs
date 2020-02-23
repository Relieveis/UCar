using Honotop.WMS.Models.ShipmentOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Service.ShipmentOrders
{
   public interface IShipmentService
    {
        Task<IList<ShipmentOrderModel>> GetShipmentOrders(ShipmentOrderSearchModel condition, int pageSize = 20, int pageNumber = 1);

        Task<IList<ShipmentOrderDetailModel>> GetShipmentDetail(int internalNum);
    }
}
