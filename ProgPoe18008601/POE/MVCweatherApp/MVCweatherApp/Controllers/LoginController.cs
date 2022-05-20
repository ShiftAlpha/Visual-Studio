using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCweatherApp.Models;

namespace MVCweatherApp.Controllers
{
    public class LoginController : Controller
    {

        weatherapp wa = new weatherapp();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {

            if (Session["Error messsage"] == null)
            {
                ViewBag.Error = Session["Error message"] as string;
            }
            return View();

        }
        [HttpPost]
        public ActionResult Login(string Username, string Passwords)
        {
            bool found = false;
            foreach (User u in wa.Users)
            {
                if (Username.Equals(u.Username) && (Passwords.Equals(Passwords)))
                {
                    found = true;
                    Session["Username"] = Username;
                    return RedirectToAction("Index", "Favourites");
                }
            }
            if (!found)
            {
                ViewBag.Error = ("Incorrect details");

            }
            return View();
        }

    }
}