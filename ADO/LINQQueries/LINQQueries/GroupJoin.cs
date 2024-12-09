using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQueries
{
    class Person
    {
        public int PID { get; set; }
        public string PName { get; set; }
    }

    class Course
    {
        public int CID { get; set; }
        public string CName { get; set; }
    }
    class GroupJoin
    {
        static void Main()
        {
            Sample_GroupJoin();
            Console.Read();
        }

        static void Sample_GroupJoin()
        {
            Person[] p = new Person[]
            {
                new Person{PID=1, PName="Sam"},
                 new Person{PID=2, PName="Jam"},
                  new Person{PID=2, PName="Ram"},
                   new Person{PID=1, PName="Dam"},
                    new Person{PID=1, PName="Pam"},
                     new Person{PID=3, PName="Ham"},
            };

            Course[] c = new Course[]
            {
                new Course{CID=1,CName="ADO.Net"},
                  new Course{CID=2,CName="C#.Net"},
                    new Course{CID=3,CName="SQL"},
            };

            var result = c.GroupJoin(p, crs => crs.CID, pers => pers.PID, (cr, ps) => new { key = cr.CName, ps });
            Console.WriteLine("Group - Join List of persons who have taken various courses..");

            foreach(var item in result)
            {
                Console.WriteLine(item.key);

                foreach(var per in item.ps)
                {
                    Console.WriteLine(per.PID + " " + per.PName);
                }
            }
        }
    }
}
