using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.ViewComponents.AdminMenuViewComponent
{
    public class _AdminMenuComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
