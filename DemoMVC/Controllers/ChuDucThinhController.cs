using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class ThinhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}