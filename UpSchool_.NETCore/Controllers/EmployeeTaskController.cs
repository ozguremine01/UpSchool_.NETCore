using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool.BusinessLayer.Abstract;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool_.NETCore.Controllers
{
    public class EmployeeTaskController : Controller
    {
        
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmployeeTaskService _employeeTaskService;
        public EmployeeTaskController(UserManager<AppUser> userManager, IEmployeeTaskService employeeTaskService)
        {
            _userManager = userManager;
            _employeeTaskService = employeeTaskService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTask()
        {
            //var categoryvalues = (List<SelectListItem>)(from x in _userManager.Users.ToList() select new SelectListItem
            //{
            //    Text = x.Name + " " + x.Surname

            //});

            List<SelectListItem> categoryValues = (from x in _userManager.Users.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name + " " + x.Surname,
                                                       Value = x.Id.ToString()
                                                   }).ToList();

            ViewBag.v = categoryValues;

            return View();
        }

        [HttpPost]
        public IActionResult AddTask(EmployeeTask employeeTask)
        {
            employeeTask.Status ="Görev Atandı";
            employeeTask.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _employeeTaskService.TInsert(employeeTask);
            return RedirectToAction("Index");
        }
    }
}
