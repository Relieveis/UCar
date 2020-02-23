using Honotop.WMS.Models.ReceiptOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Service.ReceiptOrders
{
   public interface IReceiptOrderService
    {
         Task<IList<ReceiptOrderModel>> GetReceiptOrders(ReceiptOrderSearchModel condition, int pageSize =20,int pageNumber=1);

        Task<IList<ReceiptOrderDetailModel>> GetReceiptDetail(int internalNum);
    }
}
