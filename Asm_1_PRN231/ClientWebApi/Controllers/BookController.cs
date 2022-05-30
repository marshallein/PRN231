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
    public class BookController : Controller
    {
        private readonly HttpClient httpClient = null;
        private readonly string apiUrl = "";
        public BookController()
        {
            httpClient = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            httpClient.DefaultRequestHeaders.Accept.Add(contentType);
            apiUrl = "https://localhost:5001/api/Books";
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
            List<Book> books = JsonSerializer.Deserialize<List<Book>>(data, options);
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> CreateBook(Book book)
        {
            book.Book_id = 0;
            HttpResponseMessage response = await httpClient.PostAsJsonAsync(apiUrl, book);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int book_id)
        {
            var response = await httpClient.GetAsync(apiUrl + "/" + book_id);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Book bookToEdit = JsonSerializer.Deserialize<Book>(data, options);
            return View(bookToEdit);
        }

        public async Task<IActionResult> EditBook(Book book)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync<Book>(apiUrl + "/" + book.Book_id, book);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteBook(int book_id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync(apiUrl + "/" + book_id);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }

    }
}
