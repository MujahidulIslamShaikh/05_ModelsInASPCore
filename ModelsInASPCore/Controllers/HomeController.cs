using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelsInASPCore.Models;

namespace ModelsInASPCore.Controllers
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
            var students = new List<StudentModel>
            {
                new StudentModel { rollNo=1,Name="Mujahid",Gender="male",Standard=12},
                new StudentModel { rollNo=2,Name="Adil",Gender="male",Standard=10},
                new StudentModel { rollNo=3,Name="Defghi",Gender="femail",Standard=11}
            };
            ViewData["stud_data"] = students;
            return View();
        }

        public IActionResult Privacy()
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
