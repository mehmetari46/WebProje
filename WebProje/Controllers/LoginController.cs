using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
