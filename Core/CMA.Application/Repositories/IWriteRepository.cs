using CMA.Domain.Entities.Common;

namespace CMA.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> list);
        bool Remove(T model);
        bool RemoveRange(List<T> list);
        Task<bool> RemoveAsync(string id);
        bool Update(T model);
        Task<int> SaveAsync();
    }
}
