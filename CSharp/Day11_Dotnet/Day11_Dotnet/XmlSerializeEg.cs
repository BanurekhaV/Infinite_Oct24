using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Day11_Dotnet
{
    public class XMLSample
    {
        public string v1;
        public string v2;
    }
    class XmlSerializeEg
    {
        static void Main()
        {
            XMLSample xsample = new XMLSample() { v1 = "Value 1", v2 = "Value 2" };

            //xml serialization
            XmlSerializer x = new XmlSerializer(xsample.GetType());
            x.Serialize(Console.Out, xsample);
            Console.WriteLine("--------XML Serialization 2-------");

            Books b = new Books() { AuthorName = "Amish Tripathi", BookName = "The Immortals of Meluha", YearPublished = 2009 };
            XmlSerializer book_ser = new XmlSerializer(typeof(Books));
            book_ser.Serialize(Console.Out, b);
            
            Console.Read();
        }
    }

    public class Books
    {
        public string AuthorName;
        public string BookName;
        public int YearPublished;
    }
}
