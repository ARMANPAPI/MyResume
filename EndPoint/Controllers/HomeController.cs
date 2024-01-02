using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
