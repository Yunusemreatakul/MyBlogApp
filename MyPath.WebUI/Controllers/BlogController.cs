﻿using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
