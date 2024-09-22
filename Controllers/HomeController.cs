using Microsoft.AspNetCore.Mvc;

namespace mvc_session1.Controllers
{
    public class HomeController : Controller
    {
        //GETALL
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUS()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContectUS()
        {
            return View();
        }
        
    }
}
