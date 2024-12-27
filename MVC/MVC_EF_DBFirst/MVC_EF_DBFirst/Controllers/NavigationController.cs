using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_DBFirst.Models;

namespace MVC_EF_DBFirst.Controllers
{
    public class NavigationController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Navigation
        public ActionResult Index()
        {
            return View();
        }

        //1. fetching data from multiple tables using navigation property
        public ActionResult MultipleData()
        {
            //dynamic mymodel = new ExpandoObject();
            //mymodel.OrderList = db.Orders.ToList();
            //mymodel.CustList = db.Customers.ToList();
            //mymodel.EmpList = db.Employees.ToList();
            //mymodel.shiplist = db.Shippers.ToList();
            //return View(mymodel);
            return View(db.Orders.ToList());
        }
    }
}