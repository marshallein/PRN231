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
    public class UserController : Controller
    {
        private readonly HttpClient httpClient = null;
        private string apiUrl = "";

        public UserController()
        {
            httpClient = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            httpClient.DefaultRequestHeaders.Accept.Add(contentType);
            apiUrl = "https://localhost:5001/api/Users";
        }

        public async Task<IActionResult> Index()
        {
            string userId = HttpContext.Session.GetString("user");
            if (userId == null)
            {
                return RedirectToAction("Index", "Home");
            }

            HttpResponseMessage response = await httpClient.GetAsync(apiUrl + "/" + userId.ToString());
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            User userLogin = JsonSerializer.Deserialize<User>(data, options);

            return View(userLogin);
        }

        public async Task<IActionResult> UpdateUser(User user)
        {
            apiUrl = "https://localhost:5001/api/Users";
            HttpResponseMessage response = await httpClient.PutAsJsonAsync<User>(apiUrl + "/" + user.User_id, user);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ListAuthor()
        {
            apiUrl = "https://localhost:5001/api/Authors";
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<Author> authors = JsonSerializer.Deserialize<List<Author>>(data, options);
            return View(authors);
        }

        public async Task<IActionResult> ListBook()
        {
            apiUrl = "https://localhost:5001/api/Books";
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<Book> books = JsonSerializer.Deserialize<List<Book>>(data, options);
            return View(books);
        }

        public async Task<IActionResult> ListPublisher()
        {
            apiUrl = "https://localhost:5001/api/Publishers";
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<Publisher> publishers = JsonSerializer.Deserialize<List<Publisher>>(data, options);

            return View(publishers);
        }

    }
}
