using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF_first_code_demo.Models
{
    public class DepartmentContext:DbContext
    {
        public DepartmentContext() : base("myconnection")
        {

        }

        //table need to create in DB 
        public DbSet<Department> Departments { get; set; }
    }
}