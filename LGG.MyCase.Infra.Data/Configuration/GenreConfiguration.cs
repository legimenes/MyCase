using LGG.MyCase.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace LGG.MyCase.Data.Infra.Data.EntityFramework.Configuration
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            ToTable("genres");
            Property(p => p.Description)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}