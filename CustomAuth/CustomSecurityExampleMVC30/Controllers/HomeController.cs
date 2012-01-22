using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomSecurityExampleMVC30.Models;

namespace CustomSecurityExampleMVC30.Controllers
{
    public class HomeController : BaseController
    {
        [Authorize]
        public ActionResult Index()
        {
            return View(
                new IndexPageViewModel
                {
                    CurrentUsername = 
                        this.User.Identity.Name
                });
        }
    }
}
