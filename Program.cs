using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Route_Groups_AspNet.Common.Extensions;
using Route_Groups_AspNet.Context;
using Route_Groups_AspNet.Services;
using Route_Groups_AspNet.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContextDependencyInjection(builder.Configuration);
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Route Groups", Version = "v1" });
});

var app = builder.Build();
// middleware de autenticação
//app.UseAuthentication();
//middleware de autorização
//app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI();

app.MapEndPoints();


app.Run();