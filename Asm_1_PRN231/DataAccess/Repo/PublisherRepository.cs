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
    public class PublisherRepository : IPublisherRepository
    {
        public void AddPublisher(Publisher publisher)
        {
            PublisherDAO.Instance.AddPublisher(publisher);
        }

        public Publisher GetPublisherById(int id)
        {
            return PublisherDAO.Instance.GetPublisherById(id);
        }

        public IList<Publisher> GetPublishers()
        {
            return PublisherDAO.Instance.GetPublishers();
        }

        public void DeletePublisher(Publisher publisher)
        {
            PublisherDAO.Instance.DeletePublisher(publisher);
        }

        public void UpdatePublisher(Publisher publisher)
        {
            PublisherDAO.Instance.UpdatePublisher(publisher);
        }
    }
}
