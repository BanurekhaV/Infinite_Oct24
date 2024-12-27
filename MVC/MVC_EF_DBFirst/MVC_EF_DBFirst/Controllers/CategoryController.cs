using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_DBFirst.Models;

namespace MVC_EF_DBFirst.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Category
        //1. The below action method uses scaffolded view template
        public ActionResult Index()
        {
            List<Category> catlist = db.Categories.ToList();
            return View(catlist);
        }

        //2. The below action method does not use scaffolded view
        public ActionResult GetCategoryDetails()
        {
            List<Category> catlist = db.Categories.ToList();
            return View(catlist);
        }

        //3. Add a new Category

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category c)
        {
            db.Categories.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //4. delete a category
        public ActionResult Delete(int Id)
        {
            Category cat = db.Categories.Find(Id);
            return View(cat);
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteCategory(int Id)
        {
            Category c = db.Categories.Find(Id);
            db.Categories.Remove(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //5 edit a category
        [HttpGet]
        public ActionResult Update(int Id)
        {
            Category c = db.Categories.Find(Id);
            return View(c);
        }

        public ActionResult Update(Category c)
        {
            Category cat = db.Categories.Find(c.CategoryID);
            cat.CategoryName = c.CategoryName;
            cat.Description = c.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //6. details
        public ActionResult Details(int Id)
        {
            Category c = db.Categories.Find(Id);
            return View(c);
        }

        //7. action method that sorts the category by name
        public ActionResult GetCategoryByName()
        {
            List<string> sortedcatnames = (from c in db.Categories
                                           orderby c.CategoryName
                                           select c.CategoryName).ToList();
            return View(sortedcatnames);
        }
    }
}