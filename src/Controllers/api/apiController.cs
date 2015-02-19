using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SPASampleApp.Controllers.api
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class apiController : ApiController
    {
        public string GetScreens()
        {
            return new Models.api.Screens().loadScreens();
        }

        public string GetFields(int id)
        {
            return new Models.api.Screens().loadFields(id);
        }
    }
}
