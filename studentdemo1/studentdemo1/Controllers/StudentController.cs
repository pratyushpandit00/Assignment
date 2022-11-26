using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using studentdemo1.Controllers;
using studentdemo1.Models;

namespace studentdemo1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult StudentDetails()
        {
            return View();

        }

        [HttpPost]
        public ActionResult StudentDetails(studentmodule student)
        {   
            if(string.IsNullOrEmpty(student.Name))
            {
                ModelState.AddModelError("Name", "Please Enter the Name");
            }
            if(student.Age<0 || student.Age>60)
            {
                ModelState.AddModelError("Age", "Please Enter the Age");
            }


            if(ModelState.IsValid)
            {
                ViewBag.Name = student.Name;
                ViewBag.Age = student.Age;
            }
            else
            {
                ViewBag.Name = "No data";
                ViewBag.Age = "No data";
            }

            return View();

        }
    }
}