using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admin_Kabul()
        {
            return View();
        }
        public IActionResult Admin_Users()
        {
            return View();
        }
    }
}
