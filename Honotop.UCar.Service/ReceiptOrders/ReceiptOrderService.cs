using Honotop.WMS.Data.Domins;
using Honotop.WMS.Models.ReceiptOrders;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Service.ReceiptOrders
{
  public  class ReceiptOrderService:IReceiptOrderService
    {
        public async Task<IList<ReceiptOrderModel>> GetReceiptOrders(ReceiptOrderSearchModel condition, int pageSize = 20, int pageNumber = 1)
        {

            int pageStart = (pageNumber - 1) * pageSize + 1;
            int pageEnd = pageNumber * pageSize;

            string dboTable = "[dbo].[RECEIPT_HEADER] RH";
            string orderby = "ORDER BY CREATE_DATE DESC";
            var where = new StringBuilder();
            where.AppendLine("WHERE 1=1");
            if (!string.IsNullOrWhiteSpace(condition.Company))
                where.AppendLine("AND RH.Company=@Company");

            if (!string.IsNullOrWhiteSpace(condition.Receipt_Id))
                where.AppendLine("AND RH.Receipt_Id=@Receipt_Id");

            if (!string.IsNullOrWhiteSpace(condition.Receipt_Type))
                where.AppendLine("AND RH.Receipt_Type=@Receipt_Type");

            if (!string.IsNullOrWhiteSpace(condition.SKU))
                where.AppendLine("AND RD.ITEM=@SKU");

            if (!string.IsNullOrWhiteSpace(condition.ShipFrom))
                where.AppendLine("AND RH.SHIP_FROM=@ShipFrom");

            if (!string.IsNullOrWhiteSpace(condition.ShipFromState))
                where.AppendLine("AND RH.SHIP_FROM_STATE=@ShipFromState");

            if (!string.IsNullOrWhiteSpace(condition.ShopName))
                where.AppendLine("AND RH.USER_DEF4=@ShopName");

            if (!string.IsNullOrWhiteSpace(condition.ErpOrderNum))
                where.AppendLine("AND RH.USER_DEF2 like @ErpOrderNum");

            if (!string.IsNullOrWhiteSpace(condition.TrailingSysStart))
                where.AppendLine("AND RH.TRAILING_STS >=@TrailingSysStart");

            if (!string.IsNullOrWhiteSpace(condition.TrailingSysEnd))
                where.AppendLine("AND RH.TRAILING_STS <=@TrailingSysEnd");

            if (!string.IsNullOrWhiteSpace(condition.ShipFromName))
                where.AppendLine("AND RH.SHIP_FROM_NAME =@ShipFromName");

            if (!string.IsNullOrWhiteSpace(condition.ShipFromPhoneNum))
                where.AppendLine("AND RH.SHIP_FROM_PHONE_NUM =@ShipFromPhoneNum");

            if (condition.CreatedStartTime.HasValue && condition.CreatedEndTime == null)
            {
                where.AppendLine("AND RH.CREATE_DATE_TIME >= @CreatedStartTime");

            }
            else if(condition.CreatedStartTime==null && condition.CreatedEndTime.HasValue)
            {
                where.AppendLine("AND RH.CREATE_DATE_TIME <= @CreatedEndTime");
            }
            else if (condition.CreatedStartTime.HasValue && condition.CreatedEndTime.HasValue)
            {
                where.AppendLine("AND RH.CREATE_DATE_TIME BETWEEN @CreatedStartTime AND @CreatedEndTime ");
            }
           


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

            var orders = await DBHelper.ExcuteAsycnList<ReceiptOrderModel>(pageSql, condition);
            return orders;
        }

        public async Task<IList<ReceiptOrderDetailModel>> GetReceiptDetail(int internalNum)
        {
            string sql = @"SELECT * FROM [dbo].[RECEIPT_DETAIL] 
                          WHERE [INTERNAL_RECEIPT_NUM]=@internalNum";
            var orders = await DBHelper.ExcuteAsycnList<ReceiptOrderDetailModel>(sql, new { @internalNum = internalNum });
            return orders;
        }
    }
}
