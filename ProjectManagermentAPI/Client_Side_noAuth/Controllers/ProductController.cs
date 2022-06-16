using Microsoft.AspNetCore.Mvc;

namespace Client_Side_noAuth.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
