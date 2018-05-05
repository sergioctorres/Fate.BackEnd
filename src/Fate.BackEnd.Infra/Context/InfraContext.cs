﻿using Fate.BackEnd.Domain.Models;
using Fate.BackEnd.Infra.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Fate.BackEnd.Infra.Context
{
    public class InfraContext : DbContext
    {
        public InfraContext() //: base("")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Occupation> Occupations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new CustomerConfig());
            modelBuilder.Configurations.Add(new OccupationConfig());
        }
    }
}