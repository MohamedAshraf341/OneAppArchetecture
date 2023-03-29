using ProjectName.Data.Entities;
using ProjectName.Interfaces;
using System.Net;

namespace ProjectName.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseRepository<ApplicationUser> Users { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Users = new BaseRepository<ApplicationUser>(_context);
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
