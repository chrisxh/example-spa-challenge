using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Data.Entity;

namespace Challenge.Controllers
{
    [RoutePrefix("api/Screen")]
    public class ScreenController : ApiController
    {
        Models.ScreenContext context = new Models.ScreenContext();

        // GET: api/Screen
        [Route("GetScreenList")]
        public async Task<IHttpActionResult> GetScreenList()
        {

            var data = await context.Screens.ToListAsync();
            return Json(new { data = data });
        }
        [Route("Fields")]
        public async Task<IHttpActionResult> GetFields(int Id)
        {
            //we are using findasync. 
            var obj = context.Screens.Include(a => a.Fields).FirstAsync(a => a.ID == Id);
            var feilds = obj.Result.Fields.ToList();
            return Json(feilds);
        }
       
    }
}
