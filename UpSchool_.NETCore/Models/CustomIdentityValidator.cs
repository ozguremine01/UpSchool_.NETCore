using Microsoft.AspNetCore.Identity;

namespace UpSchool_.NETCore.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PaswordTooShort",
                Description = $"Şifre en az {length} karakter olmalıdır."
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiredLower",
                Description = "Lütfen en az 1 tane küçük harf giriniz."

            };

        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiredUpper",
                Description = "Lütfen en az 1 tane büyük harf giriniz."

            };

        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiredDigit",
                Description = "Lütfen en az 1 tane sayı giriniz."

            };

        }

        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = "DuplicateEmail",
                Description = $"ilgili mail adresi: {email} zaten sistemde mevcut, lütfen farklı bir mail adresi ile kayıt olun"
            };
        }
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError()
            {
                Code = "DuplicateUserName",
                Description = $"ilgili kullanıcı adı: {userName} zaten sistemde mevcut, lütfen farklı bir kullanıcı adı ile kayıt olun"
            };
        }
    }
}
