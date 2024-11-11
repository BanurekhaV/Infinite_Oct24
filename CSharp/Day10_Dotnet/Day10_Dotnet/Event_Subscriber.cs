using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Dotnet
{
    public delegate string DelegateForEvent(string str);

    class EventsEg    // publisher class
    {
        //declare an event
        event DelegateForEvent ourEvent; //declaring an event associated with a  particular delegate
       event DelegateForEvent secondEvent; //multiple events associated with the same delegate

        //constructor

        public EventsEg()
        {
            this.ourEvent += new DelegateForEvent(this.WelcometheUser);
            this.secondEvent += new DelegateForEvent(this.SomeOtherFunction);
            this.secondEvent += new DelegateForEvent(Event_Subscriber.HandlerFunction);
        }

        public string WelcometheUser(string uname)
        {
            return "Welcome User : " + uname;
        }

        public string SomeOtherFunction(string s)
        {
            Console.WriteLine(s + " " + "Hope you are all enjoying the session ?.");
            return s + " " + "Hope you are all enjoying the session ?.";
        }

        static void Main(string[] args)
        {
            EventsEg eventobj = new EventsEg();
            //1. calling the function with the help of the class object

            string res = eventobj.WelcometheUser("Banurekha");
            Console.WriteLine(res);

            //2. calling the class function thru delegate object
            DelegateForEvent dfe = eventobj.WelcometheUser;

            res = dfe("Prakruthi");
            Console.WriteLine(res);

            //3. caaling the function thru event

            res = eventobj.ourEvent("Infinite Associates..");  // raising an evenet
            Console.WriteLine(res);

            string secondresult = eventobj.secondEvent("Infinite Accociates.");
            Console.WriteLine(secondresult);
            
            Console.Read();
        }
    }

    class Event_Subscriber
    {
        public static string HandlerFunction(string s)
        {
            return " This was the data in the Argument " + s;
        }
    }
}
