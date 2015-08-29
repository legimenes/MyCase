using LGG.MyCase.SharedKernel.Resources;
using LGG.MyCase.SharedKernel.Validation;
using System.Collections.Generic;

namespace LGG.MyCase.Domain.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Style> Styles { get; set; }

        public void Validate()
        {
            AssertionConcern.AssertArgumentNotEmpty(this.Description, Errors.EmptyGenreDescription);
        }
    }
}