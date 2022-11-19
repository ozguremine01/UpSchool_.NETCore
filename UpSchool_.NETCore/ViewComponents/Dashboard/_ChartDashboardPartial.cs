using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UpSchool_.NETCore.Models;

namespace UpSchool_.NETCore.ViewComponents.Dashboard
{
    public class _ChartDashboardPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
