using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Dotnet
{
    class Employee
    {
        public static int objctr = 0;

        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Eid { get; set; }
        public string Dept { get; set; }
        public Employee()
        {
            ++objctr;
        }
    }
    class Factory
    {
        // max objects req
        static int maxpoolsize = 3;

        //collection pool for our program
        static readonly Queue objpool = new Queue(maxpoolsize);

        public Employee GetEmployee()
        {
            Employee eobj;
            //check from the pool collection for an object
            // if exists return; else create new object
            if(Employee.objctr >= maxpoolsize && objpool.Count > 0 )
            {
                //retrieve object from the pool
                eobj = RetrieveFromPool();
            }

            else
            {
                eobj = GetNewEmployee();
            }
            return eobj;
        }

        Employee GetNewEmployee()
        {
            Employee e = new Employee();
            objpool.Enqueue(e);
            return e;
        }

        protected Employee RetrieveFromPool()
        {
            Employee e;
            //check if there are any objects in our collection
            if(objpool.Count > 0)
            {
                e = (Employee)objpool.Dequeue();
                Employee.objctr--;
            }
            else
            {
                //return a new object
                e = GetEmployee();
            }
            return e;
        }
    }
    class ObjectPoolinEg
    {
        static void Main()
        {
            Factory factory = new Factory();
            Employee emp1 = factory.GetEmployee();
            Console.WriteLine("First Employee Object");
            Employee emp2 = factory.GetEmployee();
            Console.WriteLine("Second Employee Object");
            Employee emp3 = factory.GetEmployee();
            Console.WriteLine("Third Employee Object");
            Employee e4 = factory.GetEmployee();
            Console.WriteLine("Fourth  Employee a pooled Object");
            Employee e5 = factory.GetEmployee();
            Console.WriteLine("Hi Employee");
            Console.Read();
        }
    }
}
