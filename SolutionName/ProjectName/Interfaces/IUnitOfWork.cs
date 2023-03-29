using ProjectName.Data.Entities;
using System.Net;

namespace ProjectName.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<ApplicationUser> Users { get; }
        int Complete();
    }
}
