using System.Web.Mvc;
using System.Web.Routing;

namespace ControllersBasics.Controllers
{
    public class MyController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            string ip = requestContext.HttpContext.Request.UserHostAddress;
            var response = requestContext.HttpContext.Response;
            response.Write("<h2> Adresa IP a voastra:" + ip + "</h2>");
        }
    }
}