using LGG.MyCase.Infra.Data.Context;
using LGG.MyCase.SharedKernel.Interfaces.Transaction;

namespace LGG.MyCase.Infra.Data.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private MyCaseContext _context;

        public UnitOfWork(MyCaseContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
        }
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}