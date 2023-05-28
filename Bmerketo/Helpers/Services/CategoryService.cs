using Bmerketo.Helpers.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bmerketo.Helpers.Services;

public class CategoryService
{
    private readonly CategoryRepository _categoryRepository;

    public CategoryService(CategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<List<SelectListItem>> GetCategoriesAsync()
    {
        var categories = new List<SelectListItem>();

        foreach (var category in await _categoryRepository.GetAllAsync())
        {
            categories.Add(new SelectListItem
            {
                Value = category.Id.ToString(),
                Text = category.CategoryName
            });
        }

        return categories;
    }

    public async Task<List<SelectListItem>> GetCategoriesAsync(string[] selectedCategories)
    {
        var categories = new List<SelectListItem>();

        foreach (var category in await _categoryRepository.GetAllAsync())
        {
            categories.Add(new SelectListItem
            {
                Value = category.Id.ToString(),
                Text = category.CategoryName,
                Selected = selectedCategories.Contains(category.Id.ToString())
            });
        }

        return categories;
    }
}
