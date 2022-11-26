using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI_1.Models
{
    public class EmployeeDepartmentContext : DbContext
    {
        public EmployeeDepartmentContext()
        {

        }
        public EmployeeDepartmentContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
