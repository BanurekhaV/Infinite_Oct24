using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Dotnet
{
    class GenericClass<T>
    {
        //generic data member/field
        T data;

        //generic property
        public T DataValue
        {
            get { return this.data; }
            set { data = value; }
        }

        //generic method
        public void Display<T>(string msg, T value)
        {
            Console.WriteLine("{0} : {1}", msg, value);             
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating with a string type
            GenericClass<string> gcs = new GenericClass<string>();
            gcs.DataValue = "Hello Generics";
            Console.WriteLine(gcs.DataValue);
            gcs.Display<double>("i am", 100.56);

            //instantiate with int type
            GenericClass<int> gci = new GenericClass<int>();
            gci.DataValue = 25;
            Console.WriteLine(gci.DataValue);
            Console.Read();
        }
    }
}
