using Bmerketo.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bmerketo.Controllers;

public class LogoutController : Controller
{
    private readonly SignInManager<UserEntity> _signInManager;

    public LogoutController(SignInManager<UserEntity> signInManager)
    {
        _signInManager = signInManager;
    }

    public async Task<IActionResult> Index()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }
}
