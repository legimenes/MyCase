using System.Collections.Generic;
using LGG.MyCase.Domain.Scopes;

namespace LGG.MyCase.Domain.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Style> Styles { get; set; }

        public Genre()
        {
        }

        public bool Save()
        {
            return this.SaveScopeIsValid();
        }
    }
}