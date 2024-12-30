using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_DBFirst.Models;
using System.Data;
using System.Data.Entity;

namespace MVC_EF_DBFirst.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Products
        public ActionResult Index()
        {
            //we will use a concept of eager loading of the category model along with the supplier model
            var products = db.Products.Include(Pl => Pl.Category).Include(Pl => Pl.Supplier);
            return View(products.ToList());
        }

        //insertion of products
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            //for the categoryand supplier dropdown

            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName",product.CategoryID);
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName",product.SupplierID);
            return View(product);
        }
    }
}