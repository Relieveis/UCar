using Honotop.UCar.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.UCar.Service.Customers
{
   public interface ICustomerService
    {
        Customer GetCustomerById(int Id);

        Customer GetCustomerByOpenId(string openId);

        Customer GetCustomerByGuid(Guid guid);

        void InsertCustomer(Customer customer);

        void UpdateCustomer(Customer customer);
    }
}
