using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    internal class UserDAO
    {
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        private UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public List<User> GetUsers()
        {
            var users = new List<User>();
            using (var context = new DatabaseContext())
            {
                users = context.Users.Include(u => u.Pub).Include(u => u.Role).ToList();
            }
            return users;
        }

        public void AddUser(User user)
        {
            using (var context = new DatabaseContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            using (var context = new DatabaseContext())
            {
                context.Entry<User>(user).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteUser(User user)
        {
            using (var context = new DatabaseContext())
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public User GetUserById(int id)
        {
            var user = new User();
            using (var context = new DatabaseContext())
            {
                user = context.Users.Where(u => u.User_id == id).FirstOrDefault();
            }
            return user;
        }

        public User GetUserLogin(string email, string password)
        {
            var user = new User();
            using (var context = new DatabaseContext())
            {
                user = context.Users.Where(u => u.Email_address == email && u.Password == password).FirstOrDefault();
            }
            return user;
        }
    }
}
