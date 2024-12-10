using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst_EntityStates
{
    class Program
    {
        //let us create an instance of the database Context class

        static InfiniteDBEntities db = new InfiniteDBEntities();
        static void Main(string[] args)
        {
            var emp = db.tblEmployees.ToList();

            foreach(var item in emp)
            {
                Console.WriteLine($"Employee : {item.EmpName} Earns a Salary of : {item.Salary}, and works for Department: {item.DeptId}");
            }
            Console.Read();
        }
    }
}
