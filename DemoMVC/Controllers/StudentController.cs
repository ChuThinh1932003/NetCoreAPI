using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string StudentId, string FullName)
        {
            ViewBag.message = StudentId + "-" + FullName;
            return View();
        }
    }
}