using BackEnd.Data.Entities;
using System.Net;

namespace BackEnd.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<ApplicationUser> Users { get; }
        int Complete();
    }
}
