using Route_Groups_AspNet.Services;
using Route_Groups_AspNet.Services.Interfaces;

namespace Route_Groups_AspNet.Common.Extensions.Services;

public static class ServicesDependencyInjection
{
    public static IServiceCollection AddServicesDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<ICategoryService, CategoryService>();
        return services;
    }
}


