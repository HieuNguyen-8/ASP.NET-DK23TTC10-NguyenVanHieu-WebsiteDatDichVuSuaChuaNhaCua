﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_DK23TTC10.Models;

namespace ASP_DK23TTC10.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            Entities db = new Entities();
            List<order> order = db.orders.ToList();
            return View(order);
        }
    }
}