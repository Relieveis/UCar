using Honotop.UCar.Models.Customers;
using Honotop.UCar.Models.PermissionRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.UCar.Service.Permissions
{
   public interface IPermissionService
    {
        IList<PermissionRecord> GetAllPermissionRecords();

        void UpdatePermissionRecord(PermissionRecord permission);

        bool Authorize(PermissionRecord permission, Customer customer);
    }
}
