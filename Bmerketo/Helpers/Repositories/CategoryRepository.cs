using Bmerketo.Contexts;
using Bmerketo.Models.Entities;

namespace Bmerketo.Helpers.Repositories;

public class CategoryRepository : Repo<CategoryEntity>
{
    public CategoryRepository(DataContext context) : base(context)
    {
    }
}
