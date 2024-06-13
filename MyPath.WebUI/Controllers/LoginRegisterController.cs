using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MyPath.Dto.LoginRegisterDtos;
using MyPath.WebUI.Models;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using JsonSerializer = System.Text.Json.JsonSerializer;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace MyPath.WebUI.Controllers
{
    public class LoginRegisterController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public LoginRegisterController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppUser(LoginRegisterViewModel model)
        {
			

			var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model.RegisterModel);
          

            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
           

            var responseMessage = await client.PostAsync("https://localhost:7291/api/Register", stringContent);
           
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "About");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginRegisterViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var content = new StringContent(JsonSerializer.Serialize(model.LoginModel), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7291/api/Login", content);
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var tokenModel = JsonSerializer.Deserialize<JwtResponseModel>(jsonData, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

                if (tokenModel != null)
                {
                    JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                    var token = handler.ReadJwtToken(tokenModel.Token);
                    var claims = token.Claims.ToList();

                    if (tokenModel.Token != null)
                    {
                        claims.Add(new Claim("accesDenied", tokenModel.Token));
                        var claimsIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
                        var authProps = new AuthenticationProperties
                        {
                            ExpiresUtc = tokenModel.ExpireDate,
                            IsPersistent = true
                        };
						
						await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);
						var userUId = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
						return RedirectToAction("Index", "About", new { userId = userUId });

					}
				}
            }

            return View();
        }


		[HttpPost]
		public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(JwtBearerDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
	}
}
