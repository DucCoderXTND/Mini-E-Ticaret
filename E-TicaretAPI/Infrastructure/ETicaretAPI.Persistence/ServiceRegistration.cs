using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>
                (options => options.UseSqlServer(Configurations.ConnectionString));
        }
    }
}
