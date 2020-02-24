using Honotop.UCar.Models.Customers;
using Honotop.WMS.Data.Domins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.UCar.Service.Customers
{
    public class CustomerService : ICustomerService
    {
        #region  Customer  
        public Customer GetCustomerById(int Id)
        {
            if (Id <= 0)
                return null;

            string sql = @"SELECT * FROM DBO.Customer WHERE Id=@Id";
            var customer =  DBHelper.Excute<Customer>(sql, new { @Id = Id });
            return customer;
        }

        public Customer GetCustomerByOpenId(string openId)
        {
            if (string.IsNullOrWhiteSpace(openId))
                return null;

            string sql = @"SELECT * FROM DBO.Customer WHERE OpenId=@OpenId";
            var customer = DBHelper.Excute<Customer>(sql, new { @OpenId = openId });
            return customer;
        }

        public Customer GetCustomerByGuid(Guid guid)
        {
            if (guid==null)
                return null;

            string sql = @"SELECT * FROM DBO.Customer WHERE GUID=@GUID";
            var customer = DBHelper.Excute<Customer>(sql, new { @GUID = guid });
            return customer;
        }

        public void InsertCustomer(Customer customer)
        {
            try
            {
                string sql = @"  INSERT DBO.Customer
                        (    [CustomerGuid]
                            ,[OpenId]
                            ,[Username]
                            ,[Phone]
                            ,[Remark]
                            ,[Active]
                            ,[Deleted]
                            ,[CreatedOnUtc]
                            ,[LastLoginDateUtc]
                            ,[LastActivityDateUtc])
	                        VALUES(
	                         @CustomerGuid
                            ,@OpenId
                            ,@Username
                            ,@Phone
                            ,@Remark
                            ,@Active
                            ,@Deleted
                            ,@CreatedOnUtc
                            ,@LastLoginDateUtc
                            ,@LastActivityDateUtc
	                        )";

                var affect = DBHelper.ExcuteSql(sql, param: customer, transaction: null, commandTimeout: null, commandType: null);
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        public void UpdateCustomer(Customer customer)
        {

        }

        #endregion
    }
}
