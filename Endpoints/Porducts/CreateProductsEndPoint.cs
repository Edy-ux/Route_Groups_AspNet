using Route_Groups_AspNet.Common.Extensions.Http;

namespace Route_Groups_AspNet.Endpoints.Porducts;

public class CreateProductsEndPoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
        => app.MapPost("/", () => { });
}