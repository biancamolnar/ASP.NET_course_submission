using Bmerketo.Helpers.Services;
using Bmerketo.Models.Entities;
using Bmerketo.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Bmerketo.Controllers.Admin;

[Authorize(Roles = "Admin")]
[Route("admin/products")]
public class AdminProductsController : Controller
{
    private readonly ProductService _productService;
    private readonly CategoryService _categoryService;

    public AdminProductsController(ProductService productService, CategoryService categoryService)
    {
        _productService = productService;
        _categoryService = categoryService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [Route("new")]
    public async Task<IActionResult> New()
    {
        ViewBag.Categories = await _categoryService.GetCategoriesAsync();

        return View();
    }


    [HttpPost]
    [Route("new")]
    public async Task<IActionResult> New(AdminNewProductViewModel viewModel, string[] categories)
    {
        if (ModelState.IsValid)
        {
            bool articleNumberExists = await _productService.ArticleNumberExistsAsync(viewModel.ArticleNumber);

            if (articleNumberExists)
            {
                ModelState.AddModelError("ArticleNumber", "A product with the same article number already exists.");
            }
            else
            {
                if (await _productService.AddAsync(viewModel))
                {
                    await _productService.AddProductCategoriesAsync(viewModel, categories);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Something went wrong");
                }
            }
        }

        ViewBag.Categories = await _categoryService.GetCategoriesAsync(categories);
        return View(viewModel);
    }
}