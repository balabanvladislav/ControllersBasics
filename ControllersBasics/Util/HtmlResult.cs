using System.Web.Mvc;
namespace ControllersBasics.Util
{
    public class HtmlResult : ActionResult
    {
        private string htmlCode;

        public HtmlResult(string htmlCode)
        {
            this.htmlCode = htmlCode;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            string fullHtmlCode = "<!DOCTYPE html><html<head>";
            fullHtmlCode += "<title>Pagina principala</title>";
            fullHtmlCode += "<meta charset='utf-8'/>";
            fullHtmlCode += "</head> <body>";
            fullHtmlCode += htmlCode;
            fullHtmlCode += "</body></html>";
            context.HttpContext.Response.Write(fullHtmlCode);
        }
    }
}