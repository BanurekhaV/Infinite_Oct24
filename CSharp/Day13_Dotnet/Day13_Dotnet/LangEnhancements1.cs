using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Dotnet
{
    class LangEnhancements1
    {
        public string Name { get; set; }
        public string ID { get; } = "C001";
        public double Salary { get; private set; } // only the class where it is declared canset values 
        public string Dept { get; protected set; } //only related classes can set
        //or
        public LangEnhancements1()
        {
            ID = "C004";
        }
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

            LangEnhancements1 le = new LangEnhancements1();
            le.ExpressionCreationFunction();
            Console.Read();          
        
        }

        public void ExpressionCreationFunction()
        {
            ParameterExpression x = Expression.Parameter(typeof(int), "x");
            ParameterExpression y = Expression.Parameter(typeof(int), "y");
            
            BinaryExpression sum = Expression.Add(x, y);
            Expression<Func<int, int, int>> expression = Expression.Lambda<Func<int, int, int>>(sum, new ParameterExpression[] { x, y });

            Expression<Func<int, int, int>> expr = (a, b) => a + b;
            Func<int, int, int> myfunc = expr.Compile(); //create a delegate object

            int answer = myfunc(50, 6);
            Console.WriteLine("the sum is " + answer);            
        }
    }

    
}
