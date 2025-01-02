﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace AjaxPost_Prj.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string StudentAddress { get; set; }
    }
}