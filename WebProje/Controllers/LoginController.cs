using Microsoft.AspNetCore.Mvc;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class LoginController : Controller
    {
        private readonly dbContext _dbContext;


        public LoginController(dbContext context)
        {
            _dbContext = context;

        }
        public IActionResult Index()
        {
            ViewBag.ErrorMessage = "";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string email, string key)
        {


            foreach (var item in _dbContext.Login)
            {
                Console.WriteLine(item.E_Mail);
                if (item.E_Mail.ToString() == email && item.password.ToString() == key)
                {
                    if (item.User_ID == 1)
                    {
                        return RedirectToAction("Index", "Admin");
                    }

                    return RedirectToAction("Index", "Animal");
                }
                else
                {
                    ViewBag.ErrorMessage = "HATALI E-MAİL VEYA SİFRE"; // Hata mesajı
                }
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Login modelRegister)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Login.Add(modelRegister);
                await _dbContext.SaveChangesAsync();
                ViewBag.SuccessMessage = "Kayıt Başarılı";
                return View("Index", modelRegister);
            }
            return View("Index");
        }
    }
}
