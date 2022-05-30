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
    public class Publishers : ControllerBase
    {

        private IPublisherRepository _publisherRepository;

        public Publishers()
        {
            _publisherRepository = new PublisherRepository();
        }

        // GET: api/<Publishers>
        [HttpGet]
        public IEnumerable<Publisher> GetPublishers()
        {
            return _publisherRepository.GetPublishers();
        }

        // GET api/<Publishers>/5
        [HttpGet("{id}")]
        public ActionResult<Publisher> GetPublisherById(int id)
        {
            try
            {
                return _publisherRepository.GetPublisherById(id);
            }
            catch (System.Exception)
            {
                return BadRequest();
                throw;
            };
        }

        // POST api/<Publishers>
        [HttpPost]
        public ActionResult AddPublisher([FromBody] Publisher publisher)
        {
            try
            {
                _publisherRepository.AddPublisher(publisher);
                return NoContent();
            }
            catch (System.Exception)
            {
                return BadRequest();
                throw;
            }
        }

        // PUT api/<Publishers>/5
        [HttpPut("{id}")]
        public ActionResult UpdatePublisher(int id, [FromBody] Publisher publisher)
        {
            try
            {
                var _publisher = _publisherRepository.GetPublisherById(id);
                if (_publisher != null)
                {
                    _publisherRepository.UpdatePublisher(publisher);
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

        // DELETE api/<Publishers>/5
        [HttpDelete("{id}")]
        public ActionResult DeletePublisher(int id)
        {
            try
            {
                var publisher = _publisherRepository.GetPublisherById(id);
                if (publisher != null)
                {
                    _publisherRepository.DeletePublisher(publisher);
                    return NoContent();
                }
                else { return NotFound(); }
            }
            catch (System.Exception)
            {
                return BadRequest();
                throw;
            }
        }
    }
}
