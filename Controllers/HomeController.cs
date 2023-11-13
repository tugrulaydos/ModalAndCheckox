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
        public IActionResult Index(AddDataAjaxModel personinfo)
        {
            if (personinfo.isStudent)
            {
                Student s1 = new()
                {
                    Id = personinfo.Id,
                    Name = personinfo.Name,
                    Surname = personinfo.Surname,
                    Age = personinfo.Age,
                    City = personinfo.City,
                };

                DataProvider.AddDataToStudentList(s1);
                return Json(new { isSuccess = true });
            }

            if (!personinfo.isStudent) 
            {
                Teacher t1 = new()
                {
                    Id = personinfo.Id,
                    Name = personinfo.Name,
                    Surname = personinfo.Surname,
                    Age = personinfo.Age,
                    City = personinfo.City,
                };

                DataProvider.AddDataToTeacherList(t1);
                return Json(new { isSuccess = true });
            }


            return Json(new { isSuccess = false });
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

            StudentTeacherVM VM = new();

            VM.students = students;
            VM.teachers = teachers;          

            return Json(new {value = VM});
        }
      

        public IActionResult StudentInfo()
        {
            
            return View();

        }

        [HttpPost]
        public IActionResult StudentInfo(int ID)
        {           
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