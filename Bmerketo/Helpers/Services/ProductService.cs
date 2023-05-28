using Bmerketo.Contexts;
using Bmerketo.Helpers.Repositories;
using Bmerketo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bmerketo.Helpers.Services;

public class ProductService
{
    private readonly ProductRepository _productRepository;
    private readonly ProductCategoryRepository _productCategoryRepository;
    private readonly DataContext _context;

    public ProductService(ProductRepository productRepository, ProductCategoryRepository productCategoryRepository, DataContext context)
    {
        _productRepository = productRepository;
        _productCategoryRepository = productCategoryRepository;
        _context = context;
    }

    public async Task<bool> AddAsync(ProductEntity entity)
    {
        var _entity = await _productRepository.GetAsync(x => x.ArticleNumber == entity.ArticleNumber);
        if (_entity == null)
        {
            _entity = await _productRepository.AddAsync(entity);
            if(_entity != null)
                return true;
        }

        return false;
    }

    public async Task AddProductCategoriesAsync(ProductEntity entity, string[] categories)
    {
        foreach(var category in categories) 
        {
            await _productCategoryRepository.AddAsync(new ProductCategoryEntity
            {
                ArticleNumber = entity.ArticleNumber,
                CategoryId = int.Parse(category)
            });
        }
    }

    public async Task<bool> ArticleNumberExistsAsync(string articleNumber)
    {
        bool articleNumberExists = await _context.Products.AnyAsync(x => x.ArticleNumber == articleNumber);
        return articleNumberExists;
    }

}