using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_DK23TTC10.Models;

namespace ASP_DK23TTC10.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            Entities1 db = new Entities1();
            List<service> post_dichvu = db.services.ToList();
            return View(post_dichvu);
        }
        [HttpPost]
        public ActionResult Index(string search_post = "")
        {
            Entities1 db = new Entities1();
            List<service> search = db.services.Where(tim => tim.name.Contains(search_post) || tim.description.Contains(search_post)).ToList();
            ViewBag.value_search = search_post;
            return View(search);
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return View("Incorrect");
            }
            Entities1 db = new Entities1();
            service detail_services = db.services.Where(row => row.id == id).FirstOrDefault();
            return View(detail_services);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(service s)
        {
            Entities1 db = new Entities1();
            db.services.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("Incorrect");
            }    
            Entities1 db = new Entities1();
            service services = db.services.Where(row => row.id == id).FirstOrDefault();
            return View(services);
        }
        [HttpPost]
        public ActionResult Edit(service sv)
        {
            Entities1 db = new Entities1();
            service services = db.services.Where(row => row.id == sv.id).FirstOrDefault();
            //Update database
            services.name = sv.name;
            services.description = sv.description;
            services.created_at = sv.created_at;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View("Incorrect");
            }
            Entities1 db = new Entities1();
            service del_services = db.services.Where(row => row.id == id).FirstOrDefault();
            return View(del_services);
        }
        [HttpPost]
        public ActionResult Delete(int id, service s)
        {
            Entities1 db = new Entities1();
            service del_services = db.services.Where(row => row.id == id).FirstOrDefault();
            db.services.Remove(del_services);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}