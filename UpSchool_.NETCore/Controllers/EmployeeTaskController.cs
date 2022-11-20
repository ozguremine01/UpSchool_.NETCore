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
        public EmployeeTaskController(UserManager<AppUser> userManager)
        {
            
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTask()
        {
            List<SelectListItem> categoryvalues = ((List<SelectListItem>)(from x in _userManager.Users.ToList() select new SelectListItem
            {
                Text = x.Name+ " "+ x.Surname

            }));;
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(EmployeeTask employeeTask)
        {
            employeeTask.Status ="Görev Atandı";
            employeeTask.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //_employeeService.TInsert(employeeTask);
            return RedirectToAction("Index");
        }
    }
}
