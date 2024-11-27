using Microsoft.EntityFrameworkCore;
using Route_Groups_AspNet.Context;

namespace Route_Groups_AspNet.Common.Extensions;

public static class DbContextDependecyInjection
{
    public static IServiceCollection AddDbContextDependencyInjection(this IServiceCollection services,
        IConfiguration configuration)
    {
        return services.AddDbContext<AppDbContext>(options
            => options.UseSqlite(configuration.GetConnectionString("DefaultConnection"),
                x => x.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));
    }
}