using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class UserRegController : Controller
    {
        // GET: UserReg
        public ActionResult Index()
        {
            CoffeeEntities ORM = new CoffeeEntities();
            ViewBag.Users = ORM.Users.ToList();

            return View();

        }

        public ActionResult UserReg(User data)/*string firstName ="", string lastName = "", string email = "", double phoneNumber = 0, string password = "", string securityQuestion = "", string securityAnswer = "")*/
        {
            //do data.blank and still add to viewbag to use for registration feedback. but add to the database

            //ViewBag.FirstName = firstName;
            //ViewBag.LastName = lastName;
            //ViewBag.Email = email;
            //ViewBag.PhoneNumber = phoneNumber;
            //ViewBag.Password = password;
            //ViewBag.SecurityQuestion = securityQuestion;
            //ViewBag.SecurityAnswer = securityAnswer;

            CoffeeEntities ORM = new CoffeeEntities();
            ViewBag.Users = ORM.Users.ToList();



            if (ModelState.IsValid)
            {
                try
                {
                    ORM.Users.Add(data);
                    ORM.SaveChangesAsync();
                    ViewBag.message = $"Account with has been added";
                }
                catch (Exception e)
                {
                    ViewBag.message = $"Error {e.Message}";//$"{data.Email} is not in the database and is not a valid customer.";
                }
            }
            else
            {
                ViewBag.message = "User is not valid, could not add to DataBase.";
            }

            return View();
        }
    }
}