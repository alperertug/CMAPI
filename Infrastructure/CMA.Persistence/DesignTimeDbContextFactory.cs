using CMA.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CMA.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CafeManagementAPIDbContext>
    {
        public CafeManagementAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<CafeManagementAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
