using Route_Groups_AspNet.Common;
using Route_Groups_AspNet.Dtos;

namespace Route_Groups_AspNet.Endpoints.Categories;

public class CreateCategoryEndPoint : IEndpoint
{
    public static void MapRoute(IEndpointRouteBuilder app)
        => app.MapPost("/create", HanderAsync);

    private static async Task<IResult> HanderAsync(Category request)
    {
        //ver se o category já esta cadastrado
        //verifica email X
        return Results.Ok(await Task.FromResult(new Category
        {
            Name = request.Name,
            Description = request.Description,
        }));
    }
}