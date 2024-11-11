using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Dotnet
{
    class EventsEg2
    {
        int data = 5;
        //decl delegate
        public delegate void NumberManipulator(int x);

        //decl event
        event NumberManipulator ChangeNumberEvent;

        public EventsEg2(int n)
        {
            this.ChangeNumberEvent += new NumberManipulator(this.onChangeNum); // registering an event with the
                                                                              //delegate and hence function

            setValue(n);
        }

        public void onChangeNum(int x)  //event handler
        {
           // data = x;
            Console.WriteLine($"Event Raised and the value from {data} changed to {x}");
        }

        public void setValue(int n)
        {
            if(data != n)
            {
                ChangeNumberEvent(n);  //this is the place of raising an event
            }
            else
            {
                Console.WriteLine("No changes in the value... and hence no event raised and notified");
            }
        
        
        }
    }

    class TestEvent
    {
        static void Main()
        {
            EventsEg2 eobj = new EventsEg2(5);  // noevent
            eobj.setValue(10);  //event is raised
            eobj.setValue(20); // event is raised
            eobj.setValue(5); // no event
            Console.Read();
        }
    }
}
