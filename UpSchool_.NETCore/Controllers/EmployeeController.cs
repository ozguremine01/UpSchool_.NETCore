using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UpSchool.BusinessLayer.Abstract;
using UpSchool.BusinessLayer.ValidationRules;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool_.NETCore.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var values = _employeeService.TGetEmploeeBy();
            return View(values);
        }

        [HttpGet]

        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Emploee emploee)
        {
            EmployeeValidator validationRules = new EmployeeValidator();
            ValidationResult result = validationRules.Validate(emploee);
            if(result.IsValid)
            {
                _employeeService.TInsert(emploee);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }
            return View();
        }

        public IActionResult DeleteEmployee(int id)
        {
            var values = _employeeService.TGetByID(id);
            _employeeService.TDelete(values);
            return RedirectToAction("Index");

        }


    }
}
