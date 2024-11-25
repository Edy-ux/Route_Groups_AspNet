using Microsoft.OpenApi.Models;
using Route_Groups_AspNet.Common.Extensions;
using Route_Groups_AspNet.Endpoints.Categories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Route Groups", Version = "v1" });
});

var app = builder.Build();
// middleware de autenticação
app.UseAuthentication();
//middleware de autorização
app.UseAuthorization();

app.UseSwagger();   
app.UseSwaggerUI();

app.MapEndPoints();


app.Run();
