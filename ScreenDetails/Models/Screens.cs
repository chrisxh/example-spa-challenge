using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Http.Description;

namespace ScreenDetails.Models
{
    /// <summary>
    /// Class Scren
    /// </summary>
    public class Screen
    {
        /// <summary>
        /// Id of screen
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// System
        /// </summary>
        public string System { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// LastUpdated
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Associated Fields
        /// </summary>
        public List<Field> Fields { get; set; }
    }
}