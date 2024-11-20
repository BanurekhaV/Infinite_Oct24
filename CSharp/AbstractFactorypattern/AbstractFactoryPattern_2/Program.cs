using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern_2.Factories;
using AbstractFactoryPattern_2.AbstractProducts;


namespace AbstractFactoryPattern_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //regular products
            Console.WriteLine("----------Regular Products--------");
            IVehicleFactory regularfactory = new RegularVehicleFactory();

            
            IBike rbike = regularfactory.CreateBike();

            rbike.GetDetails();

            ICar rcar = regularfactory.CreateCar();
            rcar.GetDetails();

            //sports products
            Console.WriteLine("------Sports Products-------");

            IVehicleFactory sportsfactory = new SportsVehicleFactory();

            IBike sbike = sportsfactory.CreateBike();
            sbike.GetDetails();

            ICar scar = sportsfactory.CreateCar();

            scar.GetDetails();

            Console.Read();

        }
    }
}
