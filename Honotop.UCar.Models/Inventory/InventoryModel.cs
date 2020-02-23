using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Models.Inventory
{
   public class InventoryModel:PageModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string INTERNAL_LOCATION_INV { get; set; }
        /// <summary>
        /// 仓库
        /// </summary>
        public string WAREHOUSE { get; set; }
        /// <summary>
        /// 货主
        /// </summary>
        public string COMPANY { get; set; }
        /// <summary>
        /// 货品
        /// </summary>
        public string ITEM { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string ITEM_DESC { get; set; }
        /// <summary>
        /// 库位
        /// </summary>
        public string LOCATION { get; set; }
        /// <summary>
        /// 区域
        /// </summary>
        public string ZONE { get; set; }
        /// <summary>
        /// 在库数量
        /// </summary>
        public string ON_HAND_QTY { get; set; }
        /// <summary>
        /// 移入数量
        /// </summary>
        public string IN_TRANSIT_QTY { get; set; }
        /// <summary>
        /// 分配数量
        /// </summary>
        public string ALLOCATED_QTY { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string INVENTORY_STS { get; set; }
        /// <summary>
        /// 属性号
        /// </summary>
        public string ATTRIBUTE_NUM { get; set; }
        /// <summary>
        /// 销售渠道
        /// </summary>
        public string ATTRIBUTE3 { get; set; }
        /// <summary>
        /// 生产时间
        /// </summary>
        public string ATTRIBUTE1 { get; set; }
        /// <summary>
        /// 失效日期
        /// </summary>
        public string ATTRIBUTE2 { get; set; }
        /// <summary>
        /// 托盘号
        /// </summary>
        public string LPN { get; set; }
        /// <summary>
        /// 批次号
        /// </summary>
        public string ATTRIBUTE4 { get; set; }
        /// <summary>
        /// 收货日期
        /// </summary>
        public string ATTRIBUTE5 { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        public string BRAND { get; set; }
    }
}
