using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_first_code_demo.Models;


namespace EF_first_code_demo.Controllers
{
    public class DepartmentsController : Controller
    {
        DepartmentContext context;
        public DepartmentsController()
        {
        context = new DepartmentContext();
        }
        // GET: Departments
        public ActionResult Index()
        {        
            return View(context.Departments.ToList());
        }

        // GET: Departments/Details/5
        public ActionResult Details(int id)
        {
            var department = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            return View(department);
        }
        

        // GET: Departments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departments/Create
        [HttpPost]
        public ActionResult Create(Department department)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    context.Departments.Add(department);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departments/Edit/5
        public ActionResult Edit(int id)
        {
            var department = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            return View(department);
        }

        // POST: Departments/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Department dept)
        {
            try
            {
                // TODO: Add update logic here
                var dept1 = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
                dept1.DepartmentId = dept.DepartmentId;
                dept1.name = dept.name;
                dept1.location = dept.location;
       //chechking      // context.Entry(dept).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departments/Delete/5
        public ActionResult Delete(int id)
        {
            Department dept = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            return View(dept);

        }

        // POST: Departments/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,Department dept)
        {
            try
            {
                Department dept1 = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
                context.Departments.Remove(dept1);
                context.SaveChanges();
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
