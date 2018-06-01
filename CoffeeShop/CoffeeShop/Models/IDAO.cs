﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    interface IDAO
    {
        Item GetItem(int id);

        List<Item> GetItemList();

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