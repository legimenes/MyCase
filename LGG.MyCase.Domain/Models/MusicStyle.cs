namespace LGG.MyCase.Domain.Models
{
    public class MusicStyle
    {
        public int Id { get; set; }
        public int MusicId { get; set; }
        public virtual Music Music { get; set; }
        public int StyleId { get; set; }
        public virtual Style Style { get; set; }
    }
}