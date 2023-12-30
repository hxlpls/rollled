using Microsoft.AspNetCore.Mvc;

namespace webtasarim.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
