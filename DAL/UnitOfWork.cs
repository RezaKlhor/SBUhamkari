
using Models;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HamkariContext _context;

        public UnitOfWork(HamkariContext context)
        {
            _context = context;
            
        }

       

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}