using LGG.MyCase.Domain.Entities;
using System;
using System.Collections.Generic;

namespace LGG.MyCase.Domain.Interfaces.Repositories
{
    public interface IGenreRepository : IDisposable
    {
        IEnumerable<Genre> GetGenres();
        Genre GetGenre(int id);
        bool GenreExists(int id, string description);
        void Create(Genre genre);
        void Update(Genre genre);
        void Delete(Genre genre);
    }
}