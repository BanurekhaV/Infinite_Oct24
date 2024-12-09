using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Sql_VS
{
    class Program
    {
        static MydbmlDataContext db = new MydbmlDataContext();
        static void Main(string[] args)
        {
            var emp = db.tblEmployees.ToList();

            foreach(var e in emp)
            {
                Console.WriteLine($"Empid {e.EmpId}, EmployeeName {e.EmpName} and salary is {e.Salary}");
            }
            Console.Read();
        }
    }
}
