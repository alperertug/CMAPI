using CMA.Model;
using CMA.Model.ManyToMany;
using Microsoft.EntityFrameworkCore;

namespace CMA.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Table>()
            //    .HasMany(t => t.Orders)
            //    .WithOne(o => o.Table)
            //    .HasForeignKey(o => o.TableId);
        }

        public DbSet<Cafe> Cafes { get; set; }

        public DbSet<CafeUser> CafeUsers { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Table> Tables { get; set; }

        public DbSet<CafeCustomer> CafeCustomers { get; set; }
        public DbSet<OfferProduct> OfferProducts { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
    }
}
