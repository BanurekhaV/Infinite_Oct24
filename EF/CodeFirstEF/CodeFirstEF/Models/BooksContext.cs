using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstEF.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext() : base("name = BooksConnection") { }

        public DbSet<Books> book { get; set; }
        public DbSet<Author> author { get; set; }
    }
}
