﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_DK23TTC10.Models;

namespace ASP_DK23TTC10.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            Entities db = new Entities();
            List<user> users = db.users.ToList();
            return View(users);
        }
    }
}