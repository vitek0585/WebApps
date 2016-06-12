using System;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Web.Controllers;

namespace Web.Core
{
    public class InterceptorErrors
    {
        private readonly HttpContext _httpContext;

        public InterceptorErrors()
        {
            _httpContext = HttpContext.Current;
        }

        public void HandleError(Exception exception)
        {
            _httpContext.Response.Clear();
            _httpContext.Server.ClearError();

            if (!IfAjaxRequest())
            {
                RouteData routeData = new RouteData();
                routeData.Values["controller"] = "Errors";
                _httpContext.Response.Clear();

                routeData.Values["action"] = "Error";
                var httpException = exception as HttpException;

                if (httpException != null && httpException.GetHttpCode() == (int)HttpStatusCode.NotFound)
                {
                    routeData.Values["result"] = "404";
                }
                else
                {
                    routeData.Values["result"] = "500";
                }

                IController errorController = new ErrorsController();
                errorController.Execute(new RequestContext(new HttpContextWrapper(_httpContext), routeData));
            }
            else
            {
                _httpContext.Response.Write("error");
                _httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                _httpContext.Response.End();
            }
        }

        private bool IfAjaxRequest()
        {
            var ajaxHeader = HttpContext.Current.Request.Headers["X-Requested-With"];
            if (ajaxHeader != null)
            {
                return ajaxHeader == "XMLHttpRequest";
            }

            return false;
        }

    }
}