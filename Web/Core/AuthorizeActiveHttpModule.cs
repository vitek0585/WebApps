using System;
using System.Web;

namespace Web.Core
{
    public class AuthorizeActiveHttpModule:IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.AuthorizeRequest += Context_AuthorizeRequest;
        }

        public void Dispose()
        {
        }

        private void Context_AuthorizeRequest(object sender, EventArgs e)
        {
            throw new Exception();
        }

    }
}