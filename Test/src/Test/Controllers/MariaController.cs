using System;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    public class MariaController : Controller
    {
        public IActionResult Index()
        {
            return View("Scott");
        }
    }

    public class ScottIndexViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class ScottController : Controller
    {
        public IActionResult Index()
        {
            //Get the model from DB
            var vm = new ScottIndexViewModel()
            {
                Age = 29,
                Name = "Scott"
            };

            //Do some stuff
            return View(vm);
        }
    }
}
