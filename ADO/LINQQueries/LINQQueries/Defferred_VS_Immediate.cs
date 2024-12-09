using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQueries
{
    class Employee
    {
        public int Eid { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
    }
    class Defferred_VS_Immediate
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee{Eid=1,Name="Ram",Salary=54000},
                new Employee{Eid=2,Name="Robert",Salary=30000},
                new Employee{Eid=3,Name="Rahim",Salary=42000},
            };

            //deferred linq

            //linq query construction
           // var emp = employees.Where(e => e.Salary < 35000).Select(n => n.Name);

            //immediate query construction
            var emp = employees.Where(e => e.Salary < 35000).Select(n => n.Name).ToList();

            //adding a new employee record
            employees.Add(new Employee { Eid = 4, Name = "Infinite", Salary = 28000 });
            
            foreach (var item in emp)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
