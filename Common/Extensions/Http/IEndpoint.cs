namespace Route_Groups_AspNet.Common.Extensions.Http;

public interface IEndpoint
{
  public static abstract void Map(IEndpointRouteBuilder routeBuilder);
}