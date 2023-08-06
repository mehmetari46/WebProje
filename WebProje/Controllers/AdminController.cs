using Microsoft.AspNetCore.Mvc;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class AdminController : Controller
    {
        private readonly dbContext _dbContext;


        public AdminController(dbContext context)
        {
            _dbContext = context;

        }
        public IActionResult Index()
        {
            ViewData["Login"] = _dbContext.Login.ToList();
            return View();
        }
        public IActionResult Admin_Kabul()
        {
            return View();
        }
        public IActionResult Admin_Users()
        {
            List<Login> users = _dbContext.Login.ToList();
            return View(users);
        }

    }
}
