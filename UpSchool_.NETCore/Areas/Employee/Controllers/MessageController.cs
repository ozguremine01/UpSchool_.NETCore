using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Linq;
using System.Net.Mail;
//using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using UpSchool.BusinessLayer.Abstract;
using UpSchool.DataAccessLayer.Concrete;
using UpSchool.EntityLayer.Concrete;
using UpSchool_.NETCore.Areas.Employee.Models;

namespace UpSchool_.NETCore.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly UserManager<AppUser> _userManager;
        public MessageController(IMessageService messageService, UserManager<AppUser> userManager)
        {
            _messageService = messageService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> SendMessage()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Message message)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            using (var context = new Context())
            {
                message.ReceiverName = context.Users.Where(x => x.Email == message.RecevierMail).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            }
            message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message.SenderEmail = user.Email;
            message.SenderName = user.Name + " " + user.Surname;
            _messageService.TInsert(message);
            return RedirectToAction("SendMessage");
        }

        /*
        [HttpGet]

        public async Task<IActionResult> SendMessage()
        {
           
            return View();
        }
        */
        [HttpPost]
        public async Task<IActionResult> SendMessage(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressfrom = new MailboxAddress("Admin", "deneme@deneme.com");
            mimeMessage.From.Add(mailboxAddressfrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("kullanici", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.MailContent;

            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = mailRequest.MailSubject;

            //SmtpClient smtpClient = new SmtpClient();
            //smtpClient.Connect("smtp.gmail.com", 587, false);
            //smtpClient.Authenticate("deneme@deneme.com", "key değeri(Google app passwordden alınıyor)");
            //smtpClient.Send(mimeMessage);
            //smtpClient.Disconnect(true);

            return View();
        }
    }
}
