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
    public class BookRepository : IBookRepository
    {
        public void AddBook(Book book)
        {
            BookDAO.Instance.AddBook(book);
        }

        public void DeleteBook(Book book)
        {
            BookDAO.Instance.DeleteBook(book);
        }

        public IList<Book> GetAllBooksByPublisherId(int pub_id)
        {
            return BookDAO.Instance.GetBookByPublisherId(pub_id);
        }

        public Book GetBookById(int id)
        {
            return BookDAO.Instance.GetBookById(id);
        }

        public IList<Book> GetBooks()
        {
            return BookDAO.Instance.GetBooks();
        }

        public void UpdateBook(Book book)
        {
            BookDAO.Instance.UpdateBook(book);
        }
    }
}
