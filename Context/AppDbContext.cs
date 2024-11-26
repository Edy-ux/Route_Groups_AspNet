using Microsoft.EntityFrameworkCore;
using Route_Groups_AspNet.Model;
using System.Reflection.Emit;

namespace Route_Groups_AspNet.Context;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{

    //public DbSet<Category> Categories { get; set; }A
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
