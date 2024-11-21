using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSessionmanagement
{
    public class UserSession
    {
        //static readonly that is being instantiated when th eprogram starts(eager loading)
        private static readonly UserSession session = new UserSession();

        //private constructor
        private UserSession() { }

        //public properties to represent the session details
        public string UserName { get; private set; }
        public string[] Roles { get; private set; }
       

        //public method for initializing the properties
        public void InitializeData(string uname, string[]roles)
        {
            UserName = uname;
            Roles = roles;
        }

        //method for clearing the user session
        public void Clear()
        {
            UserName = null;
            Roles = null;
        }

        //public property to access the singleton instance

        public static UserSession Instance => session;
    }
    class Sessionprogram
    {
        static void Main(string[] args)
        {
            UserSession.Instance.InitializeData("Banurekha", new[] { "User", "Admin" });

            //to access the above session data from anywhere within the application

            string currentuser = UserSession.Instance.UserName;
            Console.WriteLine("The current User is : " + currentuser);
            //to clear the session

            UserSession.Instance.Clear();
            Console.Read();

        }
    }
}
