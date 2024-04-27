using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ETicaretAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<DataContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder
                .UseSqlServer(Configurations.ConnectionString);
            return new(dbContextOptionsBuilder.Options);

        }
    }
}
