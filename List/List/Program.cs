using System;
using System.Collections.Generic;

namespace ListDemo

{

    class Employee

    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Designation { get; set; }

        public long salary { get; set; }

        public string Location { get; set; }

    }



    class Program

    {

        static void Main(string[] args)

        {

            List<Employee> employees = new List<Employee>()

            {

                new Employee{Id=1, Name="Nishath",Gender="Male", Designation="Associate Developer",Location="MP",salary=9000 },

                new Employee { Id = 1, Name = "Pratheek Sai", Gender = "Male", Designation = "Associate Developer", Location = "MP", salary = 10000 },

              new Employee { Id = 1, Name = "SriLekha", Gender = "Female", Designation = "Associate Trainee", Location = "MH", salary = 11000 },

               new Employee { Id = 1, Name = "Shivani", Gender = "Female", Designation = "Associate Trainee", Location = "MH", salary = 9000 }

            };



            List<Employee> femalEmployees = employees.FindAll(emp => emp.Gender == "Female");

            foreach (var item in femalEmployees)

            {

                Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Gender} \t {item.salary} \t {item.Designation}");

            }



        }

    }

}