using System;
using System.Collections;


namespace Day7_Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayListEg();
            // HashTableEg();
            // StacksEg();
            GenericsEg.ListEg();
            Console.ReadLine();
        }

        static void ArrayListEg()
        {
            ArrayList alist = new ArrayList();
            alist.Add(10);
            alist.Add("AAA");
            alist.Add(456.765f);
            alist.Add(true);

            alist.Add(110);
            alist.Add("XXA");
            alist.Add(5678.4567);
            alist.Add(false);
            alist.Add("7/11/2024");

            foreach (var x in alist)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Count : " + alist.Count);
            Console.WriteLine("Capacity :" + alist.Capacity);


            //to remove an element
            alist.Remove("AAA");
            alist.RemoveAt(3);
            Console.WriteLine("-----Collection after manipulation-----");
            foreach (var x in alist)
            {
                Console.WriteLine(x);
            }

            //to insert an element or range of elements
            ArrayList alist2 = new ArrayList();
            alist2.Add(6);
            alist2.Add(1);
            alist2.Add(11);
            alist2.Add(4);
            alist2.Add(2);

            alist.InsertRange(2, alist2);
            Console.WriteLine("After Inserting another collection");
            foreach (var x in alist)
            {
                Console.WriteLine(x);
            }

            alist2.Sort();

            foreach (int x in alist2)
            {
                Console.WriteLine(x);
            }
        }

        static void HashTableEg()
        {
            Hashtable ht = new Hashtable();

            ht.Add("E001", "BhanuPrakash");
            ht.Add("E007", "BhanuPrakash");
            ht.Add("E010", null);
            ht.Add("E006", "Gowthami");
            ht.Add("E002", "Hareesh");
            ht.Add(1, "Ramya");
            ht.Add("E013", 100);
            ht.Add("E023", 100);
            ht.Add("E0100", 100);
            ht.Add("E999", 100);

            Console.WriteLine("---with keys------");
            foreach(var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------with values-----------------");
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----- both key and value-----");

            //dictionary entry structure to be used
            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key + " ");
                Console.Write(de.Value);
                Console.WriteLine();
            }

            //to search the Hash table with huge records

            Console.WriteLine("Enter a key to search");
            string empid = Console.ReadLine();

            if(ht.ContainsKey(empid))
            {
                Console.WriteLine(empid + "=" + ht[empid]);
            }
            else
                Console.WriteLine(empid + " " + "does not exists");
        }

        static void StacksEg()
        {
            Stack st = new Stack();
            st.Push(4);
            st.Push('a');
            st.Push("abc");
            st.Push(10);

            foreach(object o in st)
            {
                Console.WriteLine(o);
            }

            st.Pop();
            Console.WriteLine(st.Peek());

            foreach (object o in st)
            {
                Console.WriteLine(o);
            }

        }
    }
}
