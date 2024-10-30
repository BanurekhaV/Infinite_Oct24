using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Dotnet
{
    class Employee
    {
        //fields
        int EmpId;
        string EmpName;
        double Salary;
        DateTime Dob;

        //constructor 1. empty
        public Employee()
        {
            Console.WriteLine($"Reached Empty Constructor {EmpId}, {EmpName}, {Salary}, {Dob}");
        
        }

        //construct 2. parameterized
        public Employee(int EmpId, string ename)
        {
            this.EmpId = EmpId;
            EmpName = ename;
            Console.WriteLine($"Reached 2 parameter Constructor {EmpId}, {EmpName}, {Salary}, {Dob}");
        }

        //destructor
        ~Employee()
        {
            Console.WriteLine("Bye from Employee");
            Console.Read();
        }
        
    }
}
