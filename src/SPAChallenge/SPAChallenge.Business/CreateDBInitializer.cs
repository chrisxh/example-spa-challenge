namespace SPAChallenge.Business
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using SPAChallenge.Business.Persistence;

    public class CreateDBInitializer : CreateDatabaseIfNotExists<EFContext>
    {
        protected override void Seed(EFContext context)
        {
            base.Seed(context);
            var fieldsGenerator = new FieldsGenerator();
            Func<string, string, string, Screen> addScreen = (name, system, title) => new Screen()
                                                                                      {
                                                                                              Name = name,
                                                                                              System = system,
                                                                                              Title = title,
                                                                                              LastUpdate = DateTime.Now,
                                                                                              Fields = fieldsGenerator.Generate()
                                                                                      };
            context.Screens.Add(addScreen("EPAY", "PAYROLL", "Employee Payment List"));
            context.Screens.Add(addScreen("LHISTORY", "HR", "History of Leaves"));
            context.Screens.Add(addScreen("PHISTORY", "PAYROLL", "History Payment List"));
            context.Screens.Add(addScreen("PARRT", "PAYROLL", "Payroll Report Status"));
            context.SaveChanges();
        }
    }
}
