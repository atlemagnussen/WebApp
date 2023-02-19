using WebApp.Data;
using WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebApp.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ReportsController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReportYourSighting()
        {
            return View();
        }

        public IActionResult SightingsArchive()
        {
            IEnumerable<Sighting> reports = _db.Sightings;
               
            return View(reports);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(Sighting sighting) 
        {
            _db.Sightings.Add(sighting);
            _db.SaveChanges();

            return RedirectToAction("SightingsArchive");
        }
    }
}
