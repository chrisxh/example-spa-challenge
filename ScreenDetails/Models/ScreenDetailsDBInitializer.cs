  using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

namespace ScreenDetails.Models
{
    /// <summary>
    /// ScreenDetailsDBInitializer
    /// </summary>
    public class ScreenDetailsDBInitializer : CreateDatabaseIfNotExists<ScreenFieldsContext>
    {
        /// <summary>
        /// Seed
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(ScreenFieldsContext context)
        {
            base.Seed(context);
            var screens = new List<Screen>();

            screens.Add(new Screen
            {
                Name = "EPAY",
                System = "PAYROLL",
                Title = "Employee Payment List",
                LastUpdated = DateTime.Now,
                Fields = (new Field[] { 
                new Field{ Caption="Caption 1", Name="Caption1",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 1"},
                new Field{ Caption="Caption 2", Name="Cation2",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 2"},
                new Field{ Caption="Caption 3", Name="Caption3",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 3"},
                new Field{ Caption="Caption 4", Name="Caption 4",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 4"},
                new Field{ Caption="Caption 5", Name="Caption 5",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 5"},
                new Field{ Caption="Caption 6", Name="Caption6",  Status=Status.Hidden, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 6"},
                new Field{ Caption="Caption 7", Name="Cation7",  Status=Status.Hidden, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 7"},
                new Field{ Caption="Caption 8", Name="Caption8",  Status=Status.Hidden, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 8"},
                new Field{ Caption="Caption 9", Name="Caption 9",  Status=Status.Disabled, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 9"},
                new Field{ Caption="Caption 10", Name="Caption 10",  Status=Status.Disabled, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 10"}
                               
                }).ToList()
            });

            screens.Add(new Screen
            {
                Name = "LHISTORY",
                System = "HR",
                Title = "History of Leaves",
                LastUpdated = DateTime.Now,
                Fields = (new Field[] { 
                new Field{ Caption="Caption 1", Name="Caption1",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 1"},
                new Field{ Caption="Caption 2", Name="Cation2",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 2"},
                new Field{ Caption="Caption 3", Name="Caption3",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 3"},
                new Field{ Caption="Caption 4", Name="Caption 4",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 4"},
                new Field{ Caption="Caption 5", Name="Caption 5",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 5"},
                new Field{ Caption="Caption 6", Name="Caption6",  Status=Status.Hidden, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 6"},
                new Field{ Caption="Caption 7", Name="Cation7",  Status=Status.Hidden, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 7"},
                new Field{ Caption="Caption 8", Name="Caption8",  Status=Status.Hidden, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 8"},
                new Field{ Caption="Caption 9", Name="Caption 9",  Status=Status.Disabled, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 9"},
                new Field{ Caption="Caption 10", Name="Caption 10",  Status=Status.Disabled, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 10"}
                               
                               
                }).ToList()
            });

            screens.Add(new Screen
            {
                Name = "PHISTORY",
                System = "PAYROLL",
                Title = "History Payment List",
                LastUpdated = DateTime.Now,
                Fields = (new Field[] { 
              new Field{ Caption="Caption 1", Name="Caption1",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 1"},
                new Field{ Caption="Caption 2", Name="Cation2",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 2"},
                new Field{ Caption="Caption 3", Name="Caption3",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 3"},
                new Field{ Caption="Caption 4", Name="Caption 4",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 4"},
                new Field{ Caption="Caption 5", Name="Caption 5",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 5"},
                new Field{ Caption="Caption 6", Name="Caption6",  Status=Status.Hidden, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 6"},
                new Field{ Caption="Caption 7", Name="Cation7",  Status=Status.Hidden, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 7"},
                new Field{ Caption="Caption 8", Name="Caption8",  Status=Status.Hidden, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 8"},
                new Field{ Caption="Caption 9", Name="Caption 9",  Status=Status.Disabled, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 9"},
                new Field{ Caption="Caption 10", Name="Caption 10",  Status=Status.Disabled, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 10"}
                               
                }).ToList()
            });
            screens.Add(new Screen
            {
                Name = "PARRT",
                System = "PAYROLL",
                Title = "Payroll Report Status",
                LastUpdated = DateTime.Now,
                Fields = (new Field[] { 
                new Field{ Caption="Caption 1", Name="Caption1",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 1"},
                new Field{ Caption="Caption 2", Name="Cation2",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 2"},
                new Field{ Caption="Caption 3", Name="Caption3",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 3"},
                new Field{ Caption="Caption 4", Name="Caption 4",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 4"},
                new Field{ Caption="Caption 5", Name="Caption 5",  Status=Status.Visible, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 5"},
                new Field{ Caption="Caption 6", Name="Caption6",  Status=Status.Hidden, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 6"},
                new Field{ Caption="Caption 7", Name="Cation7",  Status=Status.Hidden, LastUpdate=DateTime.Now, Tooltip="This is tool tip  for field 7"},
                new Field{ Caption="Caption 8", Name="Caption8",  Status=Status.Hidden, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 8"},
                new Field{ Caption="Caption 9", Name="Caption 9",  Status=Status.Disabled, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 9"},
                new Field{ Caption="Caption 10", Name="Caption 10",  Status=Status.Disabled, LastUpdate=DateTime.Now, Tooltip="This is tool tip for field 10"}
                               
                }).ToList()
            });

            screens.ForEach(a => context.Screens.Add(a));

            context.SaveChanges();
        }
    }
}