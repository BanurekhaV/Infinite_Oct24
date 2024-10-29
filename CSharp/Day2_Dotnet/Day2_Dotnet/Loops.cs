using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    class Loops
    {
        public void WhileLoop()
        {
            int i = 1;  //1. initializing a counter
            while(i<5) // 2. checking a condition
            {
                Console.WriteLine(i);
                i++;  // 3. change of initial value
            }
        }

        public void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }

        public void ForLoop()
        {
            int total = 0;
            for(int i=0; i<=5;i++)
            {
                if (i == 3)
                    // break;
                    continue;
                total += i;
                
            }
            Console.WriteLine(total);
        }

        static void Main()
        {
            Loops loops = new Loops();
            Console.WriteLine("Do While Loop");
            loops.DoWhileLoop();
            Console.WriteLine("While Loop");
            loops.WhileLoop();
            Console.WriteLine("For Loop");
            loops.ForLoop();
            Console.Read();
        }
    }

}
