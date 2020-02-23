using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Models.ShipmentOrders
{
    public class ShipmentOrderModel : PageModel
    {
        public int INTERNAL_SHIPMENT_NUM { get; set; }
        public string WAREHOUSE { get; set; }
        public string COMPANY { get; set; }
        public int? INTERNAL_LOAD_NUM { get; set; }
        public string SHIPMENT_ID { get; set; }
        public string ERP_ORDER { get; set; }
        public int LEADING_STS { get; set; }
        public int? TRAILING_STS { get; set; }
        public string SHIPMENT_TYPE { get; set; }
        public string ROUTE { get; set; }
        public string SHIP_TO { get; set; }
        public string SHIP_TO_NAME { get; set; }
        public string SHIP_TO_ADDRESS1 { get; set; }
        public string SHIP_TO_ADDRESS2 { get; set; }
        public string SHIP_TO_DISTRICT { get; set; }
        public string SHIP_TO_CITY { get; set; }
        public string SHIP_TO_STATE { get; set; }
        public string SHIP_TO_COUNTRY { get; set; }
        public string SHIP_TO_POSTAL_CODE { get; set; }
        public string SHIP_TO_ATTENTION_TO { get; set; }
        public string SHIP_TO_PHONE_NUM { get; set; }
        public string SHIP_TO_MOBILE { get; set; }
        public string SHIP_TO_FAX_NUM { get; set; }
        public string SHIP_TO_EMAIL_ADDRESS { get; set; }
        public int PRIORITY { get; set; }
        public string USER_STAMP { get; set; }
        public DateTime? DATE_TIME_STAMP { get; set; }
        public DateTime? REQUESTED_DELIVERY_DATE { get; set; }
        public string REQUESTED_DELIVERY_TYPE { get; set; }
        public DateTime? SCHEDULED_SHIP_DATE { get; set; }
        public DateTime? ACTUAL_SHIP_DATE_TIME { get; set; }
        public DateTime? ACTUAL_DELIVERY_DATE_TIME { get; set; }
        public string DELIVERY_NOTE { get; set; }
        public string REJECTION_NOTE { get; set; }
        public int? INTERNAL_WAVE_NUM { get; set; }
        public string SHIP_DOCK { get; set; }
        public string ALLOCATE_COMPLETE { get; set; }
        public decimal? TOTAL_WEIGHT { get; set; }
        public string WEIGHT_UM { get; set; }
        public decimal? TOTAL_VOLUME { get; set; }
        public string VOLUME_UM { get; set; }
        public int? TOTAL_LINES { get; set; }
        public int? TOTAL_CONTAINERS { get; set; }
        public string CARRIER { get; set; }
        public string CARRIER_SERVICE { get; set; }
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
        public int? BACK_ORDER_NUM { get; set; }
        public string PROCESS_TYPE { get; set; }
        public int? TOTAL_QTY { get; set; }
        public int? LAST_WAVE_NUM { get; set; }
        public int? GROUP_NUM { get; set; }
        public int? GROUP_INDEX { get; set; }
        public string SIGN_VALUE { get; set; }
        public string SHIPMENT_SUB_TYPE { get; set; }
        public string SHIPMENT_CATEGORY1 { get; set; }
        public string SHIPMENT_CATEGORY2 { get; set; }
        public string SHIPMENT_CATEGORY3 { get; set; }
        public string SHIPMENT_CATEGORY4 { get; set; }
        public string SHIPMENT_CATEGORY5 { get; set; }
        public string SHIPMENT_CATEGORY6 { get; set; }
        public string SHIPMENT_CATEGORY7 { get; set; }
        public string SHIPMENT_CATEGORY8 { get; set; }
        public string UPLOAD_INTERFACE_FLAG { get; set; }
        public string TOTAL_VALUE { get; set; }
        public string SHIPMENT_NOTE { get; set; }
        public string STOP_SEQ { get; set; }
        public string CREATE_DATE_TIME { get; set; }
        public string CREATE_USER { get; set; }
        public string COD_REQUIRED { get; set; }
        public string COD_VALUE { get; set; }
        public string DEIVERY_WINDOW { get; set; }
        public string ALLOW_CONSOLIDATE { get; set; }
        public string CONSOLIDATED { get; set; }
        public string INVOICE_REQUIRED { get; set; }
        public string INTERNAL_INVOICE_NUM { get; set; }
        public string HOST_COMPANY { get; set; }
        public string UPLOAD_INTERFACE_DATE_TIME { get; set; }
        public string UPLOAD_INTERFACE_REQUIRED { get; set; }
        public string SO_OPERATOR { get; set; }
        public string SO_OPERATOR_PHONE_NUM { get; set; }
        public string SO_EMAIL_ADDRESS { get; set; }
        public string STATUS_FLOW { get; set; }
        public string ITF_USERDEF1 { get; set; }
        public string ITF_USERDEF2 { get; set; }
        public string ITF_USERDEF3 { get; set; }
        public string ITF_USERDEF4 { get; set; }
        public string ITF_USERDEF5 { get; set; }
        public string ITF_USERDEF6 { get; set; }
        public string ITF_USERDEF7 { get; set; }
        public string ITF_USERDEF8 { get; set; }
        public string IS_CAINIAO_BILL_SERVER { get; set; }
    }
}
