using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Html_Helpers_Prj.Models;

namespace Html_Helpers_Prj.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //1. strongly typed helper
        public ActionResult StronglyTypedHelper()
        {
            return View();
        }

        //2. Templated Helper

        public ActionResult TemplatedHelper()
        {
            return View();
        }

        //3 Templated helper for the entire Model

        public ActionResult TemplateForModel()
        {
            return View();
        }

        //4. Display Template
        public ActionResult StdDetails()
        {
            Student stud = new Student()
            {
                RollNo = 1,
                Name = "Manmohan Jain",
                Address = "Hyderabad"
            };
            ViewData["stddata"] = stud;
            return View(stud);
        }
        
        //5. Standard Helper

        public ActionResult StandardHelper()
        {
            return View();
        }
    }
}