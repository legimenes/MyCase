using LGG.MyCase.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace LGG.MyCase.Data.Infra.Data.ORM.EntityFramework.Configuration
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            Property(p => p.Description)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}