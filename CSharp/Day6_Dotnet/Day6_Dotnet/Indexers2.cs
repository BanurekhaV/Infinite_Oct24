using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Dotnet
{
    class Indexers2
    {
        //declaring an array member;
        string[] data = new string[3];

       // Defining Indexer 1
        public string this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }

        //defining overloaded indexer 2
        public string this[string s]
        {
            get
            {
                foreach (string str in data)
                {
                    if (str.ToLower() == s.ToLower())
                    {
                        return str.ToUpper();
                    }
                }
                return null;
            }
        }
    }

    class Driver
    {
        static void Main()
        {
            Indexers2 idx2 = new Indexers2();

            //accessing the int index type indexers set
            idx2[0] = "chiramya";
            idx2[1] = "durgasai";
            idx2[2] = "pavan";
            Console.WriteLine("*********Indexer with int Type*********");
            for(int i=0; i<3;i++)
            {
                Console.WriteLine(idx2[i]);
            }

            //access indexer with string type

            Console.WriteLine("******with string type********");
            Console.WriteLine(idx2["chiramya"]);
            Console.WriteLine(idx2["durgasai"]);
            Console.WriteLine(idx2["pavan"]);

            Console.Read();
        }
    }
}
