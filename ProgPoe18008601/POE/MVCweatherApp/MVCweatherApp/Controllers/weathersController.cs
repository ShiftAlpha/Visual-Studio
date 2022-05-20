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
    public class weathersController : Controller
    {
        private weatherapp db = new weatherapp();

        // GET: weathers
        public ActionResult Index()
        {
            var weathers = db.weathers.Include(w => w.City);
            return View(weathers.ToList());
        }

        // GET: weathers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            weather weather = db.weathers.Find(id);
            if (weather == null)
            {
                return HttpNotFound();
            }
            return View(weather);
        }

    }
}
