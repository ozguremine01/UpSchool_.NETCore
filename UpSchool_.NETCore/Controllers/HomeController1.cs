using Microsoft.AspNetCore.Mvc;

namespace UpSchool_.NETCore.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
