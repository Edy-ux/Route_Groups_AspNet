using System.Data;
using Route_Groups_AspNet.Common.Extensions.Http;
using Route_Groups_AspNet.Services.Interfaces;

namespace Route_Groups_AspNet.Endpoints.Porducts;

public class DeleteProductEndPoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app.MapDelete("/delete/{id}", HandleAssync);

    private static async Task<IResult> HandleAssync(ICategoryService _service, Guid id)
    {
        await _service.DeleteAsync(id);
        return Results.Ok();
    }
}