using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using System.Threading.Tasks;
using UpSchool.EntityLayer.Concrete;
using UpSchool_.NETCore.Models;

namespace UpSchool_.NETCore.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        
        private readonly UserManager<AppUser> _userManager;
        
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Index(AppUser appUser)
        //{
        //    var result = await _userManager.CreateAsync(appUser,appUser.PasswordHash); 
        //    if(result.Succeeded)
        //    {
        //        return RedirectToAction("Index", "UserList");  
        //    }

        //    return View();
        //}
        [HttpGet]
        public IActionResult Index3()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index3(UserSignUpModel p)
        {
                     
                  if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {

                    UserName = p.UserName,
                    Name = p.Name,
                    Surname = p.Surname,
                    Email = p.Email,
                    PhoneNumber = p.PhoneNumber
                };
                if (p.Password == p.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(appUser, p.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
               
            }
            else
            {
                ModelState.AddModelError("","şifreler uyuşuyor");
            }
            }
            else
            {
                ModelState.AddModelError("","deneme");
            }
                
            
            return View();
            
        }
        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }

    }
}
