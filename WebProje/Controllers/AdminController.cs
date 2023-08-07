using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
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
            ViewData["ModelSahiplen"] = _dbContext.ModelSahiplen.ToList();
            ViewData["ModelHayvanKabul"] = _dbContext.modelHayvanKabul.ToList();
            List<ModelSahiplen> owners = _dbContext.ModelSahiplen.ToList();
            return View(owners);
        }
        public IActionResult Admin_Kabul()
        {
            List<ModelHayvanKabul> kabul = _dbContext.modelHayvanKabul.ToList();
            return View(kabul);
        }
        public IActionResult Admin_Users()
        {
            List<Login> users = _dbContext.Login.ToList();
            return View(users);
        }
        public IActionResult Animals()
        {
            List<ModelHayvanKabul> kabul = _dbContext.modelHayvanKabul.ToList();
            return View(kabul);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var Login = await _dbContext.Login
                .FirstOrDefaultAsync(m => m.User_ID == id);
            return View(Login);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var deluser = await _dbContext.Login.FindAsync(id);
            if (deluser == null)
            {
                return NotFound();
            }

            _dbContext.Login.Remove(deluser);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Admin_Users", "Admin");
        }
        public async Task<IActionResult> EditAnimal(int? id)
        {
            if (id == null || _dbContext.modelHayvanKabul == null)
            {
                return NotFound();
            }

            var animals = await _dbContext.modelHayvanKabul.FindAsync(id);
            if (animals == null)
            {
                return NotFound();
            }
            return View(animals);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAnimal(ModelHayvanKabul animals)
        {
            if (ModelState.IsValid)
            {

                _dbContext.Update(animals);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction("Animals", "Admin");
            }
            return View(animals);
        }

    }
}
