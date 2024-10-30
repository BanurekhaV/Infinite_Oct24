using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Dotnet_Prj2
{
    class OverloadEg
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public float add(float x, int y)
        {
            return x + y;
        }

        public int add(int x, int y, int z)
        {
            return x + y;
        }
    }
}
