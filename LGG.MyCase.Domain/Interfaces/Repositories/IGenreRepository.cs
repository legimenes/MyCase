using LGG.MyCase.Domain.Models;
using System;
using System.Collections.Generic;

namespace LGG.MyCase.Domain.Interfaces.Repositories
{
    public interface IGenreRepository : IDisposable
    {
        IEnumerable<Genre> GetGenres();
        Genre GetGenre(int id);
        void Create(Genre genre);
        void Update(Genre genre);
        void Delete(Genre genre);
    }
}