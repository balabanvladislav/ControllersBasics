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
        public string GetContext()
        {
            string browser = HttpContext.Request.Browser.Browser;
            string user_agent = HttpContext.Request.UserAgent;
            string url = HttpContext.Request.RawUrl;
            string ip = HttpContext.Request.UserHostAddress;
            string referrer = HttpContext.Request.UrlReferrer == null
                ? "" 
                : HttpContext.Request.UrlReferrer.AbsoluteUri;
            return "<p>Browser: " + browser+"</p><p>User-Agent: "+user_agent+"</p><p>Url запроса: "+url+
                   "</p><p>Реферер: " + referrer + "</p><p>IP-адрес: "+ip+"</p>";
        }

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
            return View();
        }

        public FileResult GetFile()
        {
            // drumul catre file
            string file_path = Server.MapPath("~/Files/MyCV.pdf");
            // tipul failului
            string file_type = "application/pdf";
            // numele fileului ( nu e necesar)
            string file_name = "MyCV.pdf";
            return File(file_path, file_type, file_name);
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