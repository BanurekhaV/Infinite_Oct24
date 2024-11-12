using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Day11_Dotnet
{
    [Serializable]  //allowing the class object to be serialized
    class SerializeEg1
    {
        public int ID;
        public string Name;
        [NonSerialized]
        public double Salary;

        public static void Main()
        {
            SerializeEg1 se = new SerializeEg1() { ID = 1, Name = "Infinite" , Salary = 80000};

            // IFormatter formatter = new BinaryFormatter();  or as below
            BinaryFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream(@"B_Serialize.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, se);
            stream.Close();

            //deserializing the stream info into an object
            stream = new FileStream(@"B_Serialize.txt", FileMode.Open, FileAccess.Read);

            SerializeEg1 se2 = (SerializeEg1)formatter.Deserialize(stream);
            Console.WriteLine(se2.ID + " " + se2.Name + " " + se2.Salary);
            Console.Read();
        }
    }
}
