using Microsoft.OpenApi.Models;
using Route_Groups_AspNet.Common.Extensions.Http;
using Route_Groups_AspNet.Common.Extensions;
using Route_Groups_AspNet.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddInfraStructureModule(builder.Configuration);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Route Groups", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapEndPoints();


app.Run();

