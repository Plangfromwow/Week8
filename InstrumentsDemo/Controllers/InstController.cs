using InstrumentsDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstrumentsDemo.Controllers
{
    public class InstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowForm()
        {
            return View();
        }

        public IActionResult Add(Instrument inst)
        {
            bool errorFound = false;
            //Validate Year and Price
            if (inst.year > DateTime.Now.Year)
            {
                ViewBag.YearMessage = "Please enter a year that has already occurred.";
                errorFound = true;
            }
            if (inst.price <= 0)
            {
                ViewBag.PriceMessage = "Price must be greater than 0";
                errorFound = true;
            }
            if (errorFound)
            {
                return View("ShowForm");
            }
            else
            {
                return View(inst);
            }
        }
    }
}
