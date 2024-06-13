using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.Controllers
{
	public class BlogDetailController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
