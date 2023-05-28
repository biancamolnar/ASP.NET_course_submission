using Bmerketo.Contexts;
using Bmerketo.Models.Entities;

namespace Bmerketo.Helpers.Repositories;

public class ProductCategoryRepository : Repo<ProductCategoryEntity>
{
    public ProductCategoryRepository(DataContext context) : base(context)
    {
    }
}
