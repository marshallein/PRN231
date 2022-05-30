using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepo
{
    public interface IBookRepository
    {
        public IList<Book> GetBooks();
        public IList<Book> GetAllBooksByPublisherId(int id);
        public Book GetBookById(int id);
        public void AddBook(Book book);
        public void UpdateBook(Book book);
        public void DeleteBook(Book book);
    }
}
