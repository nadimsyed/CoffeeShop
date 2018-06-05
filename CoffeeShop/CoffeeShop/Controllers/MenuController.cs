﻿using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class MenuController : Controller
    {
        private ItemDAO dao = new ItemDAO();

        // GET: Menu
        public ActionResult Index()
        {
            //if (Session["Cart"] == null)
            //{
            //    List<Item> item = new List<Item>();
            //    Item x = null;
            //    item.Add(x);
            //    Session["Cart"] = item;
            //    return View(dao.GetItemList(), (List<Item>)Session["Cart"]);
            //}
            return View(dao.GetItemList());
        }

        public ActionResult ItemSort(string column)
        {
            return View("Index", dao.ItemSort(column));
        }

        public ActionResult Add(int id = 0)
        {
            CoffeeEntities db = new CoffeeEntities();
            if (id == 0 && Session["Cart"] != null)
            {
                //List<Item> cart = (List<Item>)(Session["Cart"]);
                //Item item = ()
                return View("Add", Session["Cart"]);
            }
            else if (id == 0)
            {
                //List<Item> cart = (List<Item>)(Session["Cart"]);
                //Item item = ()
                return View("Add", Session["Cart"] = null);
            }
            else
            {
                //Check if the Cart already exists
                if (Session["Cart"] == null)
                {
                    //if it doesn't make a new list of books

                    List<Item> cart = new List<Item>();
                    //add this book to it
                    cart.Add((from i in db.Items
                              where i.ItemId == id
                              select i).Single());

                    //add the list to the session
                    Session.Add("Cart", cart);
                }
                else
                {
                    //if it does exist need to get the list
                    List<Item> cart = (List<Item>)(Session["Cart"]);
                    //add this book to the list
                    cart.Add((from b in db.Items
                              where b.ItemId == id
                              select b).Single());
                    //add the list to the session
                    //Session["Cart"] = cart;
                }

                return View(); 
            }
        }

        public ActionResult Clear()
        {
            Session.Clear();
            return View();
        }
    }
}