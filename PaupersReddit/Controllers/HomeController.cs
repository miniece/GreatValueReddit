using Microsoft.AspNetCore.Mvc;
using PaupersReddit.Models;
using System.Diagnostics;

namespace PaupersReddit.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        RDAL api = new RDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PostView()
        {
            SWPost sp = api.GetPost();

            return View(sp);
        }

        public IActionResult Privacy()
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