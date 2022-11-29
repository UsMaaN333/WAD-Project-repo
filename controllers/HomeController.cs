using Microsoft.AspNetCore.Mvc;

namespace WAD_SRMS_Project.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Adminlogin()
        {
            return View();
        }
        public IActionResult signup()
        {
            return View();
        }
        public IActionResult Addmission()
        {
            return View();
        }
    }
}
