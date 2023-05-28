using Bmerketo.Contexts;
using Bmerketo.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Bmerketo.Helpers.Repositories;

public class ProductRepository : Repo<ProductEntity>
{
    private readonly DataContext _context;
    public ProductRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public async Task<ProductEntity> CreateAsync(ProductEntity entity)
    {
        _context.Products.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }


    public override async Task<IEnumerable<ProductEntity>> GetAllAsync()
    {
        var products = await _context.Products.Include(x => x.ProductCategories).ThenInclude(x => x.Category).OrderByDescending(x => x.Created).ToListAsync();
        return products;
    }

    public override async Task<ProductEntity> GetAsync(Expression<Func<ProductEntity, bool>> predicate)
    {
        var product = await _context.Products.Include(x => x.ProductCategories).ThenInclude(x => x.Category).FirstOrDefaultAsync(predicate);
        return product!;
    }

    public async Task<ProductEntity> GetLatestAsync()
    {
        var latestProduct = await _context.Products.OrderByDescending(x => x.Created).FirstOrDefaultAsync();
        return latestProduct!;
    }
}
