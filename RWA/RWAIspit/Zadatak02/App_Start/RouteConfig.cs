using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Zadatak02
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{idKategorija}/{idPotkategorija}",
                defaults: new { controller = "Proizvods", action = "Index", idKategorija = UrlParameter.Optional, idPotkategorija = UrlParameter.Optional }
            );
        }
    }
}
