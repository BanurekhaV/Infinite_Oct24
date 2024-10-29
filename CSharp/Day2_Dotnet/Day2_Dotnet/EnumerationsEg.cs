using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    enum cities
    {
        Agra=3, Bangalore=1, Chennai=2, Hyderabad=5, Kolkatta=4, Noida=7, Vizag=6
    }
    class EnumerationsEg
    {
        enum Days { Mon,Tue,Wed,Thur,Fri,Sat,Sun}

        public static void EnumOps()
        {
            foreach(int x in Enum.GetValues(typeof(cities)))
            {
                if (x == 1)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " " + " Is a Garden City");
                else if (x == 2)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " " + " Is a Temple City");
                else if (x == 6)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " " + " Is a Steel City");
            }

            foreach(var v in Enum.GetNames(typeof(cities)))
            {
                Console.WriteLine(v);
            }

            int wkstart =(int) Days.Mon;
            int wkend = (int)Days.Fri;
            Console.WriteLine("Monday : {0}", wkstart);
            Console.WriteLine("Friday : {0}", wkend);
        }
    }
}
