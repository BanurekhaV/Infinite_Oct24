using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Dotnet
{

    public class Person { }
    public class Employees : Person { }

    public class Manager : Employees { }

    delegate Person persondelegate(Employees emp);  //argument is more derived type
    class Co_ContravarianceEg
    {
        static void Main(string[] args)
        {
            //covariance 

            var personobj = new Person();
            var empobj = new Employees();
            var mgrobj = new Manager();

            personobj = empobj; //or personobj = new Employees();
            personobj = mgrobj; // or personobj = new Manager();

            empobj = mgrobj;

            empobj = (Employees)personobj;

            //contravariance
            persondelegate pd = WishPerson;          

        }

        static Person WishPerson(Person p)  //parameter passed is less derived type
        {
            Console.WriteLine("Hello and Welcome Mr/Ms " + p);
            return p;
        }
    }
}
