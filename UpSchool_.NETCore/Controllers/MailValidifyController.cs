using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UpSchool_.NETCore.Controllers
{
    [AllowAnonymous]
    public class MailValidifyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
