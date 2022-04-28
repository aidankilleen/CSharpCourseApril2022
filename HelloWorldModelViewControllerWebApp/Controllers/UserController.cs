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
            return View();
        }
    }
}
