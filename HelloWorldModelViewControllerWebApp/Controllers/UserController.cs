using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserDaoLibrary;

namespace HelloWorldModelViewControllerWebApp.Controllers
{
    public class UserController : Controller
    {
        UserDao dao = new UserDao();

        public IActionResult Index()
        {
            ViewBag.Title = "List of Users";
            ViewBag.Users = dao.GetUsers();
            dao.Close();
            return View();
        }

        public IActionResult Detail(int id)
        {
            ViewBag.Id = id;

            User user = dao.GetUser(id);
            dao.Close();
            ViewBag.User = user;
            return View();
        }

        public IActionResult ConfirmDelete(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult Delete(int id)
        {
            dao.DeleteUser(id);
            dao.Close();

            return Redirect("/User/Index");
        }

        public IActionResult Edit(int id)
        {
            User userToEdit = dao.GetUser(id);
            dao.Close();
            ViewBag.Title = "Edit User";
            ViewBag.User = userToEdit;
            ViewBag.Action = "/User/Edit";

            return View("UserForm", userToEdit);
        }
        [HttpPost]
        public IActionResult Edit(User editedUser)
        {
            dao.UpdateUser(editedUser);
            dao.Close();
            return Redirect("/User/Index");
        }
        public IActionResult Add()
        {
            ViewBag.Title = "Add User";
            ViewBag.User = new User { Id = 0, Name="", Email="", Active=false };
            ViewBag.Action = "/User/Add";
            return View("UserForm");
        }
        [HttpPost]
        public IActionResult Add(User newUser)
        {
            dao.AddUser(newUser);
            dao.Close();
            return Redirect("/User/Index");

        }

    }
}
