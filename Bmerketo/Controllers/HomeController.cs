﻿using Bmerketo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bmerketo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";

            return View();
        }
    }
}
