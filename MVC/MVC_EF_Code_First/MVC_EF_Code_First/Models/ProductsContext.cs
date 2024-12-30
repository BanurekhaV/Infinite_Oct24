using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_EF_Code_First.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext() : base("name= connectstr") { }

        public DbSet<Products> Product { get; set; }
        public DbSet<Sales> Sale { get; set; }
    }
}