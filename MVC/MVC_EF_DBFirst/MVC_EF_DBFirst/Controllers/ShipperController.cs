using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_DBFirst.Models;

namespace MVC_EF_DBFirst.Controllers
{
    public class ShipperController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Shipper
        public ActionResult Index()
        {
            return View(db.Shippers.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //1. passing data from view to controller using form collection
        //public ActionResult Create(FormCollection frm)
        //{
        //    Shipper s = new Shipper();
        //    s.ShipperID = Convert.ToInt32(frm["ShipperID"]);
        //    s.CompanyName = frm["CompanyName"].ToString();
        //    s.Phone = frm["Phone"].ToString();

        //    db.Shippers.Add(s);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //2. using parameter collections
        public ActionResult Create(string CompanyName, string Phone)
        {
            Shipper s = new Shipper();
            s.CompanyName = CompanyName;
            s.Phone = Phone;
            db.Shippers.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Shipper s = db.Shippers.Find(Id);
            return View(s);
        }

        [HttpPost]
        public ActionResult Edit(FormCollection frm)
        {
            Shipper s = db.Shippers.Find(Convert.ToInt32(frm["ShipperID"]));
            s.CompanyName = frm["CompanyName"].ToString();
            s.Phone = frm["Phone"].ToString();
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //calling a procedure with input
        public ActionResult Sp_With_Input()
        {
            return View(db.CustOrdersOrders("ALFKI"));
        }
    }
}