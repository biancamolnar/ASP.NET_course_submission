using Bmerketo.Models.Entities;
using Bmerketo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Bmerketo.ViewModels;

namespace Bmerketo.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly UserManager<UserEntity> _userManager;

        public UserProfileController(UserManager<UserEntity> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var viewModel = new UserProfileViewModel
            {
                Id = user!.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };

            return View(viewModel);
        }
    }
}
