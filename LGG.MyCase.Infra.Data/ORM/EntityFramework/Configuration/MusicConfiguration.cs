using LGG.MyCase.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace LGG.MyCase.Data.Infra.Data.ORM.EntityFramework.Configuration
{
    public class MusicConfiguration : EntityTypeConfiguration<Music>
    {
        public MusicConfiguration()
        {
            Property(p => p.Title)
                .HasMaxLength(50)
                .IsRequired();
            Property(p => p.Version)
                .HasMaxLength(50);
            Property(p => p.Time)
                .HasMaxLength(5)
                .IsRequired();
            Property(p => p.Quality)
                .HasMaxLength(4);
            Property(p => p.AlbumPicturePath)
                .HasMaxLength(255);
        }
    }
}