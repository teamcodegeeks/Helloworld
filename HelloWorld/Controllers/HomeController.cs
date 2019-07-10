using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["MyTimeTemp"] = DateTime.Now.ToString();
            ViewBag.MyTime = DateTime.Now.ToString();
            return RedirectToAction("GotoHome", "Home");
        }

        public ActionResult GotoHome()
        {
            ViewData["MyTime"] = DateTime.Now.ToString();
            return View("MyHomePage");
        }
    }
}