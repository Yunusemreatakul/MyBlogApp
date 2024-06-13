using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.Controllers
{
	public class AdminSkilsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
