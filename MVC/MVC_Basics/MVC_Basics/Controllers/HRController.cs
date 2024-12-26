using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        //3.  calling another view and passing the model object

        public ActionResult Index()
        {
            List<Department> d = new List<Department>();
            d.Add(new Department { Id = 10, Dname = "CSE" });
            d.Add(new Department { Id = 11, Dname = "ECE" });
            d.Add(new Department { Id = 12, Dname = "IT" });
            d.Add(new Department { Id = 13, Dname = "EEE" });
            return View("DepartmentList", d);
        }

        //1. Binding a model object to the view
        public ActionResult DisplayEmployee()
        {
            Employee e = new Employee() { ID = 1, Name = "Ajay", Age = 24 };
            return View(e); //view is being bound to a model object
        }

        //2. binding a model collection object to the view
        public ActionResult EmployeeList()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{ID=100, Name="Renuka",Age=25},
                 new Employee{ID=101, Name="Ramya",Age=24},
                  new Employee{ID=102, Name="Rajesh",Age=25},
            };
            return View(emplist);
        }

        //4.

        public ActionResult DepartmentList(Department dept)
        {
            return View(dept);
        }
    }
}