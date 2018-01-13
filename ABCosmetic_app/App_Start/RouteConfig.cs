using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ABCosmetic_app
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
   
            routes.MapRoute(
          name: "Account Action",
          url: "account/{action}",
              defaults: new { controller = "Account", action = "Index" }
          );

            routes.MapRoute(
              name: "Shop Action",
              url: "shop/{index}",
              defaults: new { controller = "Home", action = "Shop", index = UrlParameter.Optional }
          );

            routes.MapRoute(
              name: "Detail Product",
              url: "detail/",
              defaults: new { controller = "Home", action = "Detail"}
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional}
            );


        }
    }
}
