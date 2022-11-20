using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UpSchool_.NETCore.Models;

namespace UpSchool_.NETCore.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class ChartController : Controller
    {
        List<DepartmanSalary> salaryList = new List<DepartmanSalary>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DepartmanChart()
        {
            salaryList.Add(new DepartmanSalary
            {
                departmanname = "Muhasebe",
                salaryavg = 10000
            });
            salaryList.Add(new DepartmanSalary
            {
                departmanname = "IT",
                salaryavg = 20000
            });
            salaryList.Add(new DepartmanSalary
            {
                departmanname = "Satis",
                salaryavg = 10000
            });

            return Json(new { jsonList = salaryList });
        }
    }
}
