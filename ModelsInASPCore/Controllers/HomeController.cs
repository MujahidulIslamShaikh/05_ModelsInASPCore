using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelsInASPCore.Models;
using ModelsInASPCore.Repository;

namespace ModelsInASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;  // reference variable
        private readonly StudentRespository _studentRespository = null; // reference variable

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRespository = new StudentRespository(); // contructor me obj bana ke use karenge
        }
        //public List<StudentModel> getAllStud()
        //{
        //    return _studentRespository.getAllStudents();
        //}
        public IActionResult getAllStudents()
        {
           List<StudentModel> students = _studentRespository.getAllStudents();
            ViewData["all_stud_data"] = students;
            return View();
        }
        public StudentModel getById(int id)
        {
            return _studentRespository.getStudenetById(id);
        }

        public IActionResult Index()
        {
            //var students = new List<StudentModel>
            //{
            //    new StudentModel { rollNo=1,Name="Mujahid",Gender="male",Standard=12},
            //    new StudentModel { rollNo=2,Name="Adil",Gender="male",Standard=10},
            //    new StudentModel { rollNo=3,Name="Defghi",Gender="femail",Standard=11}
            //};
            //ViewData["stud_data"] = students;
            return View();
        }

        public IActionResult CustFormPage()
        {
            var CustInfo = new List<CustomerInfoModel>
            {
                new CustomerInfoModel { custId=1001,custName="AfzalBhai",custCity="Malegaon",custContNum=1234567890},
                new CustomerInfoModel { custId=1002,custName="ArifBhai",custCity="Nangaon",custContNum=1234567810},
                new CustomerInfoModel { custId=1003,custName="IrfanBhai",custCity="Dhulia",custContNum=1234567820},
            };
            ViewData["cust_info"] = CustInfo;
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
