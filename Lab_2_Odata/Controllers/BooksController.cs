using Lab_2_Odata.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab_2_Odata.Controllers
{
    public class BooksController : ODataController
    {

        private BookContext _context;

        public BooksController(BookContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            if (context.Books.Count() == 0)
            {
                foreach (var item in DataSources.DataSource.GetBooks())
                {
                    context.Books.Add(item);
                    context.Presses.Add(item.Press);
                }
                context.SaveChanges();
            }
        }


        // GET: api/<BookController>
        [EnableQuery(PageSize = 10)]
        public IActionResult Get()
        {
            return Ok(_context.Books);
        }

        // GET api/<BookController>/5
        [EnableQuery]
        public IActionResult Get(int key, string version)
        {
            return Ok(_context.Books.FirstOrDefault(book => book.Id.Equals(key)));
        }

        // POST api/<BookController>
        [EnableQuery]
        public IActionResult Post([FromBody] Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return Created(book);
        }

        [EnableQuery]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController>/5
        [EnableQuery]
        public IActionResult Delete([FromBody] int key)
        {
            Book book = _context.Books.FirstOrDefault(book => book.Id.Equals(key));
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            _context.SaveChanges();
            return Ok();
        }
    }
}
