using Route_Groups_AspNet.Common;

namespace Route_Groups_AspNet.Endpoints.Porducts;

public class GetProductsEndPoint : IEndpoint
{
    public static void MapRoute(IEndpointRouteBuilder app)
        => app.MapGet("/", () => { });
}