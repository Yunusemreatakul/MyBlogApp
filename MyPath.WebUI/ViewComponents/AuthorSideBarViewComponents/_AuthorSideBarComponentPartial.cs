using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MyPath.Dto.ProfileDtos;
using MyPath.WebUI.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Security.Claims;

namespace MyPath.WebUI.ViewComponents.AuthorSideBarViewComponents
{
    public class _AuthorSideBarComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AuthorSideBarComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int UserId)
        {
           

           

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7291/api/Profile/by-userid/{UserId}");

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
