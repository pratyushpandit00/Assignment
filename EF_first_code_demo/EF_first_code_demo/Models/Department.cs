using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_first_code_demo.Models
{
    public class Department
    {
        public int DepartmentId { get; set; } //primary key
        [Display(Name ="department name")]
        [Required(ErrorMessage ="Enter the department name")]

        public string name { get; set; }
        public string location { get; set; }
     //   public string DepartmentHead { get; set; }
    }
}