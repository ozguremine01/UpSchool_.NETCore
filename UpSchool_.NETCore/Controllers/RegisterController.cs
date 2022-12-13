using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using MimeKit;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Linq;
using System.Net.Mail;
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
        //    var result = await _userManager.CreateAsync(appUser, appUser.PasswordHash);
        //    if (result.Succeeded)
        //    {
        //        return RedirectToAction("Index", "UserList");
        //    }

        //    return View();
        //}

        [HttpGet]
        public IActionResult EmailConfirmed()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EmailConfirmed(AppUser appUser)
        {
            var user = await _userManager.FindByEmailAsync(appUser.Email);
            if (user.LoginCharacter == appUser.LoginCharacter)
            {
                user.EmailConfirmed = true;

                var result = await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Index3()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index3(UserSignUpModel p)
        {
            Random random = new Random();
            int number = random.Next(100000, 999999);
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {

                    UserName = p.UserName,
                    Name = p.Name,
                    Surname = p.Surname,
                    Email = p.Email,
                    PhoneNumber = p.PhoneNumber,
                    LoginCharacter = number.ToString()

                };
                if (p.Password == p.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(appUser, p.Password);
                    if (result.Succeeded)
                    {
                        SendEmail(appUser.LoginCharacter);
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
                    ModelState.AddModelError("", "şifreler uyuşuyor");
                }
            }
            else
            {
                ModelState.AddModelError("", "deneme");
            }


            return View();

        }
        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }


        public void SendEmail(string emailcode)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "tulun.tuana60@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom); //Mailin kimden gönderildiği

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", "tulun.tuana60@gmail.com");
            mimeMessage.To.Add(mailboxAddressTo); //Mailin kime gönderileceği

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = emailcode;
            mimeMessage.Body = bodyBuilder.ToMessageBody(); //Gönderilecek mailin içeriği

            mimeMessage.Subject = "Üyelik Kaydı"; //Gönderilecek mailin başlığı
            /*
            SmtpClient smtp = new SmtpClient(); //SİMPLE MAİL TRANSFER PROTOCOL
            smtp.Connect("smtp.gmail.com", 587, false);
            smtp.Authenticate("tulun.tuana60@gmail.com", "pzvymftacjovndys");
            smtp.Send(mimeMessage);
            smtp.Disconnect(true);
            */
        }
    }
}
