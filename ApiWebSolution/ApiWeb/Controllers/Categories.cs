using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using System.Collections.Generic;
using ApiWeb.Models;
using System.Threading.Tasks;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Categories : Controller
    {
        CategoryDAO categoryDAO = new CategoryDAO();

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetListCategory()
        {
            return categoryDAO.GetCategories();
        }


    }
}
