using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClientWebApi.Controllers
{
    public class AuthorController : Controller
    {

        private readonly HttpClient httpClient = null;
        private readonly string apiUrl = "";
        public AuthorController()
        {
            httpClient = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            httpClient.DefaultRequestHeaders.Accept.Add(contentType);
            apiUrl = "https://localhost:5001/api/Authors";
        }

        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("admin") != "true")
            {
                return RedirectToAction("Index", "Home");
            }

            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<Author> authors = JsonSerializer.Deserialize<List<Author>>(data, options);
            return View(authors);
        }

    }
}
