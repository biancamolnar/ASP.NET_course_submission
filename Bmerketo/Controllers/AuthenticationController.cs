using Microsoft.AspNetCore.Mvc;

namespace Bmerketo.Controllers;

public class AuthenticationController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
