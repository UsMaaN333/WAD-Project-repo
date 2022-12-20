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
        public IActionResult feedback(string username, string userpass)
        {
            if(username=="text" && userpass=="terxt")
            {
                ViewBag.Message = "login Successfully";
            }
            else
            {
                ViewBag.Message = "login not Successfully";
            }
            return View(Addmission);
        }
    }
}
