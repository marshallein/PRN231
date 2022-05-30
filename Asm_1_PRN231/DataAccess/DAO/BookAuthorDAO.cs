using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    internal class BookAuthorDAO
    {
        private static BookAuthorDAO instance = null;
        private static readonly object instanceLock = new object();
        private BookAuthorDAO() { }
        public static BookAuthorDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookAuthorDAO();
                    }
                    return instance;
                }
            }
        }

        public List<BookAuthor> GetBookAuthors()
        {
            List<BookAuthor> bookAuthors = new List<BookAuthor>();
            using (var context = new DatabaseContext())
            {
                bookAuthors = context.BookAuthors.Include(x => x.Author).Include(x => x.Book).ToList();
            }
            return bookAuthors;
        }

        public void AddBookAuthor(BookAuthor bookAuthor)
        {
            using (var context = new DatabaseContext())
            {
                context.BookAuthors.Add(bookAuthor);
                context.SaveChanges();
            }
        }

        public void UpdateBookAuthor(BookAuthor bookAuthor)
        {
            using (var context = new DatabaseContext())
            {
                context.Entry<BookAuthor>(bookAuthor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteBookAuthor(BookAuthor bookAuthor)
        {
            using (var context = new DatabaseContext())
            {
                context.BookAuthors.Remove(bookAuthor);
                context.SaveChanges();
            }
        }
    }
}
