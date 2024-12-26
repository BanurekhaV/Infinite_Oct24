using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        //1. Normal method
        public string NormalMethod()
        {
            return "Hi All !!";
        }
      

        //2. viewresult
        public ViewResult ViewMethod()
        {
            return View();
        }
           
        //3. ContentResult
        public ContentResult contentMethod()
        {
           // return Content("Hello All !!", "text/plain");

            return Content("<h1>Good Morning All </h1>", "text/html");
        }

        //4. empty result, that does not return any proper view to the user
        //in order not to have an entry of such methods in the routing table, we can decorate it with non-action
       [NonAction]
        public EmptyResult Empty()
        {
            int amt = 45000;
            float si = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        //5. json result
        public JsonResult Empdata()
        {
            Employee emp = new Employee();
            emp.ID = 101;
            emp.Name = "Sekhar";
            emp.Age = 22;
            return Json(emp,JsonRequestBehavior.AllowGet);                
        }

        //6. redirect

        public ActionResult redirectMethod()
        {
            //redirecting to the action method of the same controller
           // return RedirectToAction("empdata");

            //redirecting to action methods of other controllers
            return RedirectToAction("about", "home");
        }
    }
}