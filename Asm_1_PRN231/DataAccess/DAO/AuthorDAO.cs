using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    internal class AuthorDAO
    {
        private static AuthorDAO instance = null;
        private static readonly object instanceLock = new object();
        private AuthorDAO() { }
        public static AuthorDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AuthorDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Author> GetAuthors()
        {
            var authors = new List<Author>();
            using (var context = new DatabaseContext())
            {
                authors = context.Author.Include(a => a.BookAuthors).ToList();
            }
            return authors;
        }

        public void AddAuthor(Author author)
        {
            using (var context = new DatabaseContext())
            {
                context.Author.Add(author);
                context.SaveChanges();
            }
        }

        public void UpdateAuthor(Author author)
        {
            using (var context = new DatabaseContext())
            {
                context.Entry<Author>(author).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteAuthor(Author author)
        {
            using (var context = new DatabaseContext())
            {
                List<BookAuthor> authorList = context.BookAuthors.Where(a => a.Author_id == author.Author_id).ToList();
                context.BookAuthors.RemoveRange(authorList);
                context.SaveChanges();
                context.Author.Remove(author);
                context.SaveChanges();
            }
        }

        public Author GetAuthorById(int id)
        {
            Author author = new Author();
            using (var context = new DatabaseContext())
            {
                author = context.Author.SingleOrDefault(a => a.Author_id == id);
            }
            return author;
        }
    }
}
