using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels_Prj.Models;

namespace ViewModels_Prj.Controllers
{
    public class ViewModelController : Controller
    {
        // GET: ViewModel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Employeedetails()
        {
            Employee e = new Employee()
            {
                EId = 101,
                EName = "Joshitha",
                Salary = 58000,
                AddressId = 1
            };
            Address addr = new Address()
            {
                AddressId = 1,
                DoorNo = "4, ABC Villa",
                Street = "GulliNo 420",
                City = "Mycity"
            };

            //create a view Model object
            EmployeeAddress empadd = new EmployeeAddress()
            {
                employee = e,
                address = addr,
                PageTitle = "Employee Personal Details"
            };
            return View(empadd);
        }
    }
}