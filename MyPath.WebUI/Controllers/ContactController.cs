using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
