using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class UserDAO : IDAO
    {
        private CoffeeEntities db;

        public UserDAO()
        {
            db = new CoffeeEntities();
        }

        public User GetUser(string email)
        {
            return db.Users.Find(email);
        }

        public List<User> GetUserList()
        {
            return db.Users.ToList();
        }

        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void DeleteUser(string email)
        {
            User user = db.Users.Find(email);
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public void EditUser(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}