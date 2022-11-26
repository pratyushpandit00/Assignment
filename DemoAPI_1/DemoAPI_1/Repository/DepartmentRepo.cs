using DemoAPI_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI_1.Repository
{
    public interface DepartmentRepo
    {
        public IEnumerable<Department> GetAllDepartments();
        public Department GetDepartmentById(int id);
        public IEnumerable<Department> GetDepartmentByLocation(string location);
        public string AddNewDepartment(Department department);
        public string UpdateDepartmentDetails(Department department);
        public string DeleteDepartment(int id);

    }
}
