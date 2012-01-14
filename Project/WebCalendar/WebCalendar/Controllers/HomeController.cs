﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalendar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            WebCalendarEntities wc = new WebCalendarEntities();

            foreach (Meeting m in wc.Meetings)
            {
                ViewBag.Message += m.Date;

            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
