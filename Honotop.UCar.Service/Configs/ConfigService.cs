using Honotop.WMS.Data.Domins;
using Honotop.WMS.Models.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Service.Configs
{
    public class ConfigService : IConfigService
    {

        /// <summary>
        /// 销售渠道
        /// </summary>
        /// <returns></returns>
        public async Task<IList<InventoryChannelModel>> GetInventoryChannelListAsync()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='INVENTORY_CHANNEL' ";
            var lists = await DBHelper.ExcuteAsycnList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 仓库列表
        /// </summary>
        /// <returns></returns>
        public async Task<IList<InventoryChannelModel>> GetWarehouseListAsync()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='WAREHOUSE' AND ACTIVE='Y' ";
            var lists = await DBHelper.ExcuteAsycnList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 库存区域
        /// </summary>
        /// <returns></returns>
        public async Task<IList<InventoryChannelModel>> GetZoneListAsync()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='ZONE' ";
            var lists = await DBHelper.ExcuteAsycnList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 库存状态
        /// </summary>
        /// <returns></returns>
        public async Task<IList<InventoryChannelModel>> GetInventoryStatusListAsync()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='INVENTORY_STS' ";
            var lists = await DBHelper.ExcuteAsycnList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 入库类型
        /// </summary>
        /// <returns></returns>
        public async Task<IList<InventoryChannelModel>> GetReceiptTypeListAsync()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='RECEIPT_TYPE' AND ACTIVE='Y'";
            var lists = await DBHelper.ExcuteAsycnList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 收货状态
        /// </summary>
        /// <returns></returns>
        public async Task<IList<InventoryChannelModel>> GetInboundStatusListAsync()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='INBOUND_STS' ";
            var lists = await DBHelper.ExcuteAsycnList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 承运商
        /// </summary>
        /// <returns></returns>
        public async Task<IList<InventoryChannelModel>> GetCarrierListAsync()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='CARRIER' ";
            var lists = await DBHelper.ExcuteAsycnList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 订单类型
        /// </summary>
        /// <returns></returns>
        public async Task<IList<InventoryChannelModel>> GetShipmentTypeListAsync()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='SHIPMENT_TYPE'  AND ACTIVE='Y' ";
            var lists = await DBHelper.ExcuteAsycnList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 订单模式 （单品或者多品）
        /// </summary>
        /// <returns></returns>
        public async Task<IList<InventoryChannelModel>> GetOrderTypeListAsync()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='SHIPMENT_TYPE'  AND ACTIVE='Y' ";
            var lists = await DBHelper.ExcuteAsycnList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 订单处理类型
        /// </summary>
        /// <returns></returns>
        public async Task<IList<InventoryChannelModel>> GetShipmentProcessTypeListAsync()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='SHP_PROCESS_TYPE' ";
            var lists = await DBHelper.ExcuteAsycnList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 订单状态
        /// </summary>
        /// <returns></returns>
        public async Task<IList<InventoryChannelModel>> GetShipmentStatusListAsync()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='OUTBOUND_STS' ";
            var lists = await DBHelper.ExcuteAsycnList<InventoryChannelModel>(sql);
            return lists;
        }

        /// <summary>
        /// 销售渠道
        /// </summary>
        /// <returns></returns>
        public IList<InventoryChannelModel> GetInventoryChannelList()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='INVENTORY_CHANNEL' ";
            var lists = DBHelper.ExcuteList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 仓库列表
        /// </summary>
        /// <returns></returns>
        public IList<InventoryChannelModel> GetWarehouseList()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='WAREHOUSE' AND ACTIVE='Y' ";
            var lists = DBHelper.ExcuteList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 库存区域
        /// </summary>
        /// <returns></returns>
        public IList<InventoryChannelModel> GetZoneList()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='ZONE' ";
            var lists = DBHelper.ExcuteList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 库存状态
        /// </summary>
        /// <returns></returns>
        public IList<InventoryChannelModel> GetInventoryStatusList()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='INVENTORY_STS' ";
            var lists = DBHelper.ExcuteList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 入库类型
        /// </summary>
        /// <returns></returns>
        public IList<InventoryChannelModel> GetReceiptTypeList()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='RECEIPT_TYPE' AND ACTIVE='Y'";
            var lists = DBHelper.ExcuteList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 收货状态
        /// </summary>
        /// <returns></returns>
        public IList<InventoryChannelModel> GetInboundStatusList()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='INBOUND_STS' ";
            var lists = DBHelper.ExcuteList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 承运商
        /// </summary>
        /// <returns></returns>
        public IList<InventoryChannelModel> GetCarrierList()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='CARRIER' ";
            var lists = DBHelper.ExcuteList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 订单类型
        /// </summary>
        /// <returns></returns>
        public IList<InventoryChannelModel> GetShipmentTypeList()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='SHIPMENT_TYPE'  AND ACTIVE='Y' ";
            var lists = DBHelper.ExcuteList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 订单模式 （单品或者多品）
        /// </summary>
        /// <returns></returns>
        public IList<InventoryChannelModel> GetOrderTypeList()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='SHIPMENT_TYPE'  AND ACTIVE='Y' ";
            var lists = DBHelper.ExcuteList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 订单处理类型
        /// </summary>
        /// <returns></returns>
        public IList<InventoryChannelModel> GetShipmentProcessTypeList()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='SHP_PROCESS_TYPE' ";
            var lists = DBHelper.ExcuteList<InventoryChannelModel>(sql);
            return lists;
        }
        /// <summary>
        /// 订单状态
        /// </summary>
        /// <returns></returns>
        public IList<InventoryChannelModel> GetShipmentStatusList()
        {
            string sql = @"SELECT DESCRIPTION,IDENTIFIER FROM DBO.GENERIC_CONFIG_DETAIL WHERE RECORD_TYPE='OUTBOUND_STS' ";
            var lists = DBHelper.ExcuteList<InventoryChannelModel>(sql);
            return lists;
        }
    }
}
