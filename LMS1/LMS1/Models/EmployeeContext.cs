using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LMS1.Models
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext() : base("myconnection")
        {

        }
        //create table in db
        public DbSet<Employee> Employees { get; set; }
    }

}