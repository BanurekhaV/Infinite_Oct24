using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoredProcedure_Prj.Models;

namespace StoredProcedure_Prj.Controllers
{
    public class EDController : Controller
    {
        EDContext db = new EDContext();
        // GET: ED
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        //create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Employee e = db.Employees.Find(Id);

            return View(e);
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            Employee emp = db.Employees.Find(e.Id);
            return View();
        }
    }
}