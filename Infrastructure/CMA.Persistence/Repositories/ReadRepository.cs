using CMA.Application.Repositories;
using CMA.Domain.Entities.Common;
using CMA.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CMA.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly CafeManagementAPIDbContext _context;

        public ReadRepository(CafeManagementAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> DbTable => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = DbTable.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = DbTable.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = DbTable.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        //=> await DbTable.FirstOrDefaultAsync(entity => entity.Id == Guid.Parse(id));
        //=> await DbTable.FindAsync(Guid.Parse(id));
        {
            var query = DbTable.AsQueryable();
            if (!tracking)
                query = DbTable.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        }
    }
}
