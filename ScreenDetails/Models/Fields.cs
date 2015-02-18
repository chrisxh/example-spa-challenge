using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ScreenDetails.Models
{
    /// <summary>
    /// Field
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Id of field
        /// </summary>
        [Key, Column(Order = 1), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Tooltip
        /// </summary>
        public string Tooltip { get; set; }

        /// <summary>
        /// LastUpdate
        /// </summary>
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// ScreenId
        /// </summary>
        [Key, Column(Order = 0), ForeignKey("Screen")]
        public int ScreenId { get; set; }

        /// <summary>
        /// Screen
        /// </summary>
        [JsonIgnore]
        public Screen Screen { get; set; }


    }
}