
using Honotop.UCar.Models.Customers;
using Honotop.UCar.Models.PermissionRecords;
using Honotop.WMS.Data.Domins;
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
            string sql = @"select * from CustomerRoles  roles
                        inner join CustomerRoleCustomers mapping on roles.Id = mapping.CustomerRole_Id
                        inner join PermissionRecordCustomerRoles permission on roles.Id = permission.CustomerRole_Id
                        and mapping.Customer_Id = @customer_Id
                        and permission.PermissionRecord_Id in (select Id from PermissionRecords where SystemName = @systemName)";
            var affect = DBHelper.ExcuteSql(sql, param: new { @systemName=permission.SystemName, @customer_Id=customer.Id }, transaction: null, commandTimeout: null, commandType: null);
            if (affect > 0)
                return true;
            return false;
            
        }
    }
}
