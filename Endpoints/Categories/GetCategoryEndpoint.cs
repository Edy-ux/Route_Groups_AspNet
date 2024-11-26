using Microsoft.AspNetCore.Mvc;
using Route_Groups_AspNet.Common;
using Route_Groups_AspNet.Model;
using Route_Groups_AspNet.Services.Interfaces;

namespace Route_Groups_AspNet.Endpoints.Categories;

public class GetCategoryEndpoint : IEndpoint
{
    public static void MapRoute(IEndpointRouteBuilder app)
    => app.MapGet("/GetAll", HanderAsync);

    private static  IEnumerable<Category> HanderAsync([FromServices] ICategoryService service)
    {
        var categories = service.GetAsync();

        if (!categories.Any())
              return Enumerable.Empty<Category>();

        return categories;
    }


}