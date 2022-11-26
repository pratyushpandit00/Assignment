using DemoAPI_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        List<UserModel> UserList;
        public UsersController()
        {
            UserList = new List<UserModel>()
            {
                new UserModel() { UserId = 1, UserName = "Peter", UserPassword = "TestPotter" },
                new UserModel() { UserId = 2, UserName = "Hermione", UserPassword = "Howgwarts" },
                new UserModel() { UserId = 3, UserName = "Harry", UserPassword = "Suja" }
            };
        }
        [HttpGet]
         public IEnumerable<UserModel> Get()
         {
            return UserList; ;
         }


        [HttpGet("{id}")]
        public UserModel GetUserByID(int id)
        {
            UserModel user = UserList.FirstOrDefault(u => u.UserId == id);
            return user ;
        }



        [HttpPost]
        public IEnumerable<UserModel> PostUser(UserModel model)
        {
            UserList.Add(model);
            return UserList;
        }




        [HttpPut]
        public IEnumerable<UserModel> PutUser(UserModel model)
        {
            int index = UserList.FindIndex(u => u.UserId == model.UserId);
            // UserModel newuser = UserList.FirstOrDefault(u => u.UserId == model.UserId);
            // newuser.UserName = model.UserName;
            // newuser.UserPassword = model.UserPassword;
            UserList[index] = model;
            return UserList;
        }



        [HttpDelete]
         public IEnumerable<UserModel> DeleteUser(UserModel model)
        {
            UserModel user = UserList.FirstOrDefault(u => u.UserId == model.UserId);
            UserList.Remove(user);
            return UserList;
        }
    }
}
