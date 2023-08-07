using Microsoft.AspNetCore.Mvc;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class KabulController : Controller
    {
        private readonly dbContext _dbContext;


        public KabulController(dbContext context)
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
        public async Task<IActionResult> Index(ModelHayvanKabul modelkabul)
        {
            if (ModelState.IsValid)
            {
                _dbContext.modelHayvanKabul.Add(modelkabul);
                await _dbContext.SaveChangesAsync();
                ViewBag.SuccessMessage = "Hayvan kabul isteği gönderildi";
                return View("Index", modelkabul);
            }
            return View();
        }
    }
}
