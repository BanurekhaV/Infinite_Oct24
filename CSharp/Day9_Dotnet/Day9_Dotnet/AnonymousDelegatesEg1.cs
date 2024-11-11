using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Dotnet
{
    delegate void Print(int v);
    class AnonymousDelegatesEg1
    {
        static void Main()
        {
            int i = 100;
            Print p = delegate (int x)  //delegate object making a call to an anonymous function
            {
                x += i;
                Console.WriteLine("We are inside Anonylous Method {0}", x);
            };

            p(10);

            Console.WriteLine("Try again....");
            p(20);

            Console.WriteLine("-----Example 2 inbuilt Predicate Delegate ------");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evennos = Array.FindAll(numbers, delegate (int num)
             {
                 return num % 2 == 0;
             });

            Console.WriteLine("----Even Nos collection------");
            
            foreach(int item in evennos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("User Defined Predicate Delegate");

            Predicate<string> chkupper = delegate (string s)
             {
                 return s.Equals(s.ToUpper());
             };

            bool res = chkupper("hello world");

            Console.WriteLine(res);
            Console.WriteLine(chkupper("HELLO WORLD"));

            Console.WriteLine("----Predicate delegate with Lambda expr -------");

            Predicate<string> isupper = s => s.Equals(s.ToUpper());

            Console.WriteLine(isupper("Hello World")); 
            Console.WriteLine("------Function Delegate------");

            Func<int> getRnumber = delegate ()
             {
                 Random r = new Random();
                 return r.Next(1, 100);
             };

            int rand = getRnumber();
            Console.WriteLine(rand);

            Console.WriteLine("--------Func delegate with lambda expression------");
            Func<int> getRandomNo = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNo()); 
            Console.WriteLine("--------Action Delegate-------");

            Action<int> actionDel = delegate (int n)
             {
                 Console.WriteLine("The passed values = {0}", n);
             };

            actionDel(100);
            Console.WriteLine("--------Action Delegate with Lambda -------");
            Action<string> adel = n => Console.WriteLine("The passed values = {0}", n);
            adel.Invoke("Hello Action D");

            Console.Read();
        }
    }
}
