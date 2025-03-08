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
            Entities db = new Entities();
            List<admin> admin = db.admin_deptrai.ToList();
            return View(admin);
        }
        public ActionResult dangky()
        {
            return View("Dangky");
        }
        [HttpPost]
        public ActionResult dangky(admin a)
        {
            Entities db = new Entities();
            db.admin_deptrai.Add(a);
            db.SaveChanges();
            return RedirectToAction("Dangky");
        }
        public ActionResult dangnhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult dangnhap(admin a)
        {
            Entities db = new Entities();
            var emailForrm = a.email;
            var passwordForm = a.password;

            var AdminCheck = db.admin_deptrai.SingleOrDefault(x => x.email.Equals(emailForrm) && x.password.Equals(passwordForm));

            if (AdminCheck != null)
            {
                Session["Admin"] = AdminCheck;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.LoginFail = "Đăng nhập thất bai, thông tin email hoặc password không chính xác";
                return View("Dangnhap");
            }
                
        }
        public ActionResult logout()
        {
            Session["Admin"] = null;
            return RedirectToAction("Index");
        }

        public ActionResult ctdvlienhe(int? id)
        {
            return View("ctdvlienhe");
        }
    }
}