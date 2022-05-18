using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using ApiClientWeb.Models;

namespace ApiClientWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly HttpClient client = null;
        private string CategoryApiUrl = "";

        public CategoryController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            CategoryApiUrl = "https://localhost:5001/api/Categories";
        }

        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync(CategoryApiUrl);
            string strData = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<Category> categories = JsonSerializer.Deserialize<List<Category>>(strData, options);
            return View(categories);
        }
    }
}
