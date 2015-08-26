using LGG.MyCase.Infra.Data.Repositories.EntityFramework;
using System;

namespace LGG.MyCase.Infra.Data
{
    public class UnitOfWork : IDisposable
    {
        private MyCaseContext _context = new MyCaseContext();

        private GenreRepository _genreRepository;
        public GenreRepository GenreRepository
        {
            get
            {
                if (_genreRepository == null)
                    _genreRepository = new GenreRepository(_context);
                return _genreRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}