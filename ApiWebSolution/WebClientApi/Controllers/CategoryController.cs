﻿using Microsoft.AspNetCore.Mvc;

namespace WebClientApi.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
