using System.ComponentModel;

namespace LGG.MyCase.Domain.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Version { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public string Time { get; set; }
        public string Quality { get; set; }
        public short? Year { get; set; }
        public string AlbumPicturePath { get; set; }
    }

    public enum GuestCredit
    {
        [Description("feat.")]
        feat = 0,
        [Description("&")]
        and = 1
    }
}