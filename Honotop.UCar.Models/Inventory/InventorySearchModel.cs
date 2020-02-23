using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Models.Inventory
{
    public class InventorySearchModel
    {
        /// <summary>
        /// 货主
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 渠道
        /// </summary>
        public string Channel { get; set; }
        /// <summary>
        /// 起始库位
        /// </summary>
        public string StartLocation { get; set; }
        /// <summary>
        /// 货品
        /// </summary>
        public string Barcode { get; set; }
        /// <summary>
        ///名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///状态
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        ///区域
        /// </summary>
        public string Zone { get; set; }
        /// <summary>
        ///结束库位
        /// </summary>
        public string EndLocation { get; set; }
        /// <summary>
        ///LPN
        /// </summary>
        public string LPN { get; set; }
        /// <summary>
        ///属性1
        /// </summary>
        public string Attribute1 { get; set; }
        /// <summary>
        ///属性2
        /// </summary>
        public string Attribute2 { get; set; }
        /// <summary>
        ///品牌
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        ///是否包含空库位？
        /// </summary>
        public bool IsNotNullLoction { get; set; } = true;


    }
}
