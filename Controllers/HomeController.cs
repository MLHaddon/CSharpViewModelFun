using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun2.Models;

namespace ViewModelFun2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string message = "This is a messageThis is a messageThis is a messageThis is a messageThis is a messageThis is a message";
            return View("Index", message);
        }

        public IActionResult Numbers()
        {
            int[] numbers = new int[] {1,2,3,4,5,6,7,8,9,10};
            return View("Numbers", numbers);
        }

        public IActionResult Users()
        {
            List<User> users = new List<User>(5);
            User user = new User()
            {
                first_name = "Michael",
                last_name = "Haddon"
            };
            users.Add(user);
            return View("Users", users);
        }

        public IActionResult UserPage()
        {
            User user = new User()
            {
                first_name = "Michael",
                last_name = "Haddon"
            };
            return View("UserPage", user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
