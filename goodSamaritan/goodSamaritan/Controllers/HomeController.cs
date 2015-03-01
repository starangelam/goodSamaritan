using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Mission, Vision, Values.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "CORPORATE OFFICE";

            return View();
        }
    }
}