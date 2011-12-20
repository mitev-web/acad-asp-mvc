using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusic.Controllers
{
    public class HelloWorldController : Controller
    {


        //
        // GET: /HelloWorld/

        public string Index()
        {
            return "def action";
        }


        public string Welcome(string name, int numTimes)
        {
            
            return HttpUtility.HtmlEncode("Hello "+name + ", NumTimes is:"+ numTimes);
        }

    }
}
