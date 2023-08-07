using Microsoft.AspNetCore.Mvc;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class SahiplenmeController : Controller
    {
        private readonly dbContext _dbContext;
        public SahiplenmeController(dbContext context)
        {
            _dbContext = context;

        }
        public IActionResult Index()
        {
            ViewBag.SuccessMessage = "";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ModelSahiplen modelsahip)
        {
            if (ModelState.IsValid)
            {
                _dbContext.ModelSahiplen.Add(modelsahip);
                await _dbContext.SaveChangesAsync();
                ViewBag.SuccessMessage = "Hayvan sahiplenme isteği gönderildi";
                return View("Index", modelsahip);
            }
            return View();
        }
    }
}
