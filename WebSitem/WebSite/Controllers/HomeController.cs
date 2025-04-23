using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebSite.Data.EfCore;


using WebSite.Models;

namespace WebSite.Controllers;

public class HomeController : Controller
{

    public readonly MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }
   

     public IActionResult Index()
        {
            return View();
        }

        [Route("hizmetlerim")]
        public IActionResult Services()
        {
            return View();
        }

        [Route("kariyerim")]
        public IActionResult Careers()
        {
            return View();
        }
		[Route("projelerim")]
		public IActionResult Projelerim()
		{
			return View();
		}

		[Route("sss")]
        public IActionResult SSS()
        {
            return View();
        }
		[Route("iletisim")]
		public IActionResult Iletisim()
		{
			return View();
		}
         [HttpPost]
        [Route("iletisim")]
        public async Task<IActionResult> Iletisim(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Mesajınız başarıyla gönderildi!";
                return RedirectToAction("Iletisim");
            }

            TempData["Error"] = "Bir hata oluştu. Lütfen tüm alanları doğru doldurun.";
            return View(user);
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
