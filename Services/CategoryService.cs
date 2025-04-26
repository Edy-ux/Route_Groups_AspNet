using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Route_Groups_AspNet.Context;
using Route_Groups_AspNet.Models;
using Route_Groups_AspNet.Services.Interfaces;

namespace Route_Groups_AspNet.Services;

public class CategoryService(AppDbContext context) : ICategoryService
{
    private readonly AppDbContext _context = context;

    public async Task<Category> InsertAsync(Category entity)
    {
        var gategory = new Category(title: entity.Title, url: entity.Url);

        _context.Categories.Add(gategory);
        await _context.SaveChangesAsync();
        return gategory;
    }

    public async Task<IEnumerable<Category>> GetAsync()
    {
        return await _context.Categories
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<IResult> DeleteAsync(Guid id)
    {
        if (await _context.Categories.FindAsync(id) is Category category)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return Results.NoContent();
        }

        return Results.NotFound();
    }
}