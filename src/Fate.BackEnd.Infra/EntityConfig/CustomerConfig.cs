using Fate.BackEnd.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace Fate.BackEnd.Infra.EntityConfig
{
    public class CustomerConfig : EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            HasKey(c => c.Id);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(30);

            Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength();

            Property(c => c.Birthday)
                .IsRequired();

            Property(c => c.Age)
                .IsRequired();

            HasOptional(c => c.Occupation);

            ToTable("Customers");
        }
    }
}
