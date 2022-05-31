using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    internal class PublisherDAO
    {
        private static PublisherDAO instance = null;
        private static readonly object instanceLock = new object();
        private PublisherDAO() { }
        public static PublisherDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PublisherDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Publisher> GetPublishers()
        {
            var list = new List<Publisher>();
            using (var context = new DatabaseContext())
            {
                list = context.Publisher.ToList();
            }
            return list;
        }

        public void AddPublisher(Publisher publisher)
        {
            using (var context = new DatabaseContext())
            {
                context.Publisher.Add(publisher);
                context.SaveChanges();
            }
        }

        public void UpdatePublisher(Publisher publisher)
        {
            using (var context = new DatabaseContext())
            {
                context.Entry<Publisher>(publisher).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeletePublisher(Publisher publisher)
        {
            using (var context = new DatabaseContext())
            {
                List<Book> books = BookDAO.Instance.GetBookByPublisherId(publisher.Pub_id);
                List<User> users = context.Users.Where(u => u.Pub.Pub_id == publisher.Pub_id).ToList();
                context.RemoveRange(users);
                context.RemoveRange(books);
                context.SaveChanges();
                context.Publisher.Remove(publisher);
                context.SaveChanges();
            }
        }

        public Publisher GetPublisherById(int id)
        {
            var publisher = new Publisher();
            using (var context = new DatabaseContext())
            {
                publisher = context.Publisher.Where(u => u.Pub_id == id).FirstOrDefault();
            }
            return publisher;
        }
    }
}
