using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Dotnet
{
    class LambdaExpressions
    {
        static void Main(string[] args)
        {                                    //List initilaization
            List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };

            foreach(var value in numbers)
            {
                Console.Write("{0} ", value);               
            }

            //using lambda expressions to find the square of all numbers in the List
            var square = numbers.Select(x => x * x);

            Console.WriteLine("-----Squares of Numbers------");
            foreach(int v in square)
            {
                Console.Write("{0} ", v);
            }

            //find all the numbers divisible by 3 in the list

            Console.WriteLine("***** Lambda Expressions with UD datatypes-----");

            List<Employee> emplist = new List<Employee>()
            {
                new Employee{ID = "101", Name = "Sriteja"},
                new Employee{ID = "102", Name = "Bhanuprakash"},
                new Employee{ID = "103", Name = "Bharghav"},
            };

            //find the details of an employee with ID=102
            Employee e = emplist.Find(emp => emp.ID == "105");

            if(e!=null)
            {
                Console.WriteLine("ID : {0} , Name : {1} ", e.ID, e.Name);
            }
            else
                Console.WriteLine("Employee not found");

            //sort all employees in the list by their name
           IEnumerable<Employee> sortedEmployees = emplist.OrderBy(n => n.Name);

            foreach(var emp in sortedEmployees)
            {
                Console.WriteLine(emp.Name);
            }
            Console.Read();
        }
    }

    class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
