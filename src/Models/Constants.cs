using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPASampleApp.Models
{
    public class Constants
    {
        public static string BASE_URL
        {
            get
            {
#if DEBUG
                return "http://localhost/SPASampleApp";
#else
                return "http://localhost/SPASampleApp";
#endif
            }
        }
    }
}