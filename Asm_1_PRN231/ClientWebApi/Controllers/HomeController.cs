using BusinessObject.Models;
using ClientWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClientWebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly HttpClient httpClient = null;
        private readonly string apiUrl = "";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            httpClient = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            httpClient.DefaultRequestHeaders.Accept.Add(contentType);
            apiUrl = "https://localhost:5001/api/Users/";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Login(string email, string password)
        {

            LoginInfo loginInfo = new LoginInfo();
            loginInfo.Email = email;
            loginInfo.Password = password;

            var responseMessage = await httpClient.PostAsJsonAsync(apiUrl + "login", loginInfo);
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = await responseMessage.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                User user = JsonSerializer.Deserialize<User>(result, options);
                if (user.Role.Role_id == 1)
                {
                    HttpContext.Session.SetString("admin", "true");
                    return RedirectToAction("Index", "Book");
                }
                else
                {
                    HttpContext.Session.SetString("user", user.User_id.ToString());
                    return RedirectToAction("Index", "User");
                }
            }

            return NoContent();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
