using Honotop.WMS.Data.Domins;
using Honotop.WMS.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Service.Inventory
{
   public class InventoryService: IInventoryService
    {
        public async Task<IList<InventoryModel>> GetInventoryList(InventorySearchModel condition, int pageSize = 20, int pageNumber = 1)
        {

            int pageStart = (pageNumber - 1) * pageSize + 1;
            int pageEnd = pageNumber * pageSize;

            string dboTable = @" DBO.LOCATION L
  LEFT JOIN LOCATION_INVENTORY LI ON LI.WAREHOUSE = L.WAREHOUSE AND LI.LOCATION = L.LOCATION
  LEFT JOIN ITEM I ON LI.ITEM = I.ITEM AND LI.COMPANY = I.COMPANY";

            string orderby = "ORDER BY L.ZONE";
            var where = new StringBuilder();
            where.AppendLine("WHERE 1=1");


            if (!string.IsNullOrWhiteSpace(condition.Company))
                where.AppendLine("AND LI.COMPANY=@Company");

            if (!string.IsNullOrWhiteSpace(condition.Channel))
                where.AppendLine("AND LI.ATTRIBUTE3=@Channel");

            if (!string.IsNullOrWhiteSpace(condition.StartLocation))
                where.AppendLine("AND L.LOCATION >=@StartLocation");

            if (!string.IsNullOrWhiteSpace(condition.EndLocation))
                where.AppendLine("AND L.LOCATION<=@EndLocation");

            if (!string.IsNullOrWhiteSpace(condition.Barcode))
                where.AppendLine("AND LI.ITEM = @Barcode");

            if (!string.IsNullOrWhiteSpace(condition.Name))
                where.AppendLine("AND LI.ITEM_DESC =@Name");

            if (!string.IsNullOrWhiteSpace(condition.Status))
                where.AppendLine("AND LI.INVENTORY_STS=@Status");

            if (!string.IsNullOrWhiteSpace(condition.Zone))
                where.AppendLine("AND L.ZONE=@Zone");

            if (!string.IsNullOrWhiteSpace(condition.LPN))
                where.AppendLine("AND LI.LPN=@LPN");

            if (!string.IsNullOrWhiteSpace(condition.Attribute1))
                where.AppendLine("AND LI.Attribute1=@Attribute1");

            if (!string.IsNullOrWhiteSpace(condition.Attribute2))
                where.AppendLine("AND LI.Attribute2=@Attribute2");

            if (!string.IsNullOrWhiteSpace(condition.Brand))
                where.AppendLine("AND I.BRAND=@Brand");

            if(condition.IsNotNullLoction)
                where.AppendLine("AND LI.ITEM IS NOT NULL");



            string pageSql = $@"with Temp as(
                               select COUNT(*) as 'TotalCount' from {dboTable}
                                {where.ToString()}
                                ) 
                                 select (select TotalCount from Temp) as 'TotalCount' , *
                               from (
                              select ROW_NUMBER() over({orderby}) as 'rowNumber'
                             ,L.ZONE AS ZONE,I.BRAND AS BRAND,
                             LI.INTERNAL_LOCATION_INV AS INTERNAL_LOCATION_INV,
                    L.WAREHOUSE,
                    L.LOCATION,
                    LI.ITEM AS ITEM,
                    LI.ITEM_DESC AS ITEM_DESC,
                    LI.COMPANY,
                    LI.PERMANENT,
                    LI.ATTRIBUTE_NUM,
                    ISNULL(LI.ON_HAND_QTY,0) ON_HAND_QTY,
                    LI.IN_TRANSIT_QTY,
                    LI.ALLOCATED_QTY,
                    LI.QUANTITY_UM,
                    LI.INVENTORY_STS,
                    LI.AGING_DATE,
                    LI.USER_STAMP,
                    LI.DATE_TIME_STAMP,
                    LI.LPN,
                    LI.PARENT_LPN,
                    LI.ATTRIBUTE1,
                    LI.ATTRIBUTE2,
                    LI.ATTRIBUTE3,
                    LI.ATTRIBUTE4,
                    LI.ATTRIBUTE5,
                    LI.ATTRIBUTE6,
                    LI.ATTRIBUTE7,
                    LI.ATTRIBUTE8
                            from {dboTable}  
                            {where.ToString()}
                            ) as  a 
                             where rowNumber between {pageStart}  and {pageEnd} ";

            var orders = await DBHelper.ExcuteAsycnList<InventoryModel>(pageSql, condition);
            return orders;
        }
    }
}
