using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Challenge.Models
{
    public class Screen
    {
    //"ID": 8991,
    //  "Name": "EPAY",
    //  "System": "PAYROLL",
    //  "Title": "Employee Payment List",
    //  "LastUpdate": "Wed Jan 28 11:44:16 +0000 2015"
        public Screen()
        {
            Fields = new List<Field>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int ID { get; set; }
        public string  Name { get; set; }
        public string System { get; set; }
        public string Title { get; set; }
        
        public DateTime  LastUpdated { get; set; }
        public  ICollection<Field> Fields { get; set; }
    }
}