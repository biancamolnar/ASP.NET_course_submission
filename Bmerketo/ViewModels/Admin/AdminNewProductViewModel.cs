using Bmerketo.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Bmerketo.ViewModels.Admin;

public class AdminNewProductViewModel
{
    [Display(Name = "Article number")]
    [Required(ErrorMessage = "Articlenumber is required")]
    public string ArticleNumber { get; set; } = null!;

    [Display(Name = "Product name")]
    [Required(ErrorMessage = "Product name is required")]
    public string Title { get; set; } = null!;

    [Display(Name = "Ingress")]
    [Required(ErrorMessage = "Ingress is required")]
    public string Ingress { get; set; } = null!;

    [Display(Name = "Product description")]
    [Required(ErrorMessage = "Product description is required")]
    public string Description { get; set; } = null!;

    [Display(Name = "Product price in $")]
    [Required(ErrorMessage = "Product price is required")]
    public decimal Price { get; set; }

    [Display(Name = "Product image")]
    public IFormFile? Image { get; set; }


    public static implicit operator ProductEntity(AdminNewProductViewModel model)
    {
        return new ProductEntity
        {
            ArticleNumber = model.ArticleNumber,
            Title = model.Title,
            Ingress = model.Ingress,
            Description = model.Description,
            Price = model.Price,
            ImageUrl = model.Image?.FileName
        };
    }
}
