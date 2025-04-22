using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
