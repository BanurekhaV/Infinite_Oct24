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
        
        public ActionResult Index()
        {
            //1. passing an object to the view that will be used as a model
            //List<string> flowers = new List<string>()
            //{ "Roses", "Lillies", "Jasmines", "Marigolds"};
            //return View(flowers);

            //2. trying to access TempData of earlier request here in this actionmethod and view
            //List<string> st;
            //st = TempData["stores"] as List<string>;
            //return View(st);  //Tempdata is accessible here also

            //3. redirect to another actionmethod and check if tempdata is accessible
            return RedirectToAction("TestTempDataValue");
        }

        public ActionResult TestTempDataValue()
        {
            //List<string> st2 = TempData["stores"] as List<string>;
            //return View(st2);   //tempdata is accessible even at the 4th request

            //we will now transfer the request to another controllers action method
            return RedirectToAction("Index", "Demo");
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

        //3.checking if the viewbag or viewdata can pass on the information to further requests
        public ActionResult TestDataTransfer()
        {
            ViewBag.Data1 = "Data One";
            ViewData["Data2"] = "Data Two";
            //  return View(); // Data Passed is accessed in the current view
            // return RedirectToAction("Index"); // redirecting to another actionmethod of the same controller
            return RedirectToAction("Contact", "Home"); // redirecting to another actionmethod of another controller
        }

        //4. using tempdata to transfer values across requests
        public ActionResult FirstTempRequest()
        {
            List<string> stationeries = new List<string>()
            {
                "pens","pencils","notebooks","erasers","markers"
            };
            TempData["stores"] = stationeries;
            //return View();  //this is the usual transfer from controller to view
           return RedirectToAction("SecondTempRequest");  
        }

        public ActionResult SecondTempRequest()
        {
            //List<string> stnlist;
            //stnlist = TempData["stores"] as List<string>;
            //return View(stnlist);    //works
            return RedirectToAction("Index");
        }

        //5. If we want to chnage the view name to be different from the action method name
        //5.1 we can give the action name selector and map it to a view of different name
        //5.2 we can change the name of the view to match the action name

        [ActionName("Test")]
        public ActionResult DifferentName()
        {
            ViewBag.sample = "Testing Views with different names";
            // return View("DifferentName");  //5.1
            return View();  //5.2
        }

    }
}