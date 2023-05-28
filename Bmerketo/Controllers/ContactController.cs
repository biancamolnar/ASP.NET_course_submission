using Bmerketo.Helpers.Repositories;
using Bmerketo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bmerketo.Controllers;

public class ContactController : Controller
{
    private readonly ContactFormRepository _formRepository;

    public ContactController(ContactFormRepository formRepository)
    {
        _formRepository = formRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(ContactFormViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            await _formRepository.AddAsync(viewModel);
            return RedirectToAction("Index");
        }

        return View(viewModel);
    }

}
