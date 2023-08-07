using Microsoft.AspNetCore.Mvc;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class TakipController : Controller
    {
        private readonly dbContext _dbContext;
        public TakipController(dbContext context)
        {
            _dbContext = context;

        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
