using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Linq_To_Sql_SqlMetal
{
    class Program
    {
        static string connstr =
            ConfigurationManager.ConnectionStrings["NwindConnStr"].ConnectionString;

        static NorthwindContext db = new NorthwindContext(connstr);
        static void Main(string[] args)
        {
            // Customers cust = new Customers();

            var custdetails = from c in db.Customers
                              orderby c.ContactName
                              select c;

            foreach (var item in custdetails)
            {
                Console.WriteLine($"{item.CustomerID}     {item.ContactName}      {item.CompanyName}    {item.Country}");
            }

            Console.Read();
        }
    }
}
