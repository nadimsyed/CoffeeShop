using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    interface IDAO
    {
        //Could use arguements with default value and put that way you could potentially use for both types of delete and get
        Item GetItem(int id);

        void UpdateQuantity(int Id, int quantity);
        
        List<Item> GetItemList();

        int GetListLength();

        List<Item> ItemSort(string column);

        void AddItem(Item item);

        void DeleteItem(int id);

        void EditItem(Item item);

        void Dispose();
        
        //User GetUser(string email);

        //List<User> GetUserList();

        //void AddUser(User user);

        //void DeleteUser(string email);

        //void EditUser(User user);

        //void Dispose();

    }
}
