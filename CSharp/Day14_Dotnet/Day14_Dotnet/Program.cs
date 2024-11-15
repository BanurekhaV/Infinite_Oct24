using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day14_Dotnet
{
    class Accounts
    {
        public double Balance;

        public Accounts(double b)
        {
            Balance = b;
        }

        public void Credit(double amt)
        {
            Balance += amt;
        }

        public void Debit(double amt)
        {
            Balance -= amt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Accounts(1000);

            var tasks = new Task[20];

            for(int i = 0; i < tasks.Length; i++ )
            {
                tasks[i] = Task.Run(() => RandomlyUpdate(account));
            }
            Task.WaitAll(tasks);
            Console.WriteLine("All Tasks Done..");
            Console.WriteLine("Balance at the end is " + account.Balance);
            Console.Read();
        }

        static void RandomlyUpdate(Accounts acc)
        {
            var rand = new Random();

            for(int i=0; i<10;i++)
            {
                var amount = rand.Next(1, 100); // thru random number, we are arriving at an amount between 1 and 100

                //now to arrive at which function call has to be made, let us use random clas

                bool b = rand.NextDouble() <= 0.5;
                if(b)
                {
                    acc.Credit(amount);
                }
                else
                {
                    acc.Debit(amount);
                }
            }
        }
    }
}
