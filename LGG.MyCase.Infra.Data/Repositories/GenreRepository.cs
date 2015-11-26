using LGG.MyCase.Domain.Contracts.Repositories;
using LGG.MyCase.Domain.Entities;
using LGG.MyCase.Infra.Data.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LGG.MyCase.Infra.Data.EntityFramework.Repositories
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
        public bool GenreExists(int id, string description)
        {
            return _context.Genres.Any(g => g.Description.ToLower() == description.ToLower() && g.Id != id);
        }
        public bool Create(Genre genre)
        {
            _context.Genres.Add(genre);
            return true;
        }
        public bool Update(Genre genre)
        {
            _context.Entry<Genre>(genre).State = EntityState.Modified;
            return true;
        }
        public bool Delete(Genre genre)
        {
            _context.Entry<Genre>(genre).State = EntityState.Deleted;
            return true;
        }
        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}