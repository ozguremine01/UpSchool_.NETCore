using Microsoft.AspNetCore.Mvc;
using UpSchool.BusinessLayer.Abstract;

namespace UpSchool_.NETCore.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class EmployeeTaskDetailController : Controller
    {
        private readonly IEmployeeTaskDetailService _employeeTaskDetailService;

        public EmployeeTaskDetailController(IEmployeeTaskDetailService employeeTaskDetailService)
        {
            _employeeTaskDetailService = employeeTaskDetailService;
        }

        public IActionResult Index(int id)
        {
            var values= _employeeTaskDetailService.TGetEmployeeTaskDetailById(id);
            return View(values);
        }
    }
}
