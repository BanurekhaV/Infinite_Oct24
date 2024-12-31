using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViews_Prj.Models;

namespace PartialViews_Prj.Controllers
{
    
    public class ProductController : Controller
    {
        List<Product> productlist;

        public ProductController()
        {
            productlist = new List<Product>()
            {
                new Product{ProductId = 1,ProductName = "Shoes",Category = "Accessories",
                Description = "Smooth Soles for Comfort", Price = 3500},
                new Product{ProductId = 2,ProductName = "Watches",Category = "Accessories",
                Description = "Smart and Usr Friendly", Price = 6500},
                new Product{ProductId = 3,ProductName = "Curtains",Category = "Furnishings",
                Description = "Valence For Windows", Price = 4000},
                new Product{ProductId = 4,ProductName = "Pillows",Category = "Beddings",
                Description = "Memory Foam for Comfort", Price = 2000},
            };
        }
        // GET: Product

        
        public ActionResult Index()
        {
           return View(productlist);
        }

        //2. normal method that takes up the list of products object
        public ActionResult AnotherMethod()
        {
            return View(productlist);
        }

        //3. partial view
        public PartialViewResult GetAllProducts()
        {
            List<Product> prdlist = new List<Product>()
            {
                new Product{ProductId = 1,ProductName = "Shoes",Category = "Accessories",
                Description = "Smooth Soles for Comfort", Price = 3500},
                new Product{ProductId = 2,ProductName = "Watches",Category = "Accessories",
                Description = "Smart and Usr Friendly", Price = 6500},
                new Product{ProductId = 3,ProductName = "Curtains",Category = "Furnishings",
                Description = "Valence For Windows", Price = 4000},
                new Product{ProductId = 4,ProductName = "Pillows",Category = "Beddings",
                Description = "Memory Foam for Comfort", Price = 2000},
            };
            return PartialView("ProductDetails", prdlist);
        }
    }
}