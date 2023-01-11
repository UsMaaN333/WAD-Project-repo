using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WAD_SRMS_Project.controllers
{
    
    public class HomeController : Controller
    {
      
       
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
        public IActionResult Attedence()
        {
            return View();
        }
       
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult science()
        {
            return View();
        }
        public IActionResult technology()
        {
            return View();
        }
        public IActionResult Result()
        {
            return View();
        }
        public IActionResult Homepage()
        {
            return View();
        }


    }
}
