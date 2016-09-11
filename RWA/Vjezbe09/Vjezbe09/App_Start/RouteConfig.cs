using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vjezbe09
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "KalkulatorIzracunaj",
                url: "kalkulator/{operacija}/{a}/{b}",
                defaults: new { controller = "Kalkulator", action = "Racunaj", operacija = UrlParameter.Optional, a = UrlParameter.Optional, b = UrlParameter.Optional },
                constraints: new { a = @"\d+", b = @"\d+" }
                );

            routes.MapRoute(
                name: "Korijen",
                url: "korijen/{a}",
                defaults: new {controller = "Korijen", action = "Korijenuj", a = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Kalkulator",
                url: "kalkulator/{action}",
                defaults: new { controller = "Kalkulator", action = "KalkulatorIndex" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
