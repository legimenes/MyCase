using LGG.MyCase.Domain.Entities;
using System;
using System.Collections.Generic;

namespace LGG.MyCase.Domain.Contracts.Repositories
{
    public interface IGenreRepository : IDisposable
    {
        IEnumerable<Genre> GetGenres();
        Genre GetGenre(int id);
        bool GenreExists(int id, string description);
        bool Create(Genre genre);
        bool Update(Genre genre);
        bool Delete(Genre genre);
    }
}