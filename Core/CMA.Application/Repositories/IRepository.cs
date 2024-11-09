using CMA.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace CMA.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> DbTable { get; }
    }
}
