using BusinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repo
{
    public class BookAuthorRepository : IBookAuthorRepository
    {
        public void AddBookAuthor(BookAuthor bookAuthor)
        {
            BookAuthorDAO.Instance.AddBookAuthor(bookAuthor);
        }

        public IList<BookAuthor> GetBookAuthors()
        {
            return BookAuthorDAO.Instance.GetBookAuthors();
        }

        public void DeleteBookAuthor(BookAuthor bookAuthor)
        {
            BookAuthorDAO.Instance.DeleteBookAuthor(bookAuthor);
        }

        public void UpdateBookAuthor(BookAuthor bookAuthor)
        {
            BookAuthorDAO.Instance.UpdateBookAuthor(bookAuthor);
        }
    }
}
