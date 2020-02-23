using Autofac;
using Autofac.Integration.Mvc;
using Honotop.WMS.Service.Configs;
using Honotop.WMS.Service.Inventory;
using Honotop.WMS.Service.ReceiptOrders;
using Honotop.WMS.Service.ShipmentOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Honotop.WMS
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var builder = new ContainerBuilder();

            builder.RegisterType<ReceiptOrderService>().As<IReceiptOrderService>();
            builder.RegisterType<ShipmentService>().As<IShipmentService>();
            builder.RegisterType<InventoryService>().As<IInventoryService>();
            builder.RegisterType<ConfigService>().As<IConfigService>();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
