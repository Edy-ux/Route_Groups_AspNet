using Route_Groups_AspNet.Endpoints.Categories;
using Route_Groups_AspNet.Endpoints.Porducts;

namespace Route_Groups_AspNet.Common.Extensions.Http;

public static class EndPoints
{
    public static void MapEndPoints(this WebApplication app)
    {
        var endpoints = app.MapGroup("api/v1/");
        
        endpoints.MapGroup("/categories")
            .WithTags("Categories")
            // .RequireAuthorization()
            .MapEndPoint<CreateCategoryEndPoint>()
            .MapEndPoint<GetCategoryEndpoint>();
        
        endpoints.MapGroup("/")
            .WithTags("Health Check")
            .MapGet("/check",() => 
                 new { Message = "Health Check OK"});
        
        endpoints.MapGroup("/products")
            .WithTags("Products")
            .RequireAuthorization()
            .MapEndPoint<CreateProductsEndPoint>()
            .MapEndPoint<GetProductsEndPoint>();
    }

    private static IEndpointRouteBuilder MapEndPoint<TEndPoint>(this IEndpointRouteBuilder app)
        where TEndPoint : IEndpoint
    {
        TEndPoint.Map(app);
        return app;
    }
}