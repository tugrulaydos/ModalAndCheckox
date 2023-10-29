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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}