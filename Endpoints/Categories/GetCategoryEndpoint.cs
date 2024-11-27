using Microsoft.AspNetCore.Mvc;
using Route_Groups_AspNet.Common;
using Route_Groups_AspNet.Model;
using Route_Groups_AspNet.Services.Interfaces;

namespace Route_Groups_AspNet.Endpoints.Categories;

public class GetCategoryEndpoint : IEndpoint
{
    public static void MapRoute(IEndpointRouteBuilder app)
        => app.MapGet("/GetAll", HanderAsync);

    private static async Task<IEnumerable<Category>> HanderAsync(ICategoryService service)
    {
        var categories = await service.GetAsync();

        if (!categories.Any())
            return Enumerable.Empty<Category>();

        return categories;
    }
}