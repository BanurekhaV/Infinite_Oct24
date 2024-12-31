using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Html_Helpers_Prj.Models
{
    public class Student
    {
        [Display(Name="Students Roll Number :")]
        public int RollNo { get; set; }
        [Display(Name="Student Name :")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }
}