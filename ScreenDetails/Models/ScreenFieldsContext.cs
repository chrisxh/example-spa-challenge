using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ScreenDetails.Models
{
    /// <summary>
    /// ScreenFieldsContext
    /// </summary>
    public class ScreenFieldsContext: DbContext
    {
        /// <summary>
        /// ScreenFieldsContext
        /// </summary>
        public ScreenFieldsContext() : base("name=DefaultConnection") { }

        /// <summary>
        /// Screens
        /// </summary>
        public DbSet<Screen> Screens{get;set;}

        /// <summary>
        /// Fields
        /// </summary>
        public DbSet<Field> Fields { get; set; }
    }
}