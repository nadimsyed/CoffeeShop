using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    interface IDAO
    {
        User GetUser(string email);

        List<User> GetUserList();

        void AddUser(User user);

        void DeleteUser(string email);

        void EditUser(User user);

        void Dispose();

    }
}
