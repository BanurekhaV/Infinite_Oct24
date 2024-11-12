using System;
using System.Collections.Generic;
using System.IO;

namespace Day11_Dotnet
{
    class Directories_n_Files
    {
        static void Main()
        {
            DirectoryInfo dirinfo = new DirectoryInfo("SampleDirectory");
            if(dirinfo.Exists)
            {
                Console.WriteLine("Directory already exists..");
                //return;
            }
            else
            {
                dirinfo.Create();
                Console.WriteLine("Directory Created !!");
            }

            //let us get the list of sub directories from a given directory

            DirectoryInfo di = new DirectoryInfo(@"C:\Banu\Infinite_1\CSharp");

            if(di.Exists)
            {
                DirectoryInfo[] subdirs = di.GetDirectories();

                foreach(object dirnames in subdirs)
                {
                    Console.WriteLine(dirnames.ToString());
                }
            }
            else
                Console.WriteLine("The given directory does not exist");

            //getting files in the directory, their names and size
            Console.WriteLine("-------File Details-------");

            FileInfo[] myfiles = di.GetFiles();

            foreach(FileInfo f in myfiles)
            {
                Console.WriteLine("File Name :{0} File Size : {1} File Extension :{2} ", f.Name, f.Length, f.Extension);
            }
            Console.Read();
        }
    }
}
