using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.BusinessLayer.ValidationRules
{
    public class EmployeeValidator : AbstractValidator<Emploee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Personel adını boş geçemezsiniz");
            RuleFor(x => x.EmployeeSurname).NotEmpty().WithMessage("Personel soyadını boş geçemezsiniz");
            RuleFor(x => x.EmployeeName).MinimumLength(2).WithMessage("En az 2 karakter giriniz");
            RuleFor(x => x.EmployeeName).MaximumLength(20).WithMessage("En fazla 20 karakter giriniz");
        }
    }
}
