using LGG.MyCase.Data.Infra.Data.ORM.EntityFramework.Configuration;
using LGG.MyCase.Domain.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LGG.MyCase.Infra.Data.ORM.Context
{
    public class MyCaseContext : DbContext
    {
        public MyCaseContext()
            : base("MyCaseContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<MusicArtist> MusicArtists { get; set; }
        public DbSet<MusicStyle> MusicStyles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new GenreConfiguration());
            modelBuilder.Configurations.Add(new StyleConfiguration());
            modelBuilder.Configurations.Add(new ArtistConfiguration());
            modelBuilder.Configurations.Add(new MusicConfiguration());
        }
    }
}