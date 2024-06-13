using Microsoft.AspNetCore.Mvc;
using MyPath.Dto.ProfileDtos;
using MyPath.WebUI.Models;
using Newtonsoft.Json;

namespace MyPath.WebUI.Controllers
{
    public class AboutController : Controller
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public AboutController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> IndexAsync(int UserId)
        {
			var model = new UserIdViewModel { UserId = UserId };
			return View(model);

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:7291/api/About/{UserId}");

			// İstek başarılı mı ve içerik dolu mu kontrolü
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<FrontProfileDto>(json);
				return View(values);
			}
			else
			{
				// İstek başarısızsa veya içerik boşsa normal sayfayı aç
				return View();
			}




			
			
        }
    }
}
