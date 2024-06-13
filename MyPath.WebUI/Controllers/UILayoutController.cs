using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
