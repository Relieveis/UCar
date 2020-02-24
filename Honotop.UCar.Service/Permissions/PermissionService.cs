
using Honotop.UCar.Models.Customers;
using Honotop.UCar.Models.PermissionRecords;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Honotop.UCar.Service.Permissions
{
    public class PermissionService : IPermissionService
    {       
        public IList<PermissionRecord> GetAllPermissionRecords()
        {
            return null;
        }

        public void UpdatePermissionRecord(PermissionRecord permission)
        {
            
        }

        public virtual bool Authorize(PermissionRecord permission, Customer customer)
        {
            //if (permission == null)
            //    return false;

            //if (customer == null)
            //    return false;

            //old implementation of Authorize method
            //var customerRoles = customer.CustomerRoles.Where(cr => cr.Active);
            //foreach (var role in customerRoles)
            //    foreach (var permission1 in role.PermissionRecords)
            //        if (permission1.SystemName.Equals(permission.SystemName, StringComparison.InvariantCultureIgnoreCase))
            //            return true;

            return false;

            //return Authorize(permission.SystemName, customer);
        }
    }
}
