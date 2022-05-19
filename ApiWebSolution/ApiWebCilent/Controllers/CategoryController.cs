using ApiWebCilent.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiWebCilent.Controllers
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

        public ActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int CategoryId)
        {
            Category category = null;

            var response = await client.GetAsync(CategoryApiUrl + "/" + CategoryId);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            category = JsonSerializer.Deserialize<Category>(data, options);

            return View(category);
        }

        public async Task<IActionResult> CreateCategory(Category category)
        {
            category.CategoryId = 0;

            HttpResponseMessage response = await client.PostAsJsonAsync(CategoryApiUrl, category);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteCategory(int CategoryId)
        {

            HttpResponseMessage response = await client.DeleteAsync(CategoryApiUrl + "/" + CategoryId);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> EditCategory(Category category)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(CategoryApiUrl, category);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");

        }
    }
}
