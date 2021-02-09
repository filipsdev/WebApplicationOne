using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationOne.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestView()
        {
            // return a 'testvew.cshtml' - view maps to the action method name
            return View();
        }
        public string Welcome(string Name, int numTimes = 1)
        {
            // return a 'testvew.cshtml' - view maps to the action method name
            return HttpUtility.HtmlEncode("Hello " + Name + " Number of Times is " + numTimes);
        }
        public string Welcome2(string Name, int ID = 1)
        {
            // return a 'testvew.cshtml' - view maps to the action method name
            return HttpUtility.HtmlEncode("Hello " + Name + " ID is " + ID);
        }

        public ActionResult ErrorMessage()
        {
            // return a 'ErrorMessage.cshtml' - view maps to the action method name
            return View();
        }

        public string PrintMessage()
        {
            return "<h1>Welcome</h1><p>This is the first custom page of your application</p>";
        }
        public string Play()
        {
            return "<h1>Let's Play</h1><p>This is the first custom page of your application</p>";
        }
    }
}