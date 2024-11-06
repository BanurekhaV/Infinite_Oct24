using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Dotnet
{
    
    class VotingException : ApplicationException
    {
        public VotingException(string msg) : base(msg) { }
    }

    class Vote
    {
        int age;

        public void getAge()
        {
            Console.WriteLine("Enter your Age :");
            age = Convert.ToInt32(Console.ReadLine());

            if(age < 18)
            {
                throw (new VotingException("Age should be greater than 18"));
            }
            else
                Console.WriteLine("Thanks for Voting ...");
        }
    }

    class UserDefinedException
    {
        static void Main()
        {
            Vote vote = new Vote();
            try
            {
                vote.getAge();
            }

            catch(VotingException ve)
            {
                Console.WriteLine(ve.Message);
            }
            Console.Read();

        }
    }
}
