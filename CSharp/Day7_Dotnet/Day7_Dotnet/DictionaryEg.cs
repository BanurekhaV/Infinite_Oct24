using System;
using System.Collections.Generic;


namespace Day7_Dotnet
{
    class DictionaryEg
    {
        public static void Main()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Red");
            dict.Add(3, "Green");
            dict.Add(2, "Blue");
            dict.Add(5, "Yellow");


            foreach(int item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
            foreach(string item in dict.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----keys and values------");

            //need to iterate with a variable of type keyvaluepair
            foreach(KeyValuePair<int,string> kvp in dict)
            {
                Console.Write(kvp.Key + " ");
                Console.Write(kvp.Value);
                Console.WriteLine();
            }

            Console.WriteLine("Enter the Id to get the color:");
            int c = Convert.ToInt32(Console.ReadLine());
            if(dict.ContainsKey(c))
            {
                Console.Write(c + " represents " + dict[c]);
            }
            else Console.WriteLine("Enter a valid Id");

            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("Sql", "Query Lang");
            sl.Add("C#", "CSharp");
            sl.Add("Vb", "Visual Basic");
            sl.Add("Html", "Webdesign");
            Console.WriteLine();
            foreach(string s in sl.Values)
            {
                Console.WriteLine(s);
            }
            
            Console.WriteLine("-----------");
            foreach(KeyValuePair<string,string> k in sl)
            {
                Console.Write(k.Key + " ");
                Console.Write(k.Value);
                Console.WriteLine();
            }
            Console.Read();
        }

    }
}
