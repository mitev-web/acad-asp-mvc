using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCalendar.Models;

namespace WebCalendar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            IEnumerable<Category> model = Models.Category.GetAll();

            return View(model);
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
