using BusinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
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

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> CreateAuthor(Author author)
        {
            author.Author_id = 0;
            HttpResponseMessage response = await httpClient.PostAsJsonAsync(apiUrl, author);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int author_id)
        {
            var response = await httpClient.GetAsync(apiUrl + "/" + author_id);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Author authorToEdit = JsonSerializer.Deserialize<Author>(data, options);
            return View(authorToEdit);
        }

        public async Task<IActionResult> EditAuthor(Author author)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync<Author>(apiUrl + "/" + author.Author_id, author);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAuthor(int author_id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync(apiUrl + "/" + author_id);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }

    }
}
