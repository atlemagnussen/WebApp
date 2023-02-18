using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Data;
using WebApp.Models;
using WebApp.Resources;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDBContext db)
        {
            _logger = logger;
            _db = db;

            foreach (var sighting in _db.Sightings)
                Debug.WriteLine(sighting);
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult History() 
        {
            return View();
        }

        public IActionResult ComingSoon()
        {
            return View();
        }

        public IActionResult ReportSighting() 
        {
            return View();
        }

        public IActionResult GoToEnglishPage()
        {
            St.InitializeLocalization("en-US");

            return RedirectToAction("Index");
        }

        public IActionResult GoToNorwegianPage()
        {
            St.InitializeLocalization("nb-NO");

            return RedirectToAction("Index");
        }
    }
}