using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    class SelectionControl
    {
        public void CheckGrade()
        {
            char grade;
            Console.WriteLine("Enter your Grade :");
            grade = Convert.ToChar(Console.ReadLine());
            
            if(grade=='O' || grade=='o') 
              Console.WriteLine("Outstanding");
            else if(grade=='A' || grade=='a')
                Console.WriteLine("Excellent");
            else if(grade=='B' || grade=='b')
                Console.WriteLine("Very Good");
            else if(grade=='C' || grade=='c')
                Console.WriteLine("Can improve");
            else Console.WriteLine("Invalid Grade");
            CheckGradeWithSwitch();  // calling another function of the same class in one function
        }

        public void CheckGradeWithSwitch()
        {
            char grade;
            Console.WriteLine("Enter you Grade :");
            grade = Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'O':
                case 'o':
                    Console.WriteLine("Outstanding");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Can improve");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }
    }
    class Decisionmaking
    {
        static void Main(string[] args)
        {
            SelectionControl sc = new SelectionControl();
            sc.CheckGrade();
           // sc.CheckGradeWithSwitch();
            Console.Read();
        }
    }
}
