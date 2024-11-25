using Route_Groups_AspNet.Common;

namespace Route_Groups_AspNet.Endpoints.Categories;

public class GetCategoryEndpoint : IEndpoint
{
    public static void MapRoute(IEndpointRouteBuilder app)
        => app.MapGet("/", () => { });
}