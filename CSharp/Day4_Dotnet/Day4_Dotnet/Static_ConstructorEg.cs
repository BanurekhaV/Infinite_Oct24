using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class Accounts
    {
        public int Id;
        public string Name;
        public static float rateofinterest;
        public static string typeofaccount = "Savings";

        public Accounts(int id, string name)
        {
            Id = id;
            Name = name;            
        }

        //static constructor
       static Accounts()
       {
           rateofinterest = 8.1f;  
           
       }

        public void Show()
        {
            Console.WriteLine(Id + " " + Name + " " + rateofinterest + " " + typeofaccount);
        }
    }
    class Static_ConstructorEg
    {
        public static void Main()
        {
            Accounts a1 = new Accounts(101, "Tarun");
            Accounts a2 = new Accounts(201, "Poormitha");

            a1.Show();
            a2.Show();
            Console.Read();
        }
    }
}
