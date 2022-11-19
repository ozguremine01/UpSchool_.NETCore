using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using UpSchool.EntityLayer.Concrete;
using UpSchool_.NETCore.Models;

namespace UpSchool_.NETCore.Areas
{
    [Area("Employee")]
    public class EmployeeProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public EmployeeProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditProfile userEditProfile = new UserEditProfile();
            userEditProfile.Name = values.Name;
            userEditProfile.Surname = values.Surname;
            userEditProfile.PhoneNumber = values.PhoneNumber;
            userEditProfile.Email = values.Email;
            return View(userEditProfile);
        }

        //1. Html tarafındaki kısıtlamalarla backend tarafındaki kısıtlar arasında ne fark var?
        //2. Değişkenlerin büyük harf ile başlayanla küçük harfle başlayan arasındaki farklar?

        [HttpPost]
        public async Task<IActionResult> Index(UserEditProfile p)
        {
            var user= await _userManager.FindByNameAsync(User.Identity.Name);
            if(p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/UserImages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);

                await p.Image.CopyToAsync(stream);
                user.ImageUrl = imageName;

            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.PhoneNumber = p.PhoneNumber;
            user.Email = p.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();

        }
    }
}
