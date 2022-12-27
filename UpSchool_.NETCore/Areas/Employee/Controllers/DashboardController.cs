using Microsoft.AspNetCore.Mvc;

namespace UpSchool_.NETCore.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class DashboardController : Controller
    {      
        public IActionResult Index()
        {
            return View();
        }
    }
}
