using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SecurityDemo.Models;


namespace SecurityDemo.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User usermodel)
        {
            using (MVC_DB627Entities entities = new MVC_DB627Entities())
            {
                bool IsValidUser = entities.Users.Any(
                    db => db.UserName == usermodel.UserName   //here db => db.UserName fetching the data from database --> "Users"
                    && db.UserPassword == usermodel.UserPassword);
            
                if(IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(usermodel.UserName, false);
                    return RedirectToAction("Index", "Employees");
                }
                else
                     ModelState.AddModelError("", "Invalid User or Password");
            }
            return View();
        }
    }
}