using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Models.ReceiptOrders
{
   public class ReceiptOrderDetailModel
    {
        public string INTERNAL_RECEIPT_LINE_NUM { get; set; }
        public string INTERNAL_RECEIPT_NUM { get; set; }
        public string RECEIPT_ID { get; set; }
        public string WAREHOUSE { get; set; }
        public string COMPANY { get; set; }
        public string ITEM { get; set; }
        public string ITEM_DESC { get; set; }
        public string ITEM_CLASS { get; set; }
        public string ATTRIBUTE_TRACK { get; set; }
        public string ATTRIBUTE_NUM { get; set; }
        public string ATTRIBUTE1 { get; set; }
        public string ATTRIBUTE2 { get; set; }
        public string ATTRIBUTE3 { get; set; }
        public string ATTRIBUTE4 { get; set; }
        public string ATTRIBUTE5 { get; set; }
        public string ATTRIBUTE6 { get; set; }
        public string ATTRIBUTE7 { get; set; }
        public string ATTRIBUTE8 { get; set; }
        public string TOTAL_QTY { get; set; }
        public string OPEN_QTY { get; set; }
        public string QUANTITY_UM { get; set; }
        public string ERP_ORDER_ID { get; set; }
        public string ERP_ORDER_LINE_NUM { get; set; }
        public string LOCATING_RULE { get; set; }
        public string USER_STAMP { get; set; }
        public string DATE_TIME_STAMP { get; set; }
        public string INVENTORY_STS { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public string USER_DEF7 { get; set; }
        public string USER_DEF8 { get; set; }
        public string ITEM_LIST_PRICE { get; set; }
        public string ITEM_NET_PRICE { get; set; }
        public string ITEM_CATEGORY01 { get; set; }
        public string ITEM_CATEGORY02 { get; set; }
        public string ITEM_CATEGORY03 { get; set; }
        public string ITEM_CATEGORY04 { get; set; }
        public string ITEM_CATEGORY05 { get; set; }
        public string ITEM_CATEGORY06 { get; set; }
        public string ITEM_CATEGORY07 { get; set; }
        public string ITEM_CATEGORY08 { get; set; }
        public string CREATE_DATE_TIME { get; set; }
        public string CREATE_USER { get; set; }
        public string USER_DEF9 { get; set; }
        public string USER_DEF10 { get; set; }
        public string HOST_ITEM { get; set; }
        public string UPLOAD_INTERFACE_REQUIRED { get; set; }
        public string HOST_COMPANY { get; set; }
    }
}
