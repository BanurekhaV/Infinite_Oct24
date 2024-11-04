using System;


namespace Day4_Dotnet
{
    class Student 
    {
        //3 private fields
        private string RollNo;
        private string Name;
        private string Class;

        //public function
        public void GetData()
        {
            Console.WriteLine("Enter Roll No :");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class :");
            Class = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Name of the Student :{0}", Name);
            Console.WriteLine("Roll No : {0}", RollNo);
            Console.WriteLine("Class of the Student : {0}", Class);
        }
    }

    class Marks : Student
    {
        protected int[] scores = new int[5];

        public void GetMarks()
        {
            for (int i = 0; i<scores.Length;i++)
            {
                Console.Write("Enter Subject {0} Marks : ", i + 1);
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Marks in Subject {0} : {1}", i+1, scores[i]);
            }
        }
    }

    class Results : Marks
    {
        int TotalMarks = 0;

        public void GetResults()
        {
            for (int i = 0; i < scores.Length; i++)
            {
                TotalMarks = TotalMarks + scores[i];
            }
        }

        public void DisplayResults()
        {
            Console.WriteLine("============Results===========");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks :{0}", TotalMarks);
        }
    }
    class InheritanceEg
    {
        static void Main(string[] args)
        {
            Results results = new Results();
            results.GetData();
            results.GetMarks();
            results.GetResults();
            results.DisplayResults();
            Console.ReadKey();
        }
    }
}
