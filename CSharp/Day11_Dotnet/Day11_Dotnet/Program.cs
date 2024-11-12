using System;
using System.Collections.Generic;
using System.IO;

namespace Day11_Dotnet
{
    class Program
    {
        //Binary Reader and Writer class example
        static void Main(string[] args)
        {
            // WriteBinary();
            // ReadBinary();
            StreamReaderWriter srw = new StreamReaderWriter();
            srw.WriteData();
            srw.ReadData();
            Console.ReadKey();
        }

        static void WriteBinary()
        {
            using(BinaryWriter writer = new BinaryWriter(File.Open("C:\\Banu\\Infinite_1\\binaryfile.bin", FileMode.Create)))
            {
                writer.Write("0x80243456df");
                writer.Write("Some Data");
                writer.Write(true);
            }
        }

        static void ReadBinary()
        {
            using(BinaryReader reader=new BinaryReader(File.Open("C:\\Banu\\Infinite_1\\binaryfile.bin",FileMode.Open)))
            {
                Console.WriteLine("Data 1 : " + reader.ReadString());
                Console.WriteLine("Data 2 : " + reader.ReadString());
                Console.WriteLine("Data 3 : " + reader.ReadBoolean());
            }
        }
    }

    class StreamReaderWriter
    {
        public void WriteData()
        {
            FileStream fs = new FileStream("MyFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            //prompt the user to input data
            Console.WriteLine("Enter a String :");
            string str = Console.ReadLine();

            sw.Write(str);

            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public void ReadData()
        {
            FileStream fs = new FileStream("MyFile.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);
            //position the file pointer either at the beginning or at the end

            sr.BaseStream.Seek(10, SeekOrigin.Begin);

            //Read till the end of file is encountered
            string str2 = sr.ReadLine();
            
            while(str2 !=null)
            {
                Console.WriteLine("{0} ", str2);
                str2 = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
        }
    }
}
