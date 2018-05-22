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
            return View();
        }

        public ActionResult UserReg(string firstName ="", string lastName = "", string email = "", double phoneNumber = 0, string password = "", string securityQuestion = "", string securityAnswer = "")
        {
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Email = email;
            ViewBag.PhoneNumber = phoneNumber;
            ViewBag.Password = password;
            ViewBag.SecurityQuestion = securityQuestion;
            ViewBag.SecurityAnswer = securityAnswer;

            return View();
        }
    }
}