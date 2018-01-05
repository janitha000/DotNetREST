using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotnetREST.Web.App_Code
{
    public class CustomMudule : IHttpModule
    {
        public void Dispose()
        {
            
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += (new EventHandler(this.AppBeginRequest));

        }

        private void AppBeginRequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;

            context.Response.Write("<h1><font color=red>" +
                "HelloWorldModule: Beginning of Request" +
                "</font></h1><hr>");
        }
    }
}