using Route_Groups_AspNet.Common;
using Route_Groups_AspNet.Model;
using Route_Groups_AspNet.Services.Interfaces;

namespace Route_Groups_AspNet.Endpoints.Categories;

public class CreateCategoryEndPoint : IEndpoint
{
    public static void MapRoute(IEndpointRouteBuilder app)
        => app.MapPost("/create", HanderAsync);

    private static async Task<IResult> HanderAsync(ICategoryService service, Category req)
    {
        //ver se o category já esta cadastrada
    
        Category category = new(req.Title, req.Url);
        //fake load
        await Task.Delay(2000);

        return Results.Ok(category);
    }
}