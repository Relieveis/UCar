using Honotop.WMS.Data.Domins;
using Honotop.WMS.Models.ShipmentOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Service.ShipmentOrders
{
  public  class ShipmentService:IShipmentService
    {
        public async Task<IList<ShipmentOrderModel>> GetShipmentOrders(ShipmentOrderSearchModel condition, int pageSize = 20, int pageNumber = 1)
        {

            int pageStart = (pageNumber - 1) * pageSize + 1;
            int pageEnd = pageNumber * pageSize;

            string dboTable = "[dbo].[SHIPMENT_HEADER] SH";
            string orderby = "ORDER BY SH.[CREATE_DATE_TIME] ASC";
            var where = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(condition.Company))
                where.AppendLine("AND SH.Company=@Company");

            if (!string.IsNullOrWhiteSpace(condition.ShipmentId))
                where.AppendLine("AND SH.[SHIPMENT_ID]=@Receipt_Id");

            if (!string.IsNullOrWhiteSpace(condition.ShipmentType))
                where.AppendLine("AND  SH.[SHIPMENT_TYPE]=@Receipt_Type");



            string pageSql = $@"with Temp as(
                               select COUNT(*) as 'TotalCount' from {dboTable} 
                                {where.ToString()}
                                ) 
                                 select (select TotalCount from Temp) as 'TotalCount' , *
                               from (
                              select ROW_NUMBER() over({orderby}) as 'rowNumber'
                             ,* 
                            from {dboTable}  
                            {where.ToString()}
                            ) as  a 
                             where rowNumber between {pageStart}  and {pageEnd} ";

            var orders = await DBHelper.ExcuteAsycnList<ShipmentOrderModel>(pageSql, condition);
            return orders;
        }

        public async Task<IList<ShipmentOrderDetailModel>> GetShipmentDetail(int internalNum)
        {
            string sql = @"SELECT * FROM [dbo].[SHIPMENT_DETAIL] 
                          WHERE [INTERNAL_SHIPMENT_NUM]=@internalNum";
            var orders = await DBHelper.ExcuteAsycnList<ShipmentOrderDetailModel>(sql, new { @internalNum = internalNum });
            return orders;
        }
    }
}
