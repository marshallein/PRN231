using Lab_2_Odata.Models;
using System.Collections.Generic;

namespace Lab_2_Odata.DataSources
{
    public class DataSource
    {
        private static IList<Book> listBook { get; set; }
        public static IList<Book> GetBooks()
        {
            if (listBook != null)
            {
                return listBook;
            }

            listBook = new List<Book>();
            Book book = new Book
            {
                Id = 1,
                ISBN = "ko biet ke mm",
                Title = "alo alo",
                Author = " unknow author",
                Price = 99.99m,
                Address = new Address
                {
                    City = "Void",
                    Street = "unknow"
                },
                Press = new Press
                {
                    Id = 1,
                    Name = "voided",
                    Category = Category.Book,
                }

            };

            listBook.Add(book);
            book = new Book
            {
                Id = 2,
                ISBN = "ko biet ke mm hee hee",
                Title = "alo alo alo",
                Author = " unknow author",
                Price = 99.98m,
                Address = new Address
                {
                    City = "Ruin",
                    Street = "unknow"
                },
                Press = new Press
                {
                    Id = 2,
                    Name = "voided to air",
                    Category = Category.EBook,
                }

            };
            listBook.Add(book);
        }
    }
}
