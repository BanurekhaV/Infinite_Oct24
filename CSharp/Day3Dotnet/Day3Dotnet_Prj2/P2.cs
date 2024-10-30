using System;
using Day3Dotnet;

namespace Day3Dotnet_Prj2
{
    class P2 : AccessSpecifiersEg
    {
        static void Main(string[] args)
        {
            AccessSpecifiersEg aeg1 = new AccessSpecifiersEg();
            aeg1.publicmember = 500;
            P2 p2 = new P2();
            p2.protectedmember = 900;
            p2.pimember = 60;
        }
    }
}
