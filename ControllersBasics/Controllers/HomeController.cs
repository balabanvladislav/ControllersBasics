using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersBasics.Controllers
{
    public class HomeController : Controller
    {
        public string GetId(int id)
        {
            return id.ToString();
        }

        public string Square(int a, int h)
        {
            double s = a * h / 2;
            return "<h2> Perimetrul triunghiului cu baza " + a + " si inaltimea " +
                   h + " este " + s + " </h2>";
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}