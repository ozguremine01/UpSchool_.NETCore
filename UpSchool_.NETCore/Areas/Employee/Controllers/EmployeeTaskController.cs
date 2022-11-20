using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UpSchool.BusinessLayer.Abstract;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool_.NETCore.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class EmployeeTaskController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmployeeTaskService _employeeTaskService;

        //[Area("Employee1")]

        public EmployeeTaskController(UserManager<AppUser> userManager, IEmployeeTaskService employeeTaskService)
        {
            _userManager = userManager;
            _employeeTaskService = employeeTaskService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //var taskList=_employeeTaskService
            return View(values);

        }
    }
}
