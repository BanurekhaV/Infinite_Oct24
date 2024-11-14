using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Dotnet
{
    class NullOperations
    {
        static void Main()
        {
            Nullable<int> n = null;
            n = 100;
            int ? x = null;

            if(n.HasValue)
                Console.WriteLine(n.Value);
            else
                Console.WriteLine("Null");

            Employee emp = null;
            //  emp = new Employee() { Name = "Banurekha" };
            emp = new Employee();
            string ename = (emp != null) ? emp.Name : null;
            Console.WriteLine("Ename " + ename);

            //we can replace the above ternary operator with null condition operator ?

            string empname = emp ?.Name;
            Console.WriteLine("EmpName " + " " + empname);
            Console.Read();
        }
    }
}
