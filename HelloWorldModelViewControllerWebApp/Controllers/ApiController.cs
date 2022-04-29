using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserDaoLibrary;

namespace HelloWorldModelViewControllerWebApp.Controllers
{
    public class ApiController : Controller
    {
        public ActionResult Users(int? id)
        {
            UserDao dao = new UserDao();

            if (id == null)
            {
                List<User> users = dao.GetUsers();
                dao.Close();
                return Json(users);
            }
            else
            {
                User user = dao.GetUser(id.Value);
                dao.Close();
                return Json(user);
            }
        }

        [HttpPost]
        public ActionResult Users([FromBody]User userToAdd)
        {
            UserDao dao = new UserDao();
            User addedUser = dao.AddUser(userToAdd);
            dao.Close();
            return Json(addedUser);
        }

        [HttpDelete]
        public ActionResult Users(int id)
        {
            UserDao dao = new UserDao();
            dao.DeleteUser(id);
            dao.Close();

            return Json("");
        }

        [HttpPut]
        public ActionResult Users(int id, [FromBody] User userToUpdate)
        {
            UserDao dao = new UserDao();
            dao.UpdateUser(userToUpdate);
            dao.Close();
            return Json(userToUpdate);
        }

        
    }
}
