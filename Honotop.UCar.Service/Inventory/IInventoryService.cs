using Honotop.WMS.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Service.Inventory
{
  public interface IInventoryService
    {
        Task<IList<InventoryModel>> GetInventoryList(InventorySearchModel condition, int pageSize = 20, int pageNumber = 1);

      //  Task<IList<ReceiptOrderDetailModel>> GetReceiptDetail(int internalNum);
    }
}
