using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern_2.AbstractProducts;

namespace AbstractFactoryPattern_2.ConcreteProducts
{
    public class SportsCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Details of Sports Car ...");
        }
    }
}
