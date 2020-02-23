using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Models.ShipmentOrders
{
   public class ShipmentOrderSearchModel
    {
        /// <summary>
        /// 货主
        /// </summary>
        public string Company { get; set; }
        public string ShipmentId { get; set; }
        /// <summary>
        /// 订单类型
        /// </summary>
        public string ShipmentType { get; set; }
        /// <summary>
        /// 源单号
        /// </summary>
        public string ERPOrder { get; set; }
        /// <summary>
        /// 发货省份
        /// </summary>
        public string ShipToState { get; set; }
        /// <summary>
        /// 商品编码
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public string ProductQuantity { get; set; }
        /// <summary>
        /// 承运代码
        /// </summary>
        public string Carrier { get; set; }
        /// <summary>
        /// 销售渠道
        /// </summary>
        public string ShipTo { get; set; }
        /// <summary>
        /// 订单模式
        /// </summary>
        public string ShipmentSubType { get; set; }
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string ShiptoName { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string ShiptoMobile { get; set; }
        /// <summary>
        ///波次号码
        /// </summary>
        public string Wave { get; set; }
        /// <summary>
        /// 处理类型
        /// </summary>
        public string ProcessType { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string CarrierService { get; set; }
        /// <summary>
        /// 订单品牌
        /// </summary>
        public string OrderBrand { get; set; }
        /// <summary>
        /// 起始状态
        /// </summary>
        public string StatusStart { get; set; }
        /// <summary>
        /// 结束状态
        /// </summary>
        public string StatusEnd { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        public string ExpressNum { get; set; }
        /// <summary>
        /// 单总件数
        /// </summary>
        public string TotalQuantity { get; set; }
        /// <summary>
        /// 创建开始
        /// </summary>
        public DateTime? CreatedStartTime { get; set; }
        /// <summary>
        /// 创建结束
        /// </summary>
        public DateTime? CreatedEndTime { get; set; }
        /// <summary>
        /// 发货起始
        /// </summary>
        public DateTime? DeliveryStartTime { get; set; }
        /// <summary>
        /// 发货结束
        /// </summary>
        public DateTime? DeliveryEndTime { get; set; }

    }
}
