using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CV_Project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { Controller = "information", Action = "AboutMe" });
            routes.MapRoute("RSkills", "RSkills", new { Controller = "information", Action = "Skills" });
            routes.MapRoute("RExperience", "RExperience", new { Controller = "information", Action = "Experience" });
            routes.MapRoute("RContactMe", "RContactMe", new { Controller = "information", Action = "ContactMe" });
        }
    }
}
