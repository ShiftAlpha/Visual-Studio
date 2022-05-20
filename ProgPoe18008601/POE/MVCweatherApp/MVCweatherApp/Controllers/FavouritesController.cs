using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCweatherApp.Models;

namespace MVCweatherApp.Controllers
{
    public class FavouritesController : Controller
    {
        private weatherapp db = new weatherapp();

        // GET: Favourites
        public ActionResult Index()
        {
            var favourites = db.Favourites.Include(f => f.City).Include(f => f.User);
            return View(favourites.ToList());
        }

        // GET: Favourites/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Favourite favourite = db.Favourites.Find(id);
            if (favourite == null)
            {
                return HttpNotFound();
            }
            return View(favourite);
        }


    }
}
