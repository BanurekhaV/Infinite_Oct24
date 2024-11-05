using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Dotnet
{
    public interface ICustomer : ICustomer2
    {
        void Print(); //only decl.
        string Message(string s);
    }

    public interface ICustomer2 
    {
        void Show();
    }

    interface ISupplier
    {
        void DisplaySupplier();
    }
    class Customer : ICustomer, ISupplier
    {
        public void Print()
        {
            Console.WriteLine("ICustomers Print..");
        }
        public string Message(string uname)
        {
            return "Hi " + uname;
        }

        public void Show()
        {
           // throw new NotImplementedException();
        }

        public void DisplaySupplier()
        {
            //throw new NotImplementedException();
        }
    }
    class InterfaceEg
    {
        public static void Main()
        {
            Customer cust = new Customer();
            cust.Print();
            string msg = cust.Message("Harsh");
            Console.WriteLine(msg);
            Console.Read();
        }
      
        
    }
}
