using LGG.MyCase.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace LGG.MyCase.Data.Infra.Configurations.EntityFramework
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