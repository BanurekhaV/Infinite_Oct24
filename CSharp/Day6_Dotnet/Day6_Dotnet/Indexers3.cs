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

            Console.WriteLine("-----------More on Indexers-----------");

            FlowerVase fv = new FlowerVase();
            fv[0] = new Flower("Roses", "Red");
            fv[1] = new Flower("Violets", "Blue");
            fv[2] = new Flower("Lillies", "White");
            fv[3] = new Flower("Hibiscus", "Pink");
            fv[4] = new Flower("Marigold", "Yellow");

            for (int i = 0; i < 5; i++)
            {
                fv[i].Display();
            }

            Console.Read();
        }
    }

    class Flower
    {
        string name;
        string color;

        public Flower(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void Display()
        {
            Console.WriteLine(name + " " + " are in " + color + " color");
        }
    }

    class FlowerVase
    {
        Flower[] fobj = new Flower[5];  // composition/aggregation 

        public Flower this[int pos]
        {
            get
            {
                return fobj[pos];
            }
            set { fobj[pos] = value; }
        }

    }
}
