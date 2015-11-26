using LGG.MyCase.Domain.Scopes;

namespace LGG.MyCase.Domain.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; private set; }

        public Artist()
        {
        }
        public Artist(string name)
        {
            this.Name = name;
        }

        public void ValidateSave()
        {
            //this.SaveScopeIsValid();
        }
    }
}