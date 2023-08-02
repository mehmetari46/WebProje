using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateDelete()
        {
            return View();
        }
    }
}
