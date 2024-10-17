using CMA.DataAccess.Repository.Interface;

namespace CMA.DataAccess.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : class;
        Task<int> SaveChangesAsync();
    }
}
