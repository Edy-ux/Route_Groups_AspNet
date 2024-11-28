using Microsoft.AspNetCore.Mvc;
using Route_Groups_AspNet.Common.Extensions.Http;
using Route_Groups_AspNet.Model;
using Route_Groups_AspNet.Services.Interfaces;

namespace Route_Groups_AspNet.Endpoints.Categories;

public class GetCategoryEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
        => app.MapGet("/GetAll", HanderAsync);

    private static async Task<IEnumerable<Category>> HanderAsync(ICategoryService service)
    {
        var categories = await service.GetAsync();

        return !categories.Any()
            ? Enumerable.Empty<Category>().ToList()
            : categories;
    }
}