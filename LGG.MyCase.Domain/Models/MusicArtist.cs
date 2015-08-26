namespace LGG.MyCase.Domain.Models
{
    public class MusicArtist
    {
        public int Id { get; set; }
        public int MusicId { get; set; }
        public virtual Music Music { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
        public GuestCredit? GuestCredit { get; set; }
    }
}