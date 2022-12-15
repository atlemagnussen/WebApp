using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class LandingPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
