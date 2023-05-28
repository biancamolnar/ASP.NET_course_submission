using Bmerketo.Helpers.Repositories;
using Bmerketo.Helpers.Services;
using Bmerketo.Models.Entities;
using Bmerketo.ViewModels;
using Bmerketo.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bmerketo.Controllers.Admin;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly UserManager<UserEntity> _userManager;
    private readonly AuthenticationService _authenticationService;
    private readonly RoleManager<IdentityRole> _roleManager;

    public AdminController(UserManager<UserEntity> userManager, AuthenticationService authenticationService, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _authenticationService = authenticationService;
        _roleManager = roleManager;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SignUpUser()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignUpUser(RegisterViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            if (!await _userManager.Users.AnyAsync(x => x.Email == viewModel.Email))
            {
                if (await _authenticationService.RegisterAsync(viewModel))
                    return RedirectToAction("Index", "Admin");
            }

            ModelState.AddModelError("", "User with the same email address aleady exists");

        }

        return View(viewModel);
    }

    public async Task<IActionResult> EditUser(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user == null)
        {
            return RedirectToAction("Index");
        }

        var userRoles = await _userManager.GetRolesAsync(user);
        var allRoles = _roleManager.Roles.Select(x => x.Name).ToList();

        var model = new AdminEditUserViewModel
        {
            Id = user.Id,
            Roles = userRoles,
            AllRoles = allRoles
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> EditUser(AdminEditUserViewModel viewModel)
    {
        var user = await _userManager.FindByIdAsync(viewModel.Id);

        if (user == null)
        {
            return RedirectToAction("Index");
        }

        if (!string.IsNullOrEmpty(viewModel.SelectedRole))
        {
            var currentRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, currentRoles);

            await _userManager.AddToRoleAsync(user, viewModel.SelectedRole);
        }

        return RedirectToAction("Index");
    }

}

