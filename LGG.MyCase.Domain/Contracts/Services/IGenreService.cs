using LGG.MyCase.Domain.Entities;
using System;
using System.Collections.Generic;

namespace LGG.MyCase.Domain.Contracts.Services
{
    public interface IGenreService : IDisposable
    {
        //Genre GetGenre(int id);
        bool Save(Genre genre);
        IEnumerable<Genre> GetGenres();
        //bool Delete(Genre genre);
    }
}