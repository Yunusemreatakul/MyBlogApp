using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
