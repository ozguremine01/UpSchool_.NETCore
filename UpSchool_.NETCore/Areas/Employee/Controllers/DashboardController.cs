using Microsoft.AspNetCore.Mvc;

namespace UpSchool_.NETCore.Areas.Employee.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Employee")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
