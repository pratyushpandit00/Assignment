using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS1.Models
{
      public class Employee
        {
            
            public int EmployeeID { get; set; }
            [Required]
            [StringLength(20, MinimumLength = 5, ErrorMessage = "Name should have min-5 max-20 characters")]
            public string Name { get; set; }

            [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-za-z]+)|([A-za-z]+))$")]

            public string UserName { get; set; }

            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "Password and ConfirmPassword does not match")]
            public string ConfirmPassword { get; set; }
        }
   
}