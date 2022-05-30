using BusinessObject.Models;
using DataAccess.IRepo;
using DataAccess.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Books : ControllerBase
    {

        private IBookRepository _bookRepository;

        public Books()
        {
            this._bookRepository = new BookRepository();
        }



        // GET: api/<Books>
        [HttpGet]
        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetBooks();
        }

        // GET api/<Books>/5
        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            try
            {
                return _bookRepository.GetBookById(id);
            }
            catch (System.Exception)
            {
                return NotFound("cant found book");
            }
        }

        // POST api/<Books>
        [HttpPost]
        public ActionResult AddBook([FromBody] Book book)
        {
            try
            {
                _bookRepository.AddBook(book);
                return NoContent();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        // PUT api/<Books>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Book book)
        {
            try
            {
                if (_bookRepository.GetBookById(id) != null)
                {
                    _bookRepository.UpdateBook(book);
                    return NoContent();
                }
                else { return NotFound(); }

            }
            catch (System.Exception)
            {
                return BadRequest();
            }

        }

        // DELETE api/<Books>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var book = _bookRepository.GetBookById(id);
                if (book != null)
                {
                    _bookRepository.DeleteBook(book);
                    return NoContent();
                }
                else { return NotFound(); }
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }
    }
}
