using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Challenge.Models
{
    /// <summary>
    /// migration
    /// </summary>
    public class Configuration : DbMigrationsConfiguration<ScreenContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ScreenContext context)
        {
            var course = new Models.Screen();
            course.Name = "test";
            course.LastUpdated = DateTime.Now;
            context.Screens.Add(course);
            context.SaveChanges();
        }
    }
}