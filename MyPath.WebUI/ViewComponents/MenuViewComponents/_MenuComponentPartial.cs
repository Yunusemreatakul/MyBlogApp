using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPath.WebUI.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;

namespace MyPath.WebUI.ViewComponents.MenuViewComponents
{
    [Authorize]
    public class _MenuComponentPartial:ViewComponent
	{

        private readonly IHttpClientFactory _httpClientFactory;

        public _MenuComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IViewComponentResult Invoke()
        {
			var userName = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
			

			bool isAuthenticated = !string.IsNullOrEmpty(userName);

			var model = new MenuViewModel
			{
				IsAuthenticated = isAuthenticated
			};

			return View(model);
		}
    }
}

