using Lab_2_Odata.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab_2_Odata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ODataController
    {

        private BookContext _context;

        public BookController(BookContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
            if (_context.Books.Count() == 0)
            {
                foreach (var item in DataSources.DataSource.GetBooks())
                {
                    _context.Books.Add(item);
                    _context.Presses.Add(item.Press);
                }
            }
        }


        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
