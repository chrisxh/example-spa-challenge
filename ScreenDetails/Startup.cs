using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(ScreenDetails.Startup))]

namespace ScreenDetails
{
    /// <summary>
    /// Startup calss
    /// </summary>
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
