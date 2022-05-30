using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepo
{
    public interface IBookAuthorRepository
    {
        public IList<BookAuthor> GetBookAuthors();
        public void AddBookAuthor(BookAuthor bookAuthor);
        public void DeleteBookAuthor(BookAuthor bookAuthor);
        public void UpdateBookAuthor(BookAuthor bookAuthor);
    }
}
