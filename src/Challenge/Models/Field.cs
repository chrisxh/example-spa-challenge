using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Challenge.Models
{
    public enum EnumStatus
    {
        Visible, Hidden, Disabled
    }

    public class Field
    {
        //"ID": 21053,
        //      "Name": "_TRANNO",
        //      "Caption": "TRANNO",
        //      "Status": "Visible",
        //      "Tooltip": "Enter transaction number",
        //      "LastUpdate": "Mon Jan 26 03:35:21 +0000 2015"
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public string ToolTip { get; set; }
        public DateTime LastUpdated { get; set; }
        public EnumStatus Status { get; set; }
    }
}