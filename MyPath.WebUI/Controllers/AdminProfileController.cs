using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.Controllers
{
    public class AdminProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
