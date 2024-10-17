using CMA.Domain.Entities;
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
    }
}
