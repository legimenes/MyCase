using LGG.MyCase.Domain.Entities;
using System.Collections.Generic;

namespace LGG.MyCase.Domain.Tests.Database
{
    public class FakeDB
    {
        public ICollection<Genre> Genres { get; set; }

        public FakeDB()
        {
            #region <Genres>
            Genres = new List<Genre>
            {
                new Genre { Id = 1, Description = "Dance Music" },
                new Genre { Id = 2, Description = "Rock" },
                new Genre { Id = 3, Description = "Pop" }
            };
            #endregion
        }
    }
}