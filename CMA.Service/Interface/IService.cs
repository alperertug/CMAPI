using CMA.Core.ServiceResult;

namespace CMA.Service.Interface
{
    public interface IService<T> where T : class
    {
        Task<ServiceResult<T>> GetByIdAsync(int id);
        Task<ServiceResult<IEnumerable<T>>> GetAllAsync();
        Task<ServiceResult<T>> AddAsync(T entity);
        Task<ServiceResult> UpdateAsync(T entity);
        Task<ServiceResult> DeleteAsync(int id);
    }
}
