using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool_.NETCore.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //appUser.PasswordHash
        [HttpPost]
        public async Task <IActionResult> Index(AppUser appUser)
        {
            var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.PasswordHash, false, true);
            //result.Succeeded -> email ve password'un eşleştiğinin kontrolü
            if (result.Succeeded && appUser.EmailConfirmed== true)
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }
        
    }
}
