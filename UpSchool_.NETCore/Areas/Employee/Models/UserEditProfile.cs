using Microsoft.AspNetCore.Http;

namespace UpSchool_.NETCore.Areas.Employee.Models
{
    public class UserEditProfile
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        //Dosya formatı için
        //Dosya yolu olarak değil direk görsel olarak tutulacak
        public IFormFile Image { get; set; }
    }
}
