using Fate.BackEnd.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace Fate.BackEnd.Infra.EntityConfig
{
    public class OccupationConfig : EntityTypeConfiguration<Occupation>
    {
        public OccupationConfig()
        {
            HasKey(o => o.Id);

            Property(o => o.Description)
                .IsRequired()
                .HasMaxLength(100);

            ToTable("Occupations");
        }
    }
}
