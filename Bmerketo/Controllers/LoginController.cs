using Bmerketo.Helpers.Services;
using Bmerketo.Models.Entities;
using Bmerketo.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bmerketo.Controllers
{
    public class LoginController : Controller
    {
        private readonly AuthenticationService _authenticationService;
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;

        public LoginController(
            AuthenticationService authenticationService,
            UserManager<UserEntity> userManager,
            SignInManager<UserEntity> signInManager)
        {
            _authenticationService = authenticationService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(viewModel.Email);
                    var roles = await _userManager.GetRolesAsync(user!);

                    if (roles.Contains("Admin"))
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

                ModelState.AddModelError("", "Incorrect email or password");
            }

            return View(viewModel);
        }
    }
}
