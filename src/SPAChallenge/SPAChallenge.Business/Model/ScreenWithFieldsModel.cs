using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPAChallenge.Business.Model
{
    using SPAChallenge.Business.Persistence;

    public class ScreenWithFieldsModel : ScreenModel
    {
        public string LastUpdate { get; set; }
        public List<FieldModel> Fields { get; set; }
    }
}
