using Bmerketo.Helpers.Repositories;
using Bmerketo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bmerketo.Controllers;

public class ProductsController : Controller
{
    private readonly ProductRepository _productRepository;

    public ProductsController(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("products/details/{articleNumber}")]
    public async Task<IActionResult> Details(string articleNumber)
    {
        var product = await _productRepository.GetAsync(x => x.ArticleNumber == articleNumber);
        var viewModel = new DetailsViewModel(product);
        
        return View(viewModel);
    }
}
