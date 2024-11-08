using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Dotnet
{
    class GenericIndexers<T>
    {
        T[] data = new T[3];
        T var;
        
        public string Name { get; set; } // non generic memeber

        public T Var
        {
            get { return var; }
            set { var = value; }
        }
        //generic indexer 1. for the array field

        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        //2.

        public T this[float index]
        {
            get { return data[(int)index]; }
            set { data[(int)index] = value; }
        }

        //3.  optional
        public T this[string index]
        {
            get { return data[1]; }
            set { data[1] = value; }
        }

    }

    class Tester
    {
        static void Main()
        {
            GenericIndexers<float> gfloat = new GenericIndexers<float>();
            gfloat[0] = 5.5f;
            gfloat[1.0f] = 10.5f;
            gfloat[2] = 15.5f;

            gfloat.Var = 1.5f;
            gfloat.Name = "I am not a Generic member";

            for(int i=0; i<3; i++)
            {
                Console.WriteLine("At Pos {0}, the value is : {1}", i, gfloat[i]);
            }
            Console.Read();
        }
    }
}
