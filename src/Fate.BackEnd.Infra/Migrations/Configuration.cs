namespace Fate.BackEnd.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using Fate.BackEnd.Domain.Models;
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

            context.Occupations.AddOrUpdate(
                new Occupation() { Description = "Programador" },
                new Occupation() { Description = "Analista" },
                new Occupation() { Description = "Gerente" },
                new Occupation() { Description = "Estagiário" },
                new Occupation() { Description = "QA" }
            );

            context.SaveChanges();

            context.Customers.AddOrUpdate(
                new Customer() { Name = "Luana", LastName = "Dias", Birthday = new DateTime(1980, 11, 11), Age = 37, CPF = "12345678901", OccupationId = 2 },
                new Customer() { Name = "Arthur", LastName = "Azevedo", Birthday = new DateTime(1990, 10, 22), Age = 27, CPF = "12345678901", OccupationId = 1 },
                new Customer() { Name = "Danilo", LastName = "Correia", Birthday = new DateTime(1995, 09, 15), Age = 22, CPF = "12345678901", OccupationId = 3 },
                new Customer() { Name = "Erick", LastName = "Rodrigues", Birthday = new DateTime(1975, 07, 03), Age = 42, CPF = "12345678901", OccupationId = 4 }
            );
        }
    }
}
