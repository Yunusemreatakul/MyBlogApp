using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.Controllers
{
	public class PortfolioController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
