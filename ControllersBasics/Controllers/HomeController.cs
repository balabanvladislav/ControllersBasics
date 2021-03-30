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

        [HttpGet]
        public ActionResult GetBook()
        {
            return View();
        }

        [HttpPost]
        // title si author el le ia din forma, acolo sunt 2 casete cu aceste name, cand apasam submit, sistema leaga
        // datele
        public ActionResult PostBook()
        {
            ViewBag.booktitle = Request.Params["title"];
            ViewBag.author = Request.Params["author"];
            return View();
        }

        public string Square()
        {
            int a = Int32.Parse(Request.Params["a"]);

            int h = Int32.Parse(Request.Params["h"]);
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