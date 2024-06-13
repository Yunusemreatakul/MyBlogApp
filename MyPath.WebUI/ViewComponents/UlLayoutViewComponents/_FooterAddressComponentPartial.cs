using Microsoft.AspNetCore.Mvc;

namespace MyPath.WebUI.ViewComponents.UlLayoutViewComponents
{
    public class _FooterAddressComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
