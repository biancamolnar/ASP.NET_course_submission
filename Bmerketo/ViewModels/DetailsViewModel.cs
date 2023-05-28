using Bmerketo.Models.Entities;

namespace Bmerketo.ViewModels;

public class DetailsViewModel
{
    public DetailsViewModel(ProductEntity entity)
    {
        ArticleNumber = entity.ArticleNumber;
        Title = entity.Title;
        Ingress = entity.Ingress;
        Description = entity.Description;
        Price = entity.Price;
        ImageUrl = entity.ImageUrl;
    }

    public string ArticleNumber { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string? Ingress { get; set; }
    public string? Description { get; set; } 
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; } 

    public static implicit operator ProductEntity(DetailsViewModel model)
    {
        return new ProductEntity
        {
            ArticleNumber = model.ArticleNumber,
            Title = model.Title,
            Ingress = model.Ingress,
            Description = model.Description,
            Price = model.Price,
            ImageUrl= model.ImageUrl,
        };
    }
}
