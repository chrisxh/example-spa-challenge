using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SPASampleApp.Data
{
    public enum Status
    {
        Visible = 0, Disabled = 1, Hidden = 2
    }

    public class MySeed : DropCreateDatabaseIfModelChanges<SPADemoContainer>
    {
        protected override void Seed(SPADemoContainer context)
        {
            //Screens
            var screen1 = context.Screens.Add(new Screen()
            {
                Name = "EPAY",
                System = "PAYROLL",
                Title = "Employee Payment List",
                LastUpdate = DateTime.UtcNow
            });

            var screen2 = context.Screens.Add(new Screen()
            {
                Name = "LHISTORY",
                System = "HR",
                Title = "History of Leaves",
                LastUpdate = DateTime.UtcNow
            });

            var screen3 = context.Screens.Add(new Screen()
            {
                Name = "PHISTORY",
                System = "PAYROLL",
                Title = "History Payment List",
                LastUpdate = DateTime.UtcNow
            });

            var screen4 = context.Screens.Add(new Screen()
            {
                Name = "PARRT",
                System = "PAYROLL",
                Title = "Payroll Report Status",
                LastUpdate = DateTime.UtcNow
            });

            //Fields - Screen 1
            context.Fields.Add(new Field()
            {
                Name = "_TRANNO",
                Caption = "TRANNO",
                Status = Status.Visible.ToString(),
                ToolTip = "Enter Transaction Number",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen1.Id
            });

            context.Fields.Add(new Field()
            {
                Name = "_TRANNAME",
                Caption = "TRANNAME",
                Status = Status.Visible.ToString(),
                ToolTip = "Enter Transaction Name",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen1.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "_TRANSTATUS",
                Caption = "TRANSTATUS",
                Status = Status.Visible.ToString(),
                ToolTip = "TRANSTATUS",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen1.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "_TRANTYPE",
                Caption = "TRANTYPE",
                Status = Status.Visible.ToString(),
                ToolTip = "TRANTYPE",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen1.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S1_5",
                Caption = "S1_5",
                Status = Status.Visible.ToString(),
                ToolTip = "S1_5",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen1.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S1_6",
                Caption = "S1_6",
                Status = Status.Disabled.ToString(),
                ToolTip = "S1_6",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen1.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S1_7",
                Caption = "S1_7",
                Status = Status.Disabled.ToString(),
                ToolTip = "S1_7",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen1.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S1_8",
                Caption = "S1_8",
                Status = Status.Hidden.ToString(),
                ToolTip = "",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen1.Id
            });

            context.Fields.Add(new Field()
            {
                Name = "S1_9",
                Caption = "S1_9",
                Status = Status.Hidden.ToString(),
                ToolTip = "",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen1.Id
            });

            context.Fields.Add(new Field()
            {
                Name = "S1_10",
                Caption = "S1_10",
                Status = Status.Hidden.ToString(),
                ToolTip = "",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen1.Id
            });

            //Fields - Screen 2
            context.Fields.Add(new Field()
            {
                Name = "S2_1",
                Caption = "S2_1",
                Status = Status.Visible.ToString(),
                ToolTip = "S2_1",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen2.Id
            });

            context.Fields.Add(new Field()
            {
                Name = "S2_2",
                Caption = "S2_2",
                Status = Status.Visible.ToString(),
                ToolTip = "S2_2",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen2.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S2_3",
                Caption = "S2_3",
                Status = Status.Visible.ToString(),
                ToolTip = "S2_3",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen2.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S2_4",
                Caption = "S2_4",
                Status = Status.Visible.ToString(),
                ToolTip = "S2_4",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen2.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S2_5",
                Caption = "S2_5",
                Status = Status.Visible.ToString(),
                ToolTip = "S2_5",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen2.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S2_6",
                Caption = "S2_6",
                Status = Status.Disabled.ToString(),
                ToolTip = "S2_6",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen2.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S2_7",
                Caption = "S2_7",
                Status = Status.Disabled.ToString(),
                ToolTip = "S2_7",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen2.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S2_8",
                Caption = "S2_8",
                Status = Status.Hidden.ToString(),
                ToolTip = "",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen2.Id
            });

            context.Fields.Add(new Field()
            {
                Name = "S2_9",
                Caption = "S2_9",
                Status = Status.Hidden.ToString(),
                ToolTip = "",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen2.Id
            });

            context.Fields.Add(new Field()
            {
                Name = "S2_10",
                Caption = "S2_10",
                Status = Status.Hidden.ToString(),
                ToolTip = "",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen2.Id
            });

            //Fields - Screen 3
            context.Fields.Add(new Field()
            {
                Name = "S3_1",
                Caption = "S3_1",
                Status = Status.Visible.ToString(),
                ToolTip = "S3_1",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen3.Id
            });

            context.Fields.Add(new Field()
            {
                Name = "S3_2",
                Caption = "S3_2",
                Status = Status.Visible.ToString(),
                ToolTip = "S3_2",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen3.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S3_3",
                Caption = "S3_3",
                Status = Status.Visible.ToString(),
                ToolTip = "S3_3",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen3.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S3_4",
                Caption = "S3_4",
                Status = Status.Visible.ToString(),
                ToolTip = "S3_4",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen3.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S3_5",
                Caption = "S3_5",
                Status = Status.Visible.ToString(),
                ToolTip = "S3_5",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen3.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S3_6",
                Caption = "S3_6",
                Status = Status.Disabled.ToString(),
                ToolTip = "S3_6",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen3.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S3_7",
                Caption = "S3_7",
                Status = Status.Disabled.ToString(),
                ToolTip = "S3_7",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen3.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S3_8",
                Caption = "S3_8",
                Status = Status.Hidden.ToString(),
                ToolTip = "",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen3.Id
            });

            context.Fields.Add(new Field()
            {
                Name = "S3_9",
                Caption = "S2_9",
                Status = Status.Hidden.ToString(),
                ToolTip = "",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen3.Id
            });

            context.Fields.Add(new Field()
            {
                Name = "S3_10",
                Caption = "S3_10",
                Status = Status.Hidden.ToString(),
                ToolTip = "",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen3.Id
            });

            //Fields - Screen 4
            context.Fields.Add(new Field()
            {
                Name = "S4_1",
                Caption = "S4_1",
                Status = Status.Visible.ToString(),
                ToolTip = "S4_1",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen4.Id
            });

            context.Fields.Add(new Field()
            {
                Name = "S4_2",
                Caption = "S4_2",
                Status = Status.Visible.ToString(),
                ToolTip = "S4_2",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen4.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S4_3",
                Caption = "S4_3",
                Status = Status.Visible.ToString(),
                ToolTip = "S4_3",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen4.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S4_4",
                Caption = "S4_4",
                Status = Status.Visible.ToString(),
                ToolTip = "S4_4",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen4.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S4_5",
                Caption = "S4_5",
                Status = Status.Visible.ToString(),
                ToolTip = "S4_5",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen4.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S4_6",
                Caption = "S4_6",
                Status = Status.Disabled.ToString(),
                ToolTip = "S4_6",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen4.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S4_7",
                Caption = "S4_7",
                Status = Status.Disabled.ToString(),
                ToolTip = "S4_7",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen4.Id
            });
            context.Fields.Add(new Field()
            {
                Name = "S4_8",
                Caption = "S4_8",
                Status = Status.Hidden.ToString(),
                ToolTip = "",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen4.Id
            });

            context.Fields.Add(new Field()
            {
                Name = "S4_9",
                Caption = "S2_9",
                Status = Status.Hidden.ToString(),
                ToolTip = "",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen4.Id
            });

            context.Fields.Add(new Field()
            {
                Name = "S4_10",
                Caption = "S4_10",
                Status = Status.Hidden.ToString(),
                ToolTip = "",
                LastUpdate = DateTime.UtcNow,
                ScreenId = screen4.Id
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}