using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Linq;
using UpSchool.DataAccessLayer.Concrete;
using UpSchool_.NETCore.Models;

namespace UpSchool_.NETCore.Controllers
{
    [AllowAnonymous]
    public class ReportController : Controller
    {
        //Static Excel Listesi


        public IActionResult ReportList()
        {
            return View();
        }
        public IActionResult ExcelStaticList()
        {
            ExcelPackage package = new ExcelPackage();
            var workSheet = package.Workbook.Worksheets.Add("Sayfa1");
            workSheet.Cells[1, 1].Value = "Personel ID";
            workSheet.Cells[1, 2].Value = "Personel Adı";
            workSheet.Cells[1, 3].Value = "Personel Soyadı";

            workSheet.Cells[2, 1].Value = "0001";
            workSheet.Cells[2, 2].Value = "Tuba";
            workSheet.Cells[2, 3].Value = "Zorlu";

            workSheet.Cells[2, 1].Value = "0002";
            workSheet.Cells[2, 2].Value = "Serap";
            workSheet.Cells[2, 3].Value = "Beran";

            var bytes = package.GetAsByteArray();

            //Google Chrome'da bu aratıldığında -> Excel content type -> MimeType değeri alınır.
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "personeller.xlsx");

        }

        public List<CustomerViewModel> CustomerList()
            {
            List<CustomerViewModel> customerViewModels = new List<CustomerViewModel>();
            using (var context = new Context())
            {
                customerViewModels = context.Customers.Select(x => new CustomerViewModel
                {
                    Mail= x.CustomerMail,
                    Name= x.CustomerName,
                    Surname = x.CustomerSurname,
                    Phone = x.CustomerPhone,
                }).ToList();
            }
            return customerViewModels;
            }
        public IActionResult DynamicExcel()
        {
            return View();
        }
    }
}

// Herhangi bir döviz kuru sitesinden son 1 aya ait dolar ve euro kurlarını çekip, en yüksek 5 güne ait kur bilgisini bir excel dosyasına aktaran uygulama .net core
//En yüksek 5 güne ait kur bilgisini bir grafiğe aktarıp, grafiği excele yansıtan kodu yazın