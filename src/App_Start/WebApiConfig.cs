using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SPASampleApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes

            config.Routes.MapHttpRoute(
                name: "api/getScreens",
                routeTemplate: "api/getScreens",
                defaults: new { controller = "api", action = "GetScreens" }
            );

            config.Routes.MapHttpRoute(
                name: "api/getFields",
                routeTemplate: "api/getFields/{id}",
                defaults: new { controller = "api", action = "GetFields" }
            );

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
