using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Dotnet
{
    class LangEnhancements1
    {
        static void Main()
        {
            //before C# 6.0
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"Bob","E001" },
                {"Bill","E004" },
                {"John","E002" },
            };

            //with C# 6.0
            Dictionary<string, string> dict1 = new Dictionary<string, string>()
            {
                ["Bob"] = "E001",
                ["Bill"] = "E004",
                ["John"] = "E002"
            };

            //Literal movement
            var lit1 = 345_6789_0876_5213_456;  //digit seperator
            var lit2 = 1100_0001_1100_0110_1011; //Binary literal
            Console.WriteLine($"lit1 {lit1} , Lit2 {lit2}");
            Console.Read();
        }
    }
}
