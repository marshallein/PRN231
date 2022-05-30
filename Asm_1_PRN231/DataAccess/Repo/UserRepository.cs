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
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            UserDAO.Instance.AddUser(user);
        }

        public void DeleteUser(User user)
        {
            UserDAO.Instance.DeleteUser(user);
        }

        public User GetUserById(int id)
        {
            return UserDAO.Instance.GetUserById(id);
        }

        public User GetUserLogin(string email, string password)
        {
            return UserDAO.Instance.GetUserLogin(email, password);
        }

        public IList<User> GetUsers()
        {
            return UserDAO.Instance.GetUsers();
        }

        public void UpdateUser(User user)
        {
            UserDAO.Instance.UpdateUser(user);
        }
    }
}
