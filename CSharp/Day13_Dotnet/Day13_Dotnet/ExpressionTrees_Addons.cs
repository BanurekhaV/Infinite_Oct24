using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Dotnet
{
    class ExpressionTrees_Addons
    {
        static void Main()
        {
            Expr1();
            Expr2();
            Expr3();
            Console.Read();
        }

        static void Expr1()
        {
            Expression<Func<int>> add = () => 2 + 2;
            var expr1 = add.Compile();
            var result = expr1(); //invoke the delegate
            Console.WriteLine(result); ;
        }

        static void Expr2()
        {
            Expression<Func<int, bool>> check = num => num < 10;

            Func<int, bool> expr2 = check.Compile();

            Console.WriteLine(expr2(15));
            Console.WriteLine(expr2(5));
        }

        static void Expr3()
        {
            //expression tree
            BinaryExpression op1 = Expression.Power(Expression.Constant(2d), Expression.Constant(4d));

            //create a lmbda 
            Expression<Func<double>> lEx = Expression.Lambda<Func<double>>(op1);

            //compile the lambda
            Func<double> expr3 = lEx.Compile();

            //execute the lambda exp
            double res = expr3();
            Console.WriteLine("Number raised to the power " + res);
        }
    }
}
