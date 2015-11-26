using LGG.MyCase.Domain.Entities;
using System;
using System.Collections.Generic;

namespace LGG.MyCase.Domain.Contracts.AppServices
{
    public interface IGenreAppService : IDisposable
    {
        bool Save(Genre genre);
        IEnumerable<Genre> GetGenres();
    }
}