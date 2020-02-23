using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Models.ShipmentOrders
{
    public class ShipmentOrderDetailModel
    {
        public int INTERNAL_SHIPMENT_LINE_NUM { get; set; }
        public int INTERNAL_SHIPMENT_NUM { get; set; }
        public string WAREHOUSE { get; set; }
        public string COMPANY { get; set; }
        public string SHIPMENT_ID { get; set; }
        public string ERP_ORDER { get; set; }
        public string ERP_ORDER_LINE_NUM { get; set; }
        public string SHIPMENT_TYPE { get; set; }
        public string ITEM { get; set; }
        public string ITEM_DESC { get; set; }
        public int? TOTAL_QTY { get; set; }
        public int? REQUEST_QTY { get; set; }
        public string QUANTITY_UM { get; set; }
        public string ALLOCATION_RULE { get; set; }
        public string PICK_LOC { get; set; }
        public string USER_STAMP { get; set; }
        public DateTime? DATE_TIME_STAMP { get; set; }
        public string ATTRIBUTE_TRACK { get; set; }
        public string ATTRIBUTE1 { get; set; }
        public string ATTRIBUTE2 { get; set; }
        public string ATTRIBUTE3 { get; set; }
        public string ATTRIBUTE4 { get; set; }
        public string ATTRIBUTE5 { get; set; }
        public string ATTRIBUTE6 { get; set; }
        public string ATTRIBUTE7 { get; set; }
        public string ATTRIBUTE8 { get; set; }
        public string INVENTORY_STS { get; set; }
        public string DOCK_LOC { get; set; }
        public string PACKING_CLASS { get; set; }
        public int? STATUS { get; set; }
        public int? INTERNAL_WAVE_NUM { get; set; }
        public decimal? TOTAL_WEIGHT { get; set; }
        public string WEIGHT_UM { get; set; }
        public decimal? TOTAL_VOLUME { get; set; }
        public string VOLUME_UM { get; set; }
        public int? BACK_ORDER_LINE_NUM { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public string USER_DEF7 { get; set; }
        public string USER_DEF8 { get; set; }
        public decimal? USER_DEF9 { get; set; }
        public decimal? USER_DEF10 { get; set; }
        public decimal? ITEM_LIST_PRICE { get; set; }
        public decimal? ITEM_NET_PRICE { get; set; }
        public int SERIAL_NUM_TRACK { get; set; }
        public string ORIGINAL_ORDER_NUM { get; set; }
        public DateTime? CREATE_DATE_TIME { get; set; }
        public string CREATE_USER { get; set; }
        public string HOST_ITEM { get; set; }
        public string UPLOAD_INTERFACE_REQUIRED { get; set; }
    }
}
