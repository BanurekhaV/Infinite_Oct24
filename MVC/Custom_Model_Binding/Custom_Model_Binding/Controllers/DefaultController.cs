using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Custom_Model_Binding.CustomBinders;
using Custom_Model_Binding.Models;

namespace Custom_Model_Binding.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([ModelBinder(typeof(CustomDataBinder))]CustomModel cm)
        {
            ViewBag.SplTitle = cm.Title;
            ViewBag.Date = cm.Date;
            return View(cm);
        }

        public ActionResult Bundling_Method()
        {
            return View();
        }
    }
}