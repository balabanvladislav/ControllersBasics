using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllersBasics.Util;

namespace ControllersBasics.Controllers
{
    public class HomeController : Controller
    {
        public string GetId(int id)
        {
            return id.ToString();
        }

        public ActionResult NotFound()
        
        
        {
            return new HttpNotFoundResult("Opsie (:");
        }

        public ActionResult GetImage()
        {
            string path = "../Content/Images/avatar.jpg";
            return new ImageResult(path);
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

        public ActionResult Index()
        {
            return Redirect("~/Home/About/");
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