using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge.Models
{
    public class ScreenInitializer : System.Data.Entity.DropCreateDatabaseAlways<ScreenContext>
    {

        public ScreenInitializer()
        {

        }
        protected override void Seed(ScreenContext context)
        {

            Screen screen = new Screen() { Name = "EPAY", System = "PAYROLL", Title = "Employee Payment List", LastUpdated = DateTime.Now };


            screen.Fields.Add(new Field { Caption = "EPAYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "EPAYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "EPAYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "EPAYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "EPAYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "EPAYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Hidden });
            screen.Fields.Add(new Field { Caption = "EPAYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Hidden });
            screen.Fields.Add(new Field { Caption = "EPAYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Hidden });
            screen.Fields.Add(new Field { Caption = "EPAYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Disabled }); 
            screen.Fields.Add(new Field { Caption = "EPAYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Disabled });
           

            context.Screens.Add(screen);

            screen = new Screen() { Name = "LHISTORY", System = "HR", Title = "History of Leaves", LastUpdated = DateTime.Now };

            screen.Fields.Add(new Field { Caption = "LHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "LHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "LHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "LHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "LHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "LHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Hidden });
            screen.Fields.Add(new Field { Caption = "LHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Hidden });
            screen.Fields.Add(new Field { Caption = "LHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Hidden });
            screen.Fields.Add(new Field { Caption = "LHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Disabled });
            screen.Fields.Add(new Field { Caption = "LHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Disabled });
          

            context.Screens.Add(screen);




            screen = new Screen() { Name = "PHISTORY", System = "PAYROLL", Title = "History Payment List", LastUpdated = DateTime.Now };


            screen.Fields.Add(new Field { Caption = "PHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "PHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "PHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "PHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "PHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "PHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Hidden });
            screen.Fields.Add(new Field { Caption = "PHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Hidden });
            screen.Fields.Add(new Field { Caption = "PHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Hidden });
            screen.Fields.Add(new Field { Caption = "PHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Disabled });
            screen.Fields.Add(new Field { Caption = "PHISTORYFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Disabled });
            context.Screens.Add(screen);



            screen = new Screen() { Name = "PARRT", System = "PAYROLL", Title = " Payroll Report Status", LastUpdated = DateTime.Now };

            screen.Fields.Add(new Field { Caption = "PARRTFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "PARRTFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "PARRTFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "PARRTFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "PARRTFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Visible });
            screen.Fields.Add(new Field { Caption = "PARRTFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Hidden });
            screen.Fields.Add(new Field { Caption = "PARRTFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Hidden });
            screen.Fields.Add(new Field { Caption = "PARRTFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Hidden });
            screen.Fields.Add(new Field { Caption = "PARRTFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Disabled });
            screen.Fields.Add(new Field { Caption = "PARRTFIELD", LastUpdated = DateTime.Now, Name = "SomeField", ToolTip = "ToolTip", Status = EnumStatus.Disabled });
            
            context.Screens.Add(screen);

        }

    }
}