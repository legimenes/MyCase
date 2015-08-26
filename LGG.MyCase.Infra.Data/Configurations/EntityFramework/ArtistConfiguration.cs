using LGG.MyCase.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace LGG.MyCase.Data.Infra.Configurations.EntityFramework
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