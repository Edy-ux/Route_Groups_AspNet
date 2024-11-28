using Route_Groups_AspNet.Common.Extensions.Http;

namespace Route_Groups_AspNet.Endpoints.Porducts;

public class GetProductsEndPoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
        => app.MapGet("/", () => new { Message = "OK" });
}