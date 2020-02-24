using Autofac;
using Autofac.Integration.Mvc;
using Honotop.UCar.Service.Cache;
using Honotop.UCar.Service.Customers;
using Honotop.UCar.Service.Permissions;
using Honotop.WMS.Service.ReceiptOrders;
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
            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<CacheService>().As<ICacheService>();
            builder.RegisterType<PermissionService>().As<IPermissionService>();


            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
