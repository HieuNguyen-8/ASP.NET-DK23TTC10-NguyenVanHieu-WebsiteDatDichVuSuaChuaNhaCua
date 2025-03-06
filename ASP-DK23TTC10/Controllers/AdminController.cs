using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_DK23TTC10.Models;

namespace ASP_DK23TTC10.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            Entities1 db = new Entities1();
            List<admin> admin = db.admin_deptrai.ToList();
            return View(admin);
        }
        public ActionResult dangky()
        {
            return View("Dangky");
        }
        public ActionResult dangnhap()
        {
            return View("Dangnhap");
        }
        public ActionResult ctdvlienhe(int? id)
        {
            return View("ctdvlienhe");
        }
    }
}