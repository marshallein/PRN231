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

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {

            try
            {
                categoryDAO.AddCategory(category);
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw new Exception(ex.Message);
            }

            return Ok(category);
        }

        [HttpDelete("{CategoryId}")]
        public ActionResult DeleteCategory(int CategoryId)
        {
            try
            {
                categoryDAO.DeleteCategory(CategoryId);
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw new Exception(ex.Message);
            }

            return Ok();
        }


        [HttpPut]
        public ActionResult UpdateCategory(Category category)
        {
            try
            {
                categoryDAO.UpdateCategory(category);
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw new Exception(ex.Message);
            }

            return Ok();
        }


        [HttpGet("{CategoryId}")]
        public ActionResult<Category> GetCategorybyId(int CategoryId)
        {
            try
            {
                return categoryDAO.GetCategory(CategoryId);
            }
            catch (Exception ex)
            {
                return NotFound();
                throw new Exception(ex.Message);
            }
        }
    }
}
