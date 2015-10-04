using LGG.MyCase.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace LGG.MyCase.Data.Infra.Data.EntityFramework.Configuration
{
    public class ArtistConfiguration : EntityTypeConfiguration<Artist>
    {
        public ArtistConfiguration()
        {
            Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}