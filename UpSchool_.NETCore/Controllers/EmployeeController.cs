﻿using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;
using UpSchool.BusinessLayer.Abstract;
using UpSchool.BusinessLayer.ValidationRules;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool_.NETCore.Controllers
{
    //100 derste MVC Youtube'tan izle ninject container ekle
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly ICategoryService _categoryService;
        public EmployeeController(IEmployeeService employeeService, ICategoryService categoryService)
        {
            _employeeService = employeeService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _employeeService.TGetEmployeesByCategory();
            //var values = _employeeService.TGetEmploeeBy();
            //return View(values);
            return View(values);  
        }

        [HttpGet]

        public IActionResult AddEmployee()
        {
            List<SelectListItem> categoryValues = (from x in _categoryService.TGetList() select new SelectListItem
                {
                Text = x.CategoryName, 
                Value = x.CategoryID.ToString()
            }).ToList();
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
        
        public IActionResult ChangeStatusToFalse(int id)
        {
            _employeeService.TChangeEmployeeStatusToFalse(id);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToTrue(int id)
        {
            _employeeService.TChangeEmployeeStatusToTrue(id);
            return RedirectToAction("Index");
        }
        

        [HttpGet]
        public IActionResult UpdateEmployee(int id)
        {
            var values = _employeeService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateEmployee(Emploee emploee)
        {
            var values = _employeeService.TGetByID(emploee.EmployeeID);
            emploee.EmployeeStatus = values.EmployeeStatus;
            _employeeService.TUpdate(values);
            return RedirectToAction("Index");

        }
    }
}
