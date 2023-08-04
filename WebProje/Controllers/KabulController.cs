using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class KabulController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
