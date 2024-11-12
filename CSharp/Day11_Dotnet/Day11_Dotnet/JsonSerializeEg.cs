using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Dotnet
{
    public class Customer
    {        
        public string CustId;
        public string Name;
        public string City;

        public string ToJSon()
        {
            //Make a stream to serialize info.
            using(MemoryStream stream = new MemoryStream())
            {
                //Serialize into a stream
                DataContractJsonSerializer jser = new DataContractJsonSerializer(typeof(Customer));
                jser.WriteObject(stream, this);

                stream.Flush();

                //Get the result as Text
                stream.Seek(0, SeekOrigin.Begin);
                using(StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public static Customer FromJSon(string jsonstring)
        {
            //make a stream to read from
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(jsonstring);
            writer.Flush();
            stream.Position = 0;

            //deserialize
            DataContractJsonSerializer jdser = new DataContractJsonSerializer(typeof(Customer));
            Customer cust = (Customer)jdser.ReadObject(stream);
            return cust;
        }

    }
    class JsonSerializeEg
    {
        static void Main()
        {
            Customer c = new Customer()
            {
                CustId = "C001",
                Name = "Robert",
                City = "Las Vegas"
            };

            //display the serialization
            string serializeddata = c.ToJSon();
            Console.WriteLine(serializeddata);

            //deserialize
            Console.WriteLine("----------------");
            Customer new_Cust = Customer.FromJSon(serializeddata);
            Console.WriteLine(new_Cust.City +  " "+ new_Cust.CustId + " " + new_Cust.Name);
            Console.Read();
        }
    }
}
