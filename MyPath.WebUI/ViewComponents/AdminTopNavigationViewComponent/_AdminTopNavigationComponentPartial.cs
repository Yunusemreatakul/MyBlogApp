using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.ViewComponents.AdminTopNavigationViewComponent
{
    public class _AdminTopNavigationComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
