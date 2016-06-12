using System;
using System.Net;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ErrorsController : Controller
    {
        public ActionResult Error()
        {
            Response.TrySkipIisCustomErrors = true;
            Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return View();
        }
        
        public ActionResult NotFound()
        {
            Response.TrySkipIisCustomErrors = true;
            Response.StatusCode = (int)HttpStatusCode.NotFound;
            return View("Error");
        }

        public ActionResult ThrowError(string status)
        {
            throw new Exception();
        }
    }
}