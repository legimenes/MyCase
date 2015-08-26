using LGG.MyCase.Domain.Interfaces.Repositories;
using LGG.MyCase.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LGG.MyCase.Infra.Data.Repositories.EntityFramework
{
    public class GenreRepository : IGenreRepository
    {
        private MyCaseContext _context;

        public GenreRepository(MyCaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _context.Genres.ToList();
        }

        public Genre GetGenre(int id)
        {
            return _context.Genres.Find(id);
        }

        public void Create(Genre genre)
        {
            _context.Genres.Add(genre);
        }

        public void Update(Genre genre)
        {
            _context.Entry<Genre>(genre).State = EntityState.Modified;
        }

        public void Delete(Genre genre)
        {
            _context.Entry<Genre>(genre).State = EntityState.Deleted;
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}