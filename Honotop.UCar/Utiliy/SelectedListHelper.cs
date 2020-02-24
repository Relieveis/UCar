
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Honotop.WMS.Utiliy
{
    public class SelectedListHelper
    {
        public static IList<SelectListItem> GetSelectedItemList(SelectedListType type)
        {
            return null;
            //var list = new List<InventoryChannelModel>();
            //var configService = DependencyResolver.Current.GetService<IConfigService>();
            //switch (type)
            //{
            //    case SelectedListType.InboundStatusList:
            //        list = configService.GetInboundStatusList().ToList();
            //        break;
            //    case SelectedListType.CarrierList:
            //        list = configService.GetCarrierList().ToList();
            //        break;
            //    case SelectedListType.InventoryChannelList:
            //        list = configService.GetInventoryChannelList().ToList();
            //        break;
            //    case SelectedListType.OrderTypeList:
            //        list = configService.GetOrderTypeList().ToList();
            //        break;
            //    case SelectedListType.ReceiptTypeList:
            //        list = configService.GetReceiptTypeList().ToList();
            //        break;
            //    case SelectedListType.ShipmentProcessTypeList:
            //        list = configService.GetShipmentProcessTypeList().ToList();
            //        break;
            //    case SelectedListType.ShipmentStatusList:
            //        list = configService.GetShipmentStatusList().ToList();
            //        break;
            //    case SelectedListType.ShipmentTypeList:
            //        list = configService.GetShipmentTypeList().ToList();
            //        break;
            //    case SelectedListType.WarehouseList:
            //        list = configService.GetWarehouseList().ToList();
            //        break;
            //    case SelectedListType.ZoneList:
            //        list = configService.GetZoneList().ToList();
            //        break;
            //    case SelectedListType.InventoryStatusList:
            //        list = configService.GetInventoryStatusList().ToList();
            //        break;

            //    default:
            //        break;
            //}

            //var selectedLists = new List<SelectListItem>() { new SelectListItem() { Text = "--请选择--", Value = string.Empty } };
            //list?.ForEach(x => { selectedLists.Add(new SelectListItem() { Text = x.Description, Value = x.Identifier }); });

            //return selectedLists;
        }
    }



    public enum SelectedListType
    {
        InventoryChannelList,
        WarehouseList,
        ZoneList,
        InventoryStatusList,
        ReceiptTypeList,
        InboundStatusList,
        CarrierList,
        ShipmentTypeList,
        OrderTypeList,
        ShipmentProcessTypeList,
        ShipmentStatusList
    }


}