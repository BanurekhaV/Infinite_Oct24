using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Dotnet
{
    class IEnumerable_IEnumeratorEg
    {
        static void Main()
        {
            //List Initialization
            List<string> colors = new List<string>() { "Red", "Blue", "Green", "Yellow", "White" };

            // IEnumerable<string> iecolors =(IEnumerable<string>) colors; // by typecasting

            IEnumerable<string> iecolors = colors;

            foreach(string c in iecolors)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("-----------");
            //with IEnumerator
            IEnumerator<string> ienc = colors.GetEnumerator();
            while(ienc.MoveNext())
            {
                Console.WriteLine(ienc.Current);
            }
            Console.Read();
        }

    }
}
