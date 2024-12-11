using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static Model1Container db = new Model1Container();

        static void AddCars()
        {
            var car = new Cars
            {
               CarName = "Creta",
               CarCost = 2800000,
               ManufacturerMfr_ID = 1,
            };
            db.Cars.Add(car);
            db.SaveChanges();
        }

        static void ShowAllCars()
        {
            var car = db.Cars.ToList();

           foreach(var item in car)
            {
                Console.WriteLine(item.CarID + " " + item.CarName + " " + item.CarCost);
            }
        }

        static void ShowAllManufacturers()
        {
            var m = db.Manufacturers.ToList();

            foreach(var item in m)
            {
                Console.WriteLine(item.Mfr_ID + " " + item.Mfr_Name + " " + item.CarType);
            }
        }
        static void Main(string[] args)
        {
            AddCars();
            ShowAllCars();
            ShowAllManufacturers();
            Console.Read();
        }
    }
}
