using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using UpSchool.BusinessLayer.Abstract;
using UpSchool_.NETCore.DTOLayer.SupplierDTOs;

namespace UpSchool_.NETCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddContact(ContactAddDto model)
        {
            if(ModelState.IsValid)
            {
                _contactService.TInsert(new UpSchool.EntityLayer.Concrete.Contact()
                {
                    Name = model.Name,
                    Mail = model.Mail,
                    Content = model.Content,
                    Subject = model.Subject,
                    Date = DateTime.Parse(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
