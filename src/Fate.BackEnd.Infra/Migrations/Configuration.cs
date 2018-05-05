namespace Fate.BackEnd.Infra.Migrations
{
    using System.Data.Entity.Migrations;
    using Fate.BackEnd.Infra.Context;

    internal sealed class Configuration : DbMigrationsConfiguration<InfraContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(InfraContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
