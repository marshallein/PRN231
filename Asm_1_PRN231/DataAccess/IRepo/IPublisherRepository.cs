using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepo
{
    public interface IPublisherRepository
    {
        public IList<Publisher> GetPublishers();
        public void AddPublisher(Publisher publisher);
        public void DeletePublisher(Publisher publisher);
        public void UpdatePublisher(Publisher publisher);
        public Publisher GetPublisherById(int id);
    }
}
