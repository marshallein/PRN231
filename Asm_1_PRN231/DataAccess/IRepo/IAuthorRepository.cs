using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepo
{
    public interface IAuthorRepository
    {
        public IList<Author> GetAuthors();
        public Author GetById(int id);
        public void DeleteAuthor(Author author);
        public void UpdateAuthor(Author author);
        public void AddAuthor(Author author);
    }
}
