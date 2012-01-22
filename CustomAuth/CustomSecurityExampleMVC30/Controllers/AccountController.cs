using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomSecurityExampleMVC30.Models;

namespace CustomSecurityExampleMVC30.Controllers
{
    public class AccountController : BaseController
    {
        public ActionResult Login()
        {
            var vm = new LoginPageViewModel
            {
                Username = "Username",
                Password = "Password"
            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult Login(LoginPageViewModel viewModel)
        {
            if (string.IsNullOrEmpty(viewModel.Username)
                || string.IsNullOrEmpty(viewModel.Password))
            {
                viewModel.ErrorMessage = "Please provide your username and password";
                return View(viewModel);
            }

            SimpleSessionPersister.Username = viewModel.Username;

            return RedirectToAction("Index", "Home");
        }
    }
}
