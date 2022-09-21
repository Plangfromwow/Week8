using Microsoft.AspNetCore.Mvc;
using ModelDemo1.Models;
using System.Diagnostics;

namespace ModelDemo1.Controllers
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

        public IActionResult Register(Person per)
        {
            if (per.Born > 2004)
            {
                // let's use a different view for this one because they are young 
                return View("Under18");
            }
            else
            {
                return View(per);
            }
            
        }

        public IActionResult Sample()
        {
            Person fred = new Person() { FirstName ="Fred",LastName="Franklin",Email="Banana@yahoo.com",Born=1970};
            return View(fred);
        }

        public IActionResult SampleList()
        {
            List<Person> people = new List<Person>();

            Person fred = new Person() { FirstName = "Fred", LastName = "Franklin", Email = "Banana@yahoo.com", Born = 1970 };
            Person per = new Person() { FirstName = "Greg", LastName = "Thompson", Email = "Banana@yahoo.com", Born = 1170 };
            people.Add(per);
            people.Add(fred);
            people.Add(new Person() { FirstName="Sally",LastName="Henderson",Email="youhoo@youhoo.esg",Born=156});

            ViewData["Department"] = "IT";
            ViewData["Year"] = "IT";

            return View(people);

        }

        public IActionResult ShowRegister()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}