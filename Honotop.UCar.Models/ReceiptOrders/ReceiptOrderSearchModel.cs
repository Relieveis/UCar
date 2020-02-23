using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Models.ReceiptOrders
{
    public class ReceiptOrderSearchModel
    {
        /// <summary>
        /// 货主
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 入库单号
        /// </summary>
        public string Receipt_Id { get; set; }
        /// <summary>
        /// 订单类型
        /// </summary>
        public string Receipt_Type { get; set; }
        /// <summary>
        /// 序列号
        /// </summary>
        public string Serialnum { get; set; }
        /// <summary>
        /// sku
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// 起始时间
        /// </summary>
        public DateTime? CreatedStartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? CreatedEndTime { get; set; }
        /// <summary>
        /// 客户单号
        /// </summary>
        public string ErpOrderId { get; set; }
        /// <summary>
        /// 寄件人
        /// </summary>
        public string ShipFromName { get; set; }
        /// <summary>
        /// 起始状态
        /// </summary>
        public string TrailingSysStart { get; set; }
        /// <summary>
        /// 结束状态
        /// </summary>
        public string TrailingSysEnd { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string ShipFromPhoneNum { get; set; }
        /// <summary>
        /// 运单号
        /// </summary>
        public string ShipFrom { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public string ShipFromState { get; set; }
        /// <summary>
        /// 门店名称 userdef4
        /// </summary>
        public string ShopName { get; set; }
        /// <summary>
        /// erp单号 userdef2
        /// </summary>
        public string ErpOrderNum { get; set; }





    }
}
