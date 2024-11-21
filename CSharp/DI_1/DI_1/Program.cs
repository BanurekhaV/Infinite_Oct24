using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of employeebal which inturn creates employeeDAL
            //Constructor DI
            //EmployeeBAL ebal = new EmployeeBAL(new EmployeeDAL());
            //List<Employee> elist = ebal.GetAllEmployees();


            //property DI
            EmployeeBAL ebal = new EmployeeBAL();
            ebal.Empobj = new EmployeeDAL();
            List<Employee> elist = ebal.GetAllEmployees();

            //method DI 
            //EmployeeBAL ebal = new EmployeeBAL();
            //List<Employee> elist = ebal.GetAllEmployees(new EmployeeDAL());

            foreach (Employee e in elist)
            {
                Console.WriteLine($"ID is {e.ID}, Name is {e.Name} and the Department is {e.Department}");
            }
            Console.Read();
        }
    }
}
