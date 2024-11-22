using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace MSTest
{
    [TestClass]
    public class Test_UsingMStest
    {
        [TestMethod]
        public void Method1()
        {
            Trace.WriteLine("Test Method 1");
        }

        [TestMethod]
        public void Method2()
        {
            Debug.WriteLine("Test Method 2");
        }

        [TestInitialize]
        public void BeforeAllTests()
        {
            Trace.WriteLine("Called before all Test Methods");
        }
        [TestCleanup]
        public void AfterAllTests()
        {
            Trace.WriteLine("Called After all test Methods");
        }
        [ClassInitialize]
        public static void ClassInitializeMethod(TestContext tc)
        {
            Debug.Print("Called once for the entire class");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Trace.WriteLine("Called after class is Unloaded..");
        }

        [AssemblyInitialize]
        public static void AssemblyStart(TestContext tc)
        {
            Trace.WriteLine("For the entire assembly..");
        }

        [AssemblyCleanup]
        public static void AssemblyEnd()
        {
            Trace.WriteLine("Assembly Clean Up");            
        }
    }
}
