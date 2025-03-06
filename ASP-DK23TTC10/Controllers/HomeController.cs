using ASP_DK23TTC10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_DK23TTC10.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ctdvlienhe(int? id)
        {
            if (id == null)
            {
                return View("Incorrect");
            }
            Entities1 db = new Entities1();
            service ctdvlienhe = db.services.Where(row => row.id == id).FirstOrDefault();
            return View(ctdvlienhe);
        }
    }
}