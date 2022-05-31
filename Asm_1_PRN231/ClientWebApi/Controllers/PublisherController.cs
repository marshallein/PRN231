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
    public class PublisherController : Controller
    {

        private readonly HttpClient httpClient = null;
        private readonly string apiUrl = "";

        public PublisherController()
        {
            httpClient = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            httpClient.DefaultRequestHeaders.Accept.Add(contentType);
            apiUrl = "https://localhost:5001/api/Publishers";
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
            List<Publisher> publishers = JsonSerializer.Deserialize<List<Publisher>>(data, options);

            return View(publishers);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> CreatePublisher(Publisher publisher)
        {
            publisher.Pub_id = 0;
            HttpResponseMessage response = await httpClient.PostAsJsonAsync(apiUrl, publisher);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int pub_id)
        {
            var response = await httpClient.GetAsync(apiUrl + "/" + pub_id);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Publisher pubToEdit = JsonSerializer.Deserialize<Publisher>(data, options);
            return View(pubToEdit);
        }

        public async Task<IActionResult> EditPublisher(Publisher publisher)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync<Publisher>(apiUrl + "/" + publisher.Pub_id, publisher);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeletePublisher(int pub_id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync(apiUrl + "/" + pub_id);
            response.EnsureSuccessStatusCode();

            return RedirectToAction("Index");
        }
    }
}
