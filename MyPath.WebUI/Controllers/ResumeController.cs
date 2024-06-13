using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.Controllers
{
	public class ResumeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
