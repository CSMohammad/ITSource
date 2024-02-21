using ITSource.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITSource.Controllers
{
    public class HomeController : Controller //inherts from class:controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)//DB injection
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult trainers()
        { return View(); }  //rasor file view
        public IActionResult SoftwareEngineering()
            //IActionResult : it is a interface , can return the type of content 
        {
            return View();
        }
        public IActionResult ArtificialIntelligence() //IActionResult : it is a interface , can return the type of content 
        {
            return View();
        }
        public IActionResult ComputerScience() //IActionResult : it is a interface , can return the type of content 
        {
            return View();
        }
        public IActionResult CyberSecurity() //IActionResult : it is a interface , can return the type of content 
        {
            return View();
        }

        public IActionResult Databases()
        {
            return View();
        }
        public IActionResult Algo()
        {
            return View();
        }
        public IActionResult Web1()
        {
            return View();
        }
        public IActionResult Datastructures()
        {
            return View();
        }
        public IActionResult Web2()
        {
            return View();
        }
        public IActionResult CyberBasics()
        {
            return View();
        }
        public IActionResult IntroAi()
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
