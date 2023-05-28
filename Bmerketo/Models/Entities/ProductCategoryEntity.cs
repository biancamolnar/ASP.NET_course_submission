using Microsoft.EntityFrameworkCore;

namespace Bmerketo.Models.Entities;

[PrimaryKey("ArticleNumber", "CategoryId")]
public class ProductCategoryEntity
{
    public string ArticleNumber { get; set; } = null!;
    public ProductEntity Product { get; set; } = null!;
    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; } = null!;
}
