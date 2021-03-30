using System.Web.Mvc;

namespace ControllersBasics.Controllers
{
    public class BookController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}