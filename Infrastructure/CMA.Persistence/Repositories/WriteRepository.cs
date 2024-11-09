using CMA.Application.Repositories;
using CMA.Domain.Entities.Common;
using CMA.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMA.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly CafeManagementAPIDbContext _context;

        public WriteRepository(CafeManagementAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> DbTable => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await DbTable.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> list)
        {
            await DbTable.AddRangeAsync(list);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry entityEntry = DbTable.Remove(model);
            return entityEntry.State != EntityState.Deleted;
        }
        public bool RemoveRange(List<T> list)
        {
            DbTable.RemoveRange(list);
            return true;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            T model = await DbTable.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            return Remove(model);
        }


        public bool Update(T model)
        {
            EntityEntry entityEntry = DbTable.Update(model);
            return entityEntry.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();

    }
}
