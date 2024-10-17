using CMA.Core.ServiceResult;
using CMA.DataAccess.Repository.Interface;
using CMA.DataAccess.UoW;
using CMA.Service.Interface;

namespace CMA.Service.Concrete
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ServiceResult<T>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity != null)
            {
                return ServiceResult<T>.SuccessResult(entity);
            }
            return ServiceResult<T>.ErrorResult("Entity not found");
        }

        public async Task<ServiceResult<IEnumerable<T>>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return ServiceResult<IEnumerable<T>>.SuccessResult(entities);
        }

        public async Task<ServiceResult<T>> AddAsync(T entity)
        {
            try
            {
                await _repository.AddAsync(entity);
                await _unitOfWork.SaveChangesAsync();
                return ServiceResult<T>.SuccessResult(entity, "Entity added successfully");
            }
            catch (Exception ex)
            {
                return ServiceResult<T>.ErrorResult($"Error adding entity: {ex.Message}");
            }
        }

        public async Task<ServiceResult> UpdateAsync(T entity)
        {
            try
            {
                _repository.Update(entity);
                await _unitOfWork.SaveChangesAsync();
                return new ServiceResult { Success = true, Message = "Entity updated successfully" };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Success = false, Message = $"Error updating entity: {ex.Message}" };
            }
        }

        public async Task<ServiceResult> DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
            {
                return new ServiceResult { Success = false, Message = "Entity not found" };
            }

            try
            {
                _repository.Delete(entity);
                await _unitOfWork.SaveChangesAsync();
                return new ServiceResult { Success = true, Message = "Entity deleted successfully" };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Success = false, Message = $"Error deleting entity: {ex.Message}" };
            }
        }
    }

}
