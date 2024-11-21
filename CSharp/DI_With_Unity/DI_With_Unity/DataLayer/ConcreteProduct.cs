using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_With_Unity.Abstractions;

namespace DI_With_Unity.DataLayer
{
    class ConcreteProduct : IProducts
    {
        public string InsertProducts()
        {
            string str = "DI Injected Successfully";
            Console.WriteLine(str);
            return str;
        }
    }
}
