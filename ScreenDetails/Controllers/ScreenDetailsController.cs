using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using ScreenDetails.Models;

namespace ScreenDetails.Controllers
{
    /// <summary>
    /// ScreenDetailsController class
    /// </summary>
    public class ScreenDetailsController : ApiController
    {
        private ScreenFieldsContext db = new ScreenFieldsContext();

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Get Web api
        /// </summary>
        /// <returns></returns>
        [ResponseType(typeof(Screen))]
        public IEnumerable<Screen> Get()
        {
            var screens = this.db.Screens.Include("Fields").AsQueryable();
            return screens;
        }

    }
}
