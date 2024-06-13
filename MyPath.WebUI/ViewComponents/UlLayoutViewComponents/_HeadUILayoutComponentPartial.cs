using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.ViewComponents.UlLayoutViewComponents
{
    public class _HeadUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
