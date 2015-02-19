using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Net.Http.Headers;

namespace SPASampleApp.Models.api
{
    public class Screens
    {
        public string loadScreens()
        {
            using (var conn = new SPASampleApp.Data.SPADemoContainer())
            {
                return JsonConvert.SerializeObject(conn.Screens.Take(5).ToList().OrderBy(s => s.System));
            }
        }

        public string loadFields(int screenId)
        {
            using (var conn = new SPASampleApp.Data.SPADemoContainer())
            {
                return JsonConvert.SerializeObject(conn.Fields.Where(s => s.ScreenId == screenId).ToList());
            }
        }
    }
}