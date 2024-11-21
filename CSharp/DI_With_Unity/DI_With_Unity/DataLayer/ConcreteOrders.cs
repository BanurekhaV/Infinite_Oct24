using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_With_Unity.Abstractions;

namespace DI_With_Unity.DataLayer
{
    class ConcreteOrders : IOrders
    {
        public void DisplayOrders()
        {
            Console.WriteLine("These are the List of Products");
        }
    }
}
