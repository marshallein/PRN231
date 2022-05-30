using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    internal class BookDAO
    {
        private static BookDAO instance = null;
        private static readonly object instanceLock = new object();
        private BookDAO() { }
        public static BookDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookDAO();
                    }
                    return instance;
                }
            }
        }


        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            using (var context = new DatabaseContext())
            {
                books = context.Books.Include(b => b.BookAuthors).Include(b => b.Pub).ToList();
            }
            return books;
        }

        public void UpdateBook(Book book)
        {
            using (var context = new DatabaseContext())
            {
                context.Entry<Book>(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void AddBook(Book book)
        {
            using (var context = new DatabaseContext())
            {
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public void DeleteBook(Book book)
        {
            using (var context = new DatabaseContext())
            {
                List<BookAuthor> authorList = context.BookAuthors.Where(a => a.Book_id == book.Book_id).ToList();
                context.BookAuthors.RemoveRange(authorList);
                context.SaveChanges();
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }

        public List<Book> GetBookByPublisherId(int pubId)
        {
            List<Book> books = new List<Book>();
            using (var context = new DatabaseContext())
            {
                books = context.Books.Where(b => b.Book_id == pubId)
                    .Include(b => b.BookAuthors).Include(b => b.Pub).ToList();
            }
            return books;
        }

        public Book GetBookById(int id)
        {
            Book book = new Book();
            using (var context = new DatabaseContext())
            {
                book = context.Books.Where(b => b.Book_id == id).FirstOrDefault();
            }
            return book;
        }
    }

}

