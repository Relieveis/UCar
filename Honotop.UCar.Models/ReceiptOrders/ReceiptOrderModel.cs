using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Models.ReceiptOrders
{
    public class ReceiptOrderModel:PageModel
    {
        public int INTERNAL_RECEIPT_NUM { get; set; }
        public string WAREHOUSE { get; set; }
        public string COMPANY { get; set; }
        public string RECEIPT_ID { get; set; }
        public string RECEIPT_TYPE { get; set; }
        public int? PRIORITY { get; set; }
        public int? LEADING_STS { get; set; }
        public int? TRAILING_STS { get; set; }
        public string ERP_ORDER_ID { get; set; }
        public string SHIP_FROM { get; set; }
        public string SHIP_FROM_ADDRESS1 { get; set; }
        public string SHIP_FROM_ADDRESS2 { get; set; }
        public string SHIP_FROM_CITY { get; set; }
        public string SHIP_FROM_STATE { get; set; }
        public string SHIP_FROM_COUNTRY { get; set; }
        public string SHIP_FROM_POSTAL_CODE { get; set; }
        public string SHIP_FROM_NAME { get; set; }
        public string SHIP_FROM_ATTENTION_TO { get; set; }
        public string SHIP_FROM_EMAIL_ADDRESS { get; set; }
        public string SHIP_FROM_PHONE_NUM { get; set; }
        public string SHIP_FROM_FAX_NUM { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? SCHEDULED_ARRIVE_DATE { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? ACTUAL_ARRIVE_DATE { get; set; }
        public string USER_STAMP { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? DATE_TIME_STAMP { get; set; }
        public string RECV_DOCK { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? CLOSE_DATE { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? CREATE_DATE { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? START_CHECKIN_DATE { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? END_CHECKIN_DATE { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public string USER_DEF7 { get; set; }
        public string USER_DEF8 { get; set; }
        public int TOTAL_QTY { get; set; }
        public int TOTAL_LINES { get; set; }
        public string UPLOAD_INTERFACE_FLAG { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? CREATE_DATE_TIME { get; set; }
        public string CREATE_USER { get; set; }
        public int USER_DEF9 { get; set; }
        public int USER_DEF10 { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? UPLOAD_INTERFACE_DATE_TIME { get; set; }
        public string UPLOAD_INTERFACE_REQUIRED { get; set; }
        public string HOST_COMPANY { get; set; }
        public string RECEIPT_NOTE { get; set; }
        public string SHIPPING_NOTE { get; set; }

    }
}
