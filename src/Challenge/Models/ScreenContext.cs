using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Challenge.Models
{
    public class ScreenContext : DbContext
    {
        public ScreenContext()
        {
            this.Configuration.LazyLoadingEnabled = false; 
        }
       

        public DbSet<Screen> Screens { get; set; }
        public DbSet<Field> Fields { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Screen>()
                .HasMany(c => c.Fields);
        }
    }
}