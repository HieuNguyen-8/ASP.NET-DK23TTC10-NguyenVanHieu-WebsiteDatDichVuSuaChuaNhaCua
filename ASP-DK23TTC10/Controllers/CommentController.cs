using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_DK23TTC10.Models;

namespace ASP_DK23TTC10.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            Entities db = new Entities();
            List<comment> comment = db.comment1.ToList();
            
            return View(comment);
        }
    }
}