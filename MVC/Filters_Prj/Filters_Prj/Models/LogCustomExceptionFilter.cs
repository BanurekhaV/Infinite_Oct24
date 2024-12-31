using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Filters_Prj.Models
{
    public class LogCustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            //we shall log the exception in a text file
            if(!filterContext.ExceptionHandled)
            {
                var exceptionmessage = filterContext.Exception.Message;
                var stacktrace = filterContext.Exception.StackTrace;
                var controllername = filterContext.RouteData.Values["controller"].ToString();
                var actionname = filterContext.RouteData.Values["action"].ToString();
                var etype = filterContext.Exception.GetType();

                string msg = "Date : " + DateTime.Now.ToString() + ", Controller is : " +
                    " " + controllername + " " + ", Action Method is :" + actionname +
                    " " + ", Error Message :" + exceptionmessage + " "  + ", Exception Type :" +
                    " "+ etype;

                File.AppendAllText(HttpContext.Current.Server.MapPath("~/ErrorLog/Log.txt"), msg);

                filterContext.ExceptionHandled = true;

                if(etype.Equals(typeof(System.NullReferenceException)))
                {
                    filterContext.Result = new ViewResult() { ViewName = "NullReference" };
                }
                else if(etype.Equals(typeof(System.DivideByZeroException)))
                {
                    filterContext.Result = new ViewResult() { ViewName = "DivideByzero" };
                }
                else
                {
                    filterContext.Result = new ViewResult() { ViewName = "Error" };
                }
            }
        }
    }
}