using BusinessObject.Models;
using DataAccess.IRepo;
using DataAccess.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace BookStore_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookAuthors : ControllerBase
    {

        private IBookAuthorRepository _bookAuthorRepository;

        public BookAuthors()
        {
            this._bookAuthorRepository = new BookAuthorRepository();

        }

        [HttpGet]
        public IEnumerable<BookAuthor> GetBookAuthors()
        {
            return _bookAuthorRepository.GetBookAuthors();
        }
    }
}
