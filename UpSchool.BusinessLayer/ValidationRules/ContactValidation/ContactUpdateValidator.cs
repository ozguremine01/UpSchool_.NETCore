using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool_.NETCore.DTOLayer.DTOs.ContactDTOs;

namespace UpSchool.BusinessLayer.ValidationRules.ContactValidation
{
    public class ContactUpdateValidator: AbstractValidator<ContactUpdateDto>
    {
        public ContactUpdateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad boş geçilemez.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail boş geçilemez.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu boş geçilemez.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik boş geçilemez.");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz.");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter giriniz.");

        }
    }
}
