using LGG.MyCase.Domain.Models;
using System;
using System.Collections.Generic;

namespace LGG.MyCase.Domain.Interfaces.Services
{
    public interface IGenreService : IDisposable
    {
        IEnumerable<Genre> GetGenres();
        Genre GetGenre(int id);
        void Save(Genre genre);
        void Delete(Genre genre);
    }
}