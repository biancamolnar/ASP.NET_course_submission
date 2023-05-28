using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bmerketo.Models.Entities;

public class ProductEntity
{
    [Key]
    public string ArticleNumber { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string? Ingress { get; set; } 
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;

    public ICollection<ProductCategoryEntity> ProductCategories { get; set; } = new HashSet<ProductCategoryEntity>();
}

