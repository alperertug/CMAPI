using CMA.Domain.Entities;
using CMA.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace CMA.Persistence.Contexts
{
    public class CafeManagementAPIDbContext : DbContext
    {
        public CafeManagementAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cafe> Cafes { get; set; }
        public DbSet<CafeUser> CafeUsers { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Table> Tables { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseEntity>();

            foreach (var entry in entries)
            {
                _ = entry.State switch
                {
                    EntityState.Added => entry.Entity.CreatedTime = DateTime.UtcNow,
                    EntityState.Modified => entry.Entity.UpdatedTime = DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
