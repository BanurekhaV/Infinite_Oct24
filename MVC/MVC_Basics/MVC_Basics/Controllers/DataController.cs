using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basics.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        //1. passing an object to the view that will be used as a model
        public ActionResult Index()
        {
            List<string> flowers = new List<string>()
            { "Roses", "Lillies", "Jasmines", "Marigolds"};
            return View(flowers);
        }

        //2. Passing data thru viewbag and viewdata
        public ActionResult officeRules()
        {
            List<string> rules = new List<string>()
            {
                "Be on time", "Carry ID card", "Avoid TShirts","Complete Work as per deadlines"
            };
            //1. transfer the data using viewbag
            // ViewBag.offrules = rules;

            //2. trabsfer data using viewdata
            ViewData["followrules"] = rules;
            return View();
        }
    }
}