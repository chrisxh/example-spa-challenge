using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPAChallenge.Controllers
{
    using SPAChallenge.Business;
    using SPAChallenge.Business.Model;
    using SPAChallenge.Business.Persistence;

    public class ScreensController : ApiController
    {
        public IEnumerable<ScreenModel> Get()
        {
            var repository = new Repository();
            return repository.GetScreens();
        }

        public ScreenWithFieldsModel Get(int id)
        {
            var repository = new Repository();
            return repository.GetScreen(id);
        }
    }
}
