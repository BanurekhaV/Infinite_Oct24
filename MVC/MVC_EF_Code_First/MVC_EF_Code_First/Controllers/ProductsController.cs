using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_Code_First.Models;
using MVC_EF_Code_First.Repository;

namespace MVC_EF_Code_First.Controllers
{
    public class ProductsController : Controller
    {
        IProductRepository<Products> _prdrepo = null;

        //constructor
        public ProductsController()
        {
            _prdrepo = new ProductRepository<Products>();
        }
        // 1. GET: Products
        public ActionResult Index()
        {
            var prod = _prdrepo.GetAll();
            return View(prod);
        }

        //2. create new Products
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Products p)
        {
            if(ModelState.IsValid)
            {
                _prdrepo.Insert(p);
                _prdrepo.Save();
                return RedirectToAction("Index");
            }
            return View(p);
        }

        //3. edit
        public ActionResult Edit(int Id)
        {
            var product = _prdrepo.GetById(Id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Products p)
        {
            if(ModelState.IsValid)
            {
                _prdrepo.Update(p);
                _prdrepo.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(p);
            }
        }

        //4. Details
        public ActionResult Details(int Id)
        {
            var product = _prdrepo.GetById(Id);
            return View(product);
        }
    }
}