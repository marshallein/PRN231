using Microsoft.AspNetCore.Mvc;

namespace ClientWebApi.Controllers
{
	public class AuthorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
