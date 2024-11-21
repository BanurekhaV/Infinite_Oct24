﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_2.ConcreteProducts
{
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Details of Regular Bikes...");
        }
    }
}