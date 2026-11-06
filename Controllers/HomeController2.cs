using Microsoft.AspNetCore.Mvc;

namespace PersonalProfileApp.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
