using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Dotnet
{
    class Infinite
    {
        string[] names = new string[3];

        //define indexer 1

        public string this[int flag]
        {
            get 
            {
                return names[flag];
            }
            set 
            {
                names[flag] = value;
            }
        }

        public string this[float f]
        {
            get
            {
                return names[(int)f];
            }
            set
            {
                names[(int)f] = value;
            }
        }
    }
    class Indexers3
    {
        static void Main()
        {
            Infinite infinite = new Infinite();

            infinite[0] = "hello";
            infinite[1.0f] = "world";
            infinite[2.0f] = "of cSharp";

            Console.WriteLine(infinite[0.0f] + " " + infinite[1.0f] + " " + infinite[2.0f]);
            Console.Read();
        }
    }
}
