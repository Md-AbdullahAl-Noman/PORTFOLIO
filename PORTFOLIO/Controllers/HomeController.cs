using Microsoft.AspNetCore.Mvc;
using PORTFOLIO.Models;
using System.Diagnostics;

namespace PORTFOLIO.Controllers
{
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
        public IActionResult Education()
        {
            return View();
        } 
        public IActionResult Projects()
        {
            return View();
        } 
        public IActionResult References()
        {
            return View();
        }
        public IActionResult Personal()
        {
            return View();
        }


       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
