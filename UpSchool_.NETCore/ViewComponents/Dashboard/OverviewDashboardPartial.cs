using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UpSchool.DataAccessLayer.Concrete;

namespace UpSchool_.NETCore.ViewComponents.Dashboard
{
    public class OverviewDashboardPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using (var context = new Context())
            {
                //Context'e bağlı propertyler gelir.
                //Eğer using in parantezi süslü parantezden sonra olursa

                ViewBag.EmployeeCount = context.Emploees.Count();
                ViewBag.EmployeeWomanGenderCount = context.Users.Where(x => x.Gender == "Kadın");
                //ViewBag.LastUser = context.Users.Where(x=>x.);
                int id = context.Users.Max(x => x.Id);
                ViewBag.LastUser = context.Users.Where(x=>x.Id == id).Select(x=>x.Name+" "+ x.Surname).FirstOrDefault();
                
            }
                return View();
        }
    }
}
