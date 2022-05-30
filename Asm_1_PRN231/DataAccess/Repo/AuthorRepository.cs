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
    public class AuthorRepository : IAuthorRepository
    {
        public void AddAuthor(Author author)
        {
            AuthorDAO.Instance.AddAuthor(author);
        }

        public void DeleteAuthor(Author author)
        {
            AuthorDAO.Instance.DeleteAuthor(author);
        }

        public IList<Author> GetAuthors()
        {
            return AuthorDAO.Instance.GetAuthors();
        }

        public Author GetById(int id)
        {
            return AuthorDAO.Instance.GetAuthorById(id);
        }

        public void UpdateAuthor(Author author)
        {
            AuthorDAO.Instance.UpdateAuthor(author);
        }
    }
}
