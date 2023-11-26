using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using NewTelerick.Models;

namespace NewTelerick.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }


        public IActionResult Form()
        {
            return View(new UserViewModel()
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@email.com",
                UserName = "johny",
                Password = "123456",
                Company = "The Boring Company",
                Agree = false
            });
        }

        public IActionResult Grid()
        {
            return View();
        }

        public IActionResult Chart()
        {
            return View();
        }
    }
}
