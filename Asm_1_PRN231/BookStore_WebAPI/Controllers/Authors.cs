using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BusinessObject.Models;
using DataAccess.IRepo;
using DataAccess.Repo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Authors : ControllerBase
    {
        private IAuthorRepository _authorRepository;

        public Authors()
        {
            this._authorRepository = new AuthorRepository();
        }


        // GET: api/<Authors>
        [HttpGet]
        public IEnumerable<Author> GetAuthors()
        {
            return _authorRepository.GetAuthors();
        }

        // GET api/<Authors>/5
        [HttpGet("{id}")]
        public ActionResult<Author> Get(int id)
        {
            try
            {
                return _authorRepository.GetById(id);
            }
            catch (System.Exception)
            {
                return BadRequest();
                throw;
            }
        }

        // POST api/<Authors>
        [HttpPost]
        public ActionResult AddAuthor([FromBody] Author author)
        {
            try
            {
                _authorRepository.AddAuthor(author);
                return NoContent();
            }
            catch (System.Exception)
            {
                return BadRequest();
                throw;
            }
        }

        // PUT api/<Authors>/5
        [HttpPut("{id}")]
        public ActionResult UpdateAuthor(int id, [FromBody] Author author)
        {
            try
            {
                var authorToUpdate = _authorRepository.GetById(id);
                if (authorToUpdate != null)
                {
                    _authorRepository.UpdateAuthor(author);
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (System.Exception)
            {
                return BadRequest();
                throw;
            }
        }

        // DELETE api/<Authors>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var authorToDelete = _authorRepository.GetById(id);
                if (authorToDelete != null)
                {
                    _authorRepository.DeleteAuthor(authorToDelete);
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (System.Exception)
            {
                return BadRequest();
                throw;
            }
        }
    }
}
