using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Assignment_1_Football_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Football", action = "Football", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "AddDetails",
               url: "FootballController/AddDetails",
               defaults: new { controller = "Football", action = "AddDetails", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "ShowList",
               url: "FootballController/MatchDetails",
               defaults: new { controller = "Football", action = "MatchDetails", id = UrlParameter.Optional }
           );
        }
    }
}
