

using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
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
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Müşteri Listesi");
                workSheet.Cell(1,1).Value="Mail Adresi";
                workSheet.Cell(1, 2).Value ="Müşteri Adı";
                workSheet.Cell(1, 3).Value ="Müşteri Soyadı";
                workSheet.Cell(1, 4).Value ="Müşteri Telefon";
                int rowCount = 2;
                foreach(var item in CustomerList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.Mail;
                    workSheet.Cell(rowCount, 2).Value = item.Name;
                    workSheet.Cell(rowCount, 3).Value = item.Surname;
                    workSheet.Cell(rowCount, 4).Value = item.Phone;
                    rowCount++;


                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                        return File(content,"","musteri_listesi.xlsx");
                }
            }
                
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "/wwwroot/PdfReports/" + "Musteri.pdf");
            var stream = new FileStream(path, FileMode.Create);
            /*
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Akbank & Up School Asp.Net Full Stack .Net Core Backend Proje");
            document.Add(paragraph);
            document.Close();
            return File("/PdfReports/Musteri.Pdf", "application/pdf", "Muster.pdf");
       */
            return View();
            }
    }
}

// Herhangi bir döviz kuru sitesinden son 1 aya ait dolar ve euro kurlarını çekip, en yüksek 5 güne ait kur bilgisini bir excel dosyasına aktaran uygulama .net core
// En yüksek 5 güne ait kur bilgisini bir grafiğe aktarıp, grafiği excele yansıtan kodu yazın
// File upload ile yüklediğiniz herhangi bir dosyası (resim, excel, pdf vs.) wwwroot klasörü yerine kendi Google Drive hesabınıza atan ve projenize ait görselleri bu drive linkindeki klasör/ dizinden çeken Core uygulaması
// Pdf dosyasını dinamik olarak tablodan alalım
//model state key değerinin boş olması ve olmaması
