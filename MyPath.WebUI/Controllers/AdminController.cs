﻿using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}