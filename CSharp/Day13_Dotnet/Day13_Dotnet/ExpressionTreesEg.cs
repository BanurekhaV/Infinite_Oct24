using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Dotnet
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductFilter
    {
        public Expression<Func<Product, bool>> FilterCriteria { get; set; }

        
        static void Main()
        {
            var filter = new ProductFilter
            {
                FilterCriteria = p => p.Price < 100
            };
            var products = new List<Product>
            {
                new Product{Name = "Pens", Price = 50},
                new Product{Name = "Pencils", Price = 10},
                new Product{Name = "USB", Price = 250},
                new Product{Name = "Memory Card", Price = 500},
            };

            var lesspriceproducts = products.AsQueryable().Where(filter.FilterCriteria).ToList();

            foreach(var v in lesspriceproducts)
            {
                Console.WriteLine(v.Name + " " + v.Price);
            }
            Console.Read();
        }
    }
   
}
