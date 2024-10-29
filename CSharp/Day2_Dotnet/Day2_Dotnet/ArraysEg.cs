using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    class ArraysEg
    {
        public static void SingleDimension()
        {
            int[] data = new int[] { 42, 6, 8, 35, 3 };

            Console.WriteLine(data.Length + " " + data.Rank);
            Console.WriteLine("----------Before Sort---------");
            foreach (int x in data)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------After Sort----------");
            Array.Sort(data);
            //Array.Reverse(data);
            for(int i=0; i<data.Length;i++)
            {
                Console.WriteLine(data[i]);
            }
        }

        public void TwoDimension()
        {
            int[,] myarray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(myarray[1,1]); // prints 5

           // myarray[0, 0] = 1;
           // myarray[0, 1] = 2;
           //we can use loops for assigning and retrieving values from an array

            //1 st loop to iterate the rows

            //basic way of looping a 2 dimensional array
           // for(int i = 0; i < 2; i++)
           for(int i=0; i<myarray.GetLength(0);i++)
            {
                //loop 2 for column iteration within a row
               // for(int j=0; j < 3; j++)  // or as below
               for(int j=0; j<myarray.GetLength(1);j++)
                {
                    Console.Write(myarray[i,j] + " ");                    
                }
                Console.WriteLine();
            }
        }

        public void JaggedArray()
        {
            //1. declare jagged array of 2 rows
            int[][] myjagg = new int[2][];  //first square bracket refers to the rows,
                                            //and the second refers to the columns of the row

            //let us now set the size for each row
            myjagg[0] = new int[3];  //size for the first row
            myjagg[1] = new int[2];  //size for the second row

            //let us initialize the jagged array
            myjagg[0][0] = 2;
            myjagg[0][1] = 4;
            myjagg[0][2] = 6;

            myjagg[1][0] = 1;
            myjagg[1][1] = 3;

            //another way of initializing jagged array
            int[][] jagg2 =
            {
                new int[]{5,10,15,20},
                new int[]{25,30},
                new int[]{35,40,45}
            };

            //to display/print the elements of the jagged array

            for(int i=0; i<jagg2.Length;i++)
            {
                Console.WriteLine("Number of Elements at Row : " + i + " is " + jagg2[i].Length);

                //inner loop
                for(int j=0; j<jagg2[i].Length;j++)
                {
                    Console.Write(jagg2[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
        
    }

    class TestArrays
    {
        public static void Main()
        {
            // ArraysEg.SingleDimension();  //calling static function with the classname
            ArraysEg aeg = new ArraysEg();
            aeg.TwoDimension(); // calling instance function using an object of the class
            Console.WriteLine("-------------------");
            aeg.JaggedArray();
            Console.Read();
        }
    }
}
