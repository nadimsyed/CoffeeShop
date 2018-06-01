using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CoffeeEntities ORM = new CoffeeEntities();
            ViewBag.Items = ORM.Items.ToList();
            ViewBag.Users = ORM.Users.ToList();

            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ItemNameView(string Name)
        {
            CoffeeEntities ORM = new CoffeeEntities();
            ViewBag.Items = ORM.Items.Where(x => x.Name == Name).ToList();

            return View();
        }


    }
}