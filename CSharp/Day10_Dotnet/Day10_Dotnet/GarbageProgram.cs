using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Dotnet
{
    class GarbageProgram
    {
        static void Main()
        {
            Console.WriteLine("The no. of generations are : "+ GC.MaxGeneration);

            GarbageProgram gp = new GarbageProgram();
            Console.WriteLine("The generation no of gp is : " + GC.GetGeneration(gp));
            Console.WriteLine("Total Memory : " + GC.GetTotalMemory(false));

            GC.Collect(0);
            Console.WriteLine("Garbage collected in Gen 0 is : " + GC.CollectionCount(0));

            Console.WriteLine("Total Memory : " + GC.GetTotalMemory(false));
            Console.Read();
        }
    }

}
