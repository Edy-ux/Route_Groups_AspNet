using Route_Groups_AspNet.Endpoints.Categories;
using Route_Groups_AspNet.Endpoints.Porducts;

namespace Route_Groups_AspNet.Common.Extensions.Http;

public static class EndPoints
{
    public static void MapEndPoints(this WebApplication endPoints)
    {
        var endpoints = endPoints.MapGroup("api/v1/");

        endpoints.MapGroup("/categories")
            .WithTags("Categories")
            // .RequireAuthorization()
            .MapEndPoint<CreateCategoryEndPoint>()
            .MapEndPoint<GetCategoryEndpoint>()
            .MapEndPoint<DeleteProductEndPoint>();

        endpoints.MapGroup("/")
            .WithTags("Health Check")
            .MapGet("/check", () =>
                new { Message = "Application It´s Okay." });


        endPoints.MapGroup("/users")
            .WithTags("Users")
            .MapGet("create", () => "Created");

        endpoints.MapGroup("/products")
            .WithTags("Products")
            //.RequireAuthorization()
            .MapEndPoint<CreateProductsEndPoint>()
            .MapEndPoint<GetProductsEndPoint>();
    }

    private static IEndpointRouteBuilder MapEndPoint<TEndPoint>(this IEndpointRouteBuilder endPoint)
        where TEndPoint : IEndpoint
    {
        TEndPoint.Map(endPoint);
        return endPoint;
    }
}