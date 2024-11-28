using Route_Groups_AspNet.Common.Extensions.Infra;
using Route_Groups_AspNet.Common.Extensions.Services;

namespace Route_Groups_AspNet.Common.Extensions;

public static class InfraestructureModule
{
    public static IServiceCollection AddInfraEstructureModule(this IServiceCollection services,
        IConfiguration configuration)
    {
        return services.AddDbContextDependencyInjection(configuration)
                       .AddServicesDependencyInjection();
    }
}