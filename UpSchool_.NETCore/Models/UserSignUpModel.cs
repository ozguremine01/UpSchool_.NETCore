using System.ComponentModel.DataAnnotations;

namespace UpSchool_.NETCore.Models
{
    public class UserSignUpModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı adını giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen emailinizi giriniz")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir mail giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen emailinizi giriniz")]
        [Compare("Password", ErrorMessage ="şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
