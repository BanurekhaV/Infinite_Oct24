using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LINQQueries
{
    class DataTableEg
    {
        public static DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Product", typeof(string));

            dt.Rows.Add(1, "Sports Shoes");
            dt.Rows.Add(2, "Memory Sticks");
            dt.Rows.Add(3, "Swiss Chocolates");
            dt.Rows.Add(4, "Gucci Bags");
            return dt;
        }
    }
    class Linq_Datatable
    {
        static void Main()
        {
            DataTable dtforRetVal = DataTableEg.GetDataTable();

            //method syntax

            var result = dtforRetVal.AsEnumerable().Where(x => x.Field<int>("Id") == 4).FirstOrDefault();

            if(result !=null)
            {
                Console.WriteLine(result["Product"]);
            }
            else
                Console.WriteLine("No Product Found.");

            Console.WriteLine("**********************");

            //query syntax

            var drow = (from prod in dtforRetVal.AsEnumerable()
                        where prod.Field<int>("Id") == 3
                        select prod).FirstOrDefault();

            if (drow != null)
            {
                Console.WriteLine(drow["Id"] + " " + drow["Product"]);
            }
            else
                Console.WriteLine("No matching Product");

            //converting the enumerable collection back to a data table
            Console.WriteLine("**********Data from Data Table*************");
            var dt = dtforRetVal.AsEnumerable().Where(f => f.Field<int>("Id") > 1);

            DataTable tableAgain = dt.CopyToDataTable<DataRow>();

            foreach(DataRow dr in tableAgain.Rows)
            {
                foreach(DataColumn dc in tableAgain.Columns)
                {
                    Console.Write(dr[dc] + "   ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
