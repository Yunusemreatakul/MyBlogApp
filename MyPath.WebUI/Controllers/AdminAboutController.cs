using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.Controllers
{
	public class AdminAboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
