using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Challenge
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
          
            GlobalConfiguration.Configure(WebApiConfig.Register);
            var context = new Models.ScreenContext();
            Database.SetInitializer(new Models.ScreenInitializer());

          
            context.Database.Initialize(true);
        }
    }
}
