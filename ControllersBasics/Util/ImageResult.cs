using System.IO;
using System.Web.Mvc;

namespace ControllersBasics.Util
{
    public class ImageResult : ActionResult
    {
        private string path;

        public ImageResult(string path)
        {
            this.path = path;
        }
        
        public override void ExecuteResult(ControllerContext context)
        {
            // response.write = trimitem codul dat la iesire
            context.HttpContext.Response.Write("<div style = 'width:100%;text-align:center;'> " +
                                               "<img style='max-width:600px;' src = '" + path + "'/></div>");

        }
    }
}