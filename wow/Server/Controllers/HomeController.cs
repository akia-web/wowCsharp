using Microsoft.AspNetCore.Mvc;

namespace wow.Server.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
