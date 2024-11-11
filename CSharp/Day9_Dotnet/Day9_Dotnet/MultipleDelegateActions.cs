using System;
using System.Collections.Generic;
using System.IO;

namespace Day9_Dotnet
{
    public delegate void PrintData(string s);
    class MultipleDelegateActions
    {
        static FileStream fs;
        static StreamWriter sw; //like a pen to write to a stream    

        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The string is {0}", str);
        }
               
        public static void WriteToFile(string s)
        {
            fs = new FileStream("DelFile.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);

            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void SendString(PrintData pd)
        {
            pd("We are trying to Learn Delegates of C#...");
        }
    }

    class TestDelegate
    {
        static void Main()
        {
            PrintData pd1 = new PrintData(MultipleDelegateActions.WriteToScreen);
            PrintData pd2 = new PrintData(MultipleDelegateActions.WriteToFile);

            MultipleDelegateActions.SendString(pd1);
            MultipleDelegateActions.SendString(pd2);
            Console.Read();
        }
    }
}
