using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModelState_Prj.Models
{
    public class User
    {
        [Required(ErrorMessage ="First Name is Required..")]
        [Display(Name="First Name")]
        [StringLength(25, ErrorMessage = "First name can be only upto 25 chrs")]
        public string Fname { get; set; }
        [DisplayName("Last Name")]
        public string Lname { get; set; }
        [Display(Name ="Age")]
        [Range(21,45,ErrorMessage ="Age has to be between 21 and 45 only")]
        public int age { get; set; }
        [Required(ErrorMessage ="Please enter email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})$",
            ErrorMessage ="Invalid Email")]
        public string email { get; set; }
    }
}