using DemoAPI_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI_1.Repository
{
    public class MockDepartmentRepo : DepartmentRepo
    {
        EmployeeDepartmentContext context = new EmployeeDepartmentContext();

        string AddNewDepartment(Department department)
        {
            string result = department.DepartmentName + "Added successfully"; 
            context.Departments.Add(department);
            context.SaveChanges();
            return result; // CSE Added successfully
        }

        string DepartmentRepo.AddNewDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        string DeleteDepartment(int id)
        {
            string result;
            Department dept = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            if (dept != null)
            {
                context.Departments.Remove(dept);
                context.SaveChanges();
                result = id + " is Deleted";
            }
            else
            {
                result = "The given Department id is not exist";
            }
            return result;
        }

        string DepartmentRepo.DeleteDepartment(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Department> DepartmentRepo.GetAllDepartments()
        {
            List<Department> departments = context.Departments.ToList();
            return departments;
        }

        Department GetDepartmentById(int id)
        {

            Department dept = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            return dept;
        }

        Department DepartmentRepo.GetDepartmentById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Department> GetDepartmentByLocation(string location)
        {
            var dept = context.Departments.Where(d => d.Location == location).ToList();
            return dept;
        }

        IEnumerable<Department> DepartmentRepo.GetDepartmentByLocation(string location)
        {
            throw new NotImplementedException();
        }

        string UpdateDepartmentDetails(Department department)
        {
            string result;
            Department dept = context.Departments.FirstOrDefault(d => d.DepartmentId == department.DepartmentId);
            if (dept != null)
            {
                dept = department;
                context.SaveChanges();
                result = department.DepartmentId + " is Updaated";
            }
            else
            {
                result = "The given Department id is not exist";
            }
            return result;
        }

        string DepartmentRepo.UpdateDepartmentDetails(Department department)
        {
            throw new NotImplementedException();
        }
    }
}

