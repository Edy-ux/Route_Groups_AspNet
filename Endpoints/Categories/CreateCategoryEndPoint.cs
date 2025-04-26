using Route_Groups_AspNet.Common.Extensions.Http;
using Route_Groups_AspNet.Models;
using Route_Groups_AspNet.Services.Interfaces;

namespace Route_Groups_AspNet.Endpoints.Categories;

public class CreateCategoryEndPoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app.MapPost("/create", HanderAsync);

    private static async Task<Category> HanderAsync(ICategoryService service, Category req)
    {
        //ver se o category já esta cadastrada
        Category category = new(req.Title, req.Url);
        //fake load
        await Task.Delay(1000);
        await service.InsertAsync(category);
        return category;
    }
}