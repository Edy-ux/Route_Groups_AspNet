namespace Route_Groups_AspNet.Common;

public interface IEndpoint
{
  public static abstract void MapRoute(IEndpointRouteBuilder routeBuilder);
}