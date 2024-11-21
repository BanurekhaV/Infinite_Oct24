using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DI_With_Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer uc = new UnityContainer();

            //register all relevant types
            uc.RegisterType<Abstractions.IProducts, DataLayer.ConcreteProduct>();
            uc.RegisterType<Abstractions.IOrders, DataLayer.ConcreteOrders>();

            //invoking the DI enabled methods
            BusinessLayer bl = uc.Resolve<BusinessLayer>();
            Console.WriteLine(bl.Insert()); 
            bl.Display();

            Console.Read();
        }
    }
}
