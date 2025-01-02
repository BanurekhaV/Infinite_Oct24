using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Security_Prj.Models;
using System.Web.Security;


namespace Security_Prj.Controllers
{

    //allow us to sign -in , sing-up, and logout
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        //login get
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User umodel)
        {
            using(SecurityMVCEntities context = new SecurityMVCEntities())
            {
                bool IsvalidUser = context.Users.Any(user => user.UserName.ToLower() ==
               umodel.UserName.ToLower() && user.UserPassword == umodel.UserPassword);

                if(IsvalidUser)
                {
                    FormsAuthentication.SetAuthCookie(umodel.UserName, false);
                    return RedirectToAction("Index", "Employees");
                }

                ModelState.AddModelError("", "Invalid UserName or Password");
                return View();
            }
        }

        //for signup

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User umodel)
        {
            using(SecurityMVCEntities context = new SecurityMVCEntities())
            {
                context.Users.Add(umodel);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        //logout
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}