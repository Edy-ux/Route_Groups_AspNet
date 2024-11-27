using Microsoft.EntityFrameworkCore;
using Route_Groups_AspNet.Context;
using Route_Groups_AspNet.Model;
using Route_Groups_AspNet.Services.Interfaces;

namespace Route_Groups_AspNet.Services;

public class CategoryService(AppDbContext context) : ICategoryService
{
    private readonly AppDbContext _context = context;
    public Category InsertAsync(Category entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Category>> GetAsync()
    {
        return await _context.Categories
            .AsNoTracking()
            .ToListAsync();
    }
}