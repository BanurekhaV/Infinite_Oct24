using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CustomModel_Validations.CustomValidations;


namespace CustomModel_Validations.Models
{
    public class JobApplication
    {
        [Required]
        [Display(Name = "Applicant Name")]
        public string name { get; set; }

        [Display(Name = "Years of Experience")]
        [Range(3, 10, ErrorMessage = "Experience must be between 3 and 10 yrs")]
        public int experience { get; set; }

        [Display(Name = "DOB")]
        [DataType(DataType.Date)]
        [ValidBirthDate(ErrorMessage ="DOB should be between 01/01/1995 and 31/01/2003 only")]
        public DateTime birthdate { get; set; }

        [Required]
        [Display(Name = "Email ID")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9])+\.)+([a-zA-Z0-9]{2,4})$", ErrorMessage =
            "Invalid EMail ID")]
        public string email { get; set; }

        [GenderValidate(ErrorMessage ="Please Select your correct Gender")]
        public string Gender { get; set; }

        [Display(Name = "Expected Salary")]
        [RegularExpression(@"^(0(?!\.00)|[1-9]\d{0,6})\.\d{2}$", ErrorMessage =
            "Salary Should be Like 6000.45")]
        public decimal expsal { get; set; }

        [SkillValidation(ErrorMessage ="Select atleast 3 Skills")]
        public List<CheckBox> Skills { get; set; }
        public string HavePassport { get; set; }
    }
}