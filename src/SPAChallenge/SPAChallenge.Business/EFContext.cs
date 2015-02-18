namespace SPAChallenge.Business
{
    using System.Configuration;
    using System.Data.Entity;
    using SPAChallenge.Business.Persistence;

    public class EFContext : DbContext
    {
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Field> Fields { get; set; }

        public EFContext()
            : base(ConfigurationManager.ConnectionStrings["SPAChallengeContext"].ConnectionString)
        {
            Database.SetInitializer(new CreateDBInitializer());
        }
    }
}
