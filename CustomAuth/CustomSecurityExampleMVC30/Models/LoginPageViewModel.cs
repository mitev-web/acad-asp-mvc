using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomSecurityExampleMVC30.Models
{
    public class LoginPageViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ErrorMessage { get; set; }
    }
}