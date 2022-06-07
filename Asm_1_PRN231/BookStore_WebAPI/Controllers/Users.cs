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
    public class Users : ControllerBase
    {

        private IUserRepository _userRepository;

        public Users()
        {
            this._userRepository = new UserRepository();
        }


        [Route("/api/Users/login")]
        [HttpPost]
        public ActionResult<User> Login([FromBody] LoginInfo loginInfo)
        {
            try
            {
                var user = _userRepository.GetUserLogin(loginInfo.Email, loginInfo.Password);
                if (user == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(user);
                }
            }
            catch (System.Exception)
            {
                return BadRequest();
                throw;
            }
        }


        // GET: api/<Users>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userRepository.GetUsers();
        }

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            try
            {
                return _userRepository.GetUserById(id);
            }
            catch (System.Exception)
            {
                return BadRequest();
            };
        }

        // POST api/<Users>
        [HttpPost]
        public ActionResult AddUser([FromBody] User user)
        {
            try
            {
                _userRepository.AddUser(user);
                return NoContent();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.InnerException);
                throw;
            }
        }

        // PUT api/<Users>/5
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, [FromBody] User user)
        {
            try
            {
                var userToEdit = _userRepository.GetUserById(id);
                if (user != null)
                {
                    _userRepository.UpdateUser(user);
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

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            try
            {
                var user = _userRepository.GetUserById(id);
                if (user != null)
                {
                    _userRepository.DeleteUser(user);
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
