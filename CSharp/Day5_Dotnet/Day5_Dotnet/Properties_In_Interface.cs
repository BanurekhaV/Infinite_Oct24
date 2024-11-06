using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Dotnet
{
    interface IName
    {
       string Name { get; set; }
    }

    class Employee : IName
    {
        public string Name { get ; set; }
    }

    class Company : IName
    {
        string _company { get; set; }
        public int _age { get; } = 25;

        public string Name
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }

        //public int Age
        //{
        //    get
        //    {
        //        return _age;
        //    }
        //}
    }
    class Properties_In_Interface
    {
        static void Main()
        {
            IName nm = new Employee();
            nm.Name = "Bharghav";

           
            Company c = new Company();
            c.Name = "Infinite Ltd.,";
           

            Console.WriteLine("{0} is from {1} and it is {2} years old", nm.Name, c.Name,c._age );
            Console.Read();
        }
    }
}
