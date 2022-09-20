using FormDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormDemo.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MyTest()
        {
            return Content("Hello World");
        }

        public IActionResult CurrentTime()
        {
            Request.ContentType = "text/html";
            DateTime now = DateTime.Now;
            return Content($"The current date and time is " + now.ToString());
        }

        public IActionResult LogIn()
        {
            return View();
        }

        public IActionResult ProcessLogIn(string username,string password)
        {
            ViewBag.UserName=username;
            ViewBag.Password=password;
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}