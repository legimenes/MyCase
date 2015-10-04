using LGG.MyCase.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace LGG.MyCase.Data.Infra.Data.EntityFramework.Configuration
{
    public class StyleConfiguration : EntityTypeConfiguration<Style>
    {
        public StyleConfiguration()
        {
            Property(p => p.Description)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}