using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Dotnet
{
    class MyAllGenericClass<T>    //where T:struct  or class
    {
        private T genericMember;  //generic field

        //generic property
        public T genericProperty { get; set; }

        //generic constructor
        public MyAllGenericClass(T val)
        {
            genericMember = val;
        }

        //generic method
        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter Type : {0} and the Value : {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return Type : {0} and the Value :{1}", typeof(T).ToString(),genericMember);
            return genericMember;
        }
    }
    class AllGenerics
    {
        static void Main()
        {
            MyAllGenericClass<int> intagc = new MyAllGenericClass<int>(10);

            Console.WriteLine(intagc.genericMethod(100));

            Console.WriteLine("+++++++++++++++");
            MyAllGenericClass<string> stragc = new MyAllGenericClass<string>("Class on Generics");

            Console.WriteLine(stragc.genericMethod("You like it??"));
            Console.Read();


        }
       
    }
}
