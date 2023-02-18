using WebApp.Data;
using WebApp.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
