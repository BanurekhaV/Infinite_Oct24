using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Attribute_Routing.Models;

namespace Attribute_Routing.Controllers
{
    [RoutePrefix("stud")]
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>()
        {
            new Student(){Id = 1, Name = "Pranav"},
            new Student(){Id = 2 , Name = "Vibhav"},
            new Student(){Id = 3, Name = "Prabhav"},
            new Student(){Id = 4, Name = "Abhinav"},
        };

        [HttpGet]
        [Route]
        public ActionResult GetAllStudents()
        {
            return View(students);
        }

        [HttpGet]
        [Route("{studentID}")]
        public ActionResult GetStudentById(int studentID)
        {
            Student studentdetails = students.FirstOrDefault(s => s.Id == studentID);
            return View(studentdetails);
        }

        [HttpGet]
        [Route("{studentID}/courses")]
       // [Route("students/{studentID}/courses")]
        public ActionResult GetStudentCourses(int studentID)
        {
            List<string> CourseList = new List<string>();

            if (studentID == 1)
                CourseList = new List<string>() { "ASP.Net", "C#.Net", "Sql Server" };
            else if (studentID == 2)
                CourseList = new List<string>() { "ASP.Net MVC", "C#.Net", "ADO.Net" };
            else if (studentID == 3)
                CourseList = new List<string>() { "ASP.Net Web API", "C#.Net", "Entity Framework" };
            else if (studentID == 4)
                CourseList = new List<string>() { "BootStrap", "JQuery", "Angular" };

            ViewBag.CourseList = CourseList;
            return View();
        }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}