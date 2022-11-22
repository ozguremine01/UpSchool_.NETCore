using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UpSchool.BusinessLayer.Abstract;

namespace UpSchool_.NETCore.Controllers
{
    [AllowAnonymous]
    public class AnnouncementController: Controller
    {
        private readonly IAnnouncementService _announcementService;

        
        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var values = _announcementService.TGetList();
            return View(values);
        }
    }
}
