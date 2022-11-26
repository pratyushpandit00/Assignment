using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace studentdemo1.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Enter the Name")]
        public string EName { get; set; }


        [Range(1,100,ErrorMessage ="Enter the ID btw 1 to 100")]
        public int empID { get; set; }


        [Range(21,60,ErrorMessage ="Age must be btw 21 to 60")]
        public int Age { get; set; }

        public DateTime DOB { get; set; }


        [DataType(DataType.PostalCode)]
        public int Postal { get; set; }


        public long Mobile { get; set; }

        public string EmailID { get; set; }
        
        public string UserName { get; set; }


        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password doesn't Match")]
        public string ConfirmPassword { get; set; }


        [DataType(DataType.Url)]
        public string URL { get; set; }
    }
}