using Microsoft.AspNetCore.Mvc;
using ModalAndCheckox.Helper;
using ModalAndCheckox.Models;
using ModalAndCheckox.Views.ViewModals;
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
            
          

            return View();
        }

        [HttpPost]
        public IActionResult Index([FromBody]UserAjaxModel userdata)
        {
            return null;

        }

        [HttpGet]
        public IActionResult StudentTeachers() 
        {
            var VM = new StudentTeacherVM();

            VM.students = DataProvider.GetAllStudents();
            VM.teachers = DataProvider.GetAllTeahers();

            return View(VM);

        }

        [HttpPost]
        public IActionResult StudentTeachers([FromBody]StudentTeacherAjaxModel model)
        {
            var students = DataProvider.GetAllStudents().Where(x => model.studentIDs.Contains(x.Id)).ToList();
            var teachers = DataProvider.GetAllTeahers().Where(x => model.teacherIDs.Contains(x.Id)).ToList();

            if((students.Count()+teachers.Count()) <= 0) 
            {
                return Json(new { isSuccess = false });
            }

            StudentTeacherVM VM = new();

            VM.students = students;
            VM.teachers = teachers;

          

            return Json(new {isSuccess=true, value = VM});


        }

        public IActionResult Privacy()
        {           

            var VM = new StudentTeacherVM();

            VM.students = DataProvider.GetAllStudents();
            VM.teachers = DataProvider.GetAllTeahers();

            return View(VM);
        }

        public IActionResult StudentInfo()
        {
            //Burada Ajax kullanacağız.
            return View();

        }

        [HttpPost]
        public IActionResult StudentInfo(int ID)
        {
            //StudenInfo'nun Index'inde Tetiklenen Ajax.
            //List<Student> Students = new List<Student>
            //{
            //    new Student{Id=1,Name="John",Surname="Doe",Age=22,City="London",StudentNumber=1171},
            //    new Student{Id=2,Name="Nancy",Surname="Davalio",Age=20,City="Paris",StudentNumber=1053},
            //    new Student{Id=3,Name="David",Surname="Davis",Age=21,City="Ankara",StudentNumber=1253},
            //    new Student{Id=4,Name="Frank",Surname="Sinatra",Age=18,City="Amsterdam",StudentNumber=53},
            //    new Student{Id=5,Name="Elton",Surname="John",Age=23,City="Stockholm",StudentNumber=535},
            //};

            List<Student> Students = DataProvider.GetAllStudents();

            Student std = Students.Where(x => x.Id == ID).FirstOrDefault();        

            if (std != null)
            {
                return Json(new {isSuccess=true, std});
            }
            else
            {               
                return Json(new {isSuccess=false});
            }           
                        

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}