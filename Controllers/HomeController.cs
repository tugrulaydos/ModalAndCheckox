using Microsoft.AspNetCore.Mvc;
using ModalAndCheckox.Helper;
using ModalAndCheckox.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ModalAndCheckox.Controllers
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
            List<Employer> employers = DataProvider.GetAllEmployer();

            return View();
        }

        public IActionResult Privacy()
        {
            List<Employer> employers = DataProvider.GetAllEmployer();

            return View(employers);
        }

        public IActionResult StudentInfo()
        {
            //Burada Ajax kullanacağız.
            return View();

        }

        [HttpPost]
        public JsonResult StudentAjax(AjaxModel ajaxModel)
        {
            List<Student> Students = new List<Student>
            {
                new Student{Id=1,Name="John",Surname="Doe",Age=22,City="London",StudentNumber=1171},
                new Student{Id=2,Name="Nancy",Surname="Davalio",Age=20,City="Paris",StudentNumber=1053},
                new Student{Id=3,Name="David",Surname="Davis",Age=21,City="Ankara",StudentNumber=1253},
                new Student{Id=4,Name="Frank",Surname="Sinatra",Age=18,City="Amsterdam",StudentNumber=53},
                new Student{Id=5,Name="Elton",Surname="John",Age=23,City="Stockholm",StudentNumber=535},
            };

            Student std = Students.Where(x => x.Id == ajaxModel.ID).First();

            return Json(std);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}