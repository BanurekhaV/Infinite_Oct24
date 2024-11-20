using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern_2.AbstractProducts;

namespace AbstractFactoryPattern_2.Factories
{
    public interface IVehicleFactory
    {
        //methods for abstract product 1 and 2

        IBike CreateBike();
        ICar CreateCar();
    }
}
