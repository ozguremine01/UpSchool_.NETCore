using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.AnnouncementTitle).NotEmpty().WithMessage("Başlık alanını boş geçemezsiniz");
            RuleFor(x => x.AnnouncementContent).NotEmpty().WithMessage("İçerik alanını boş geçemezsiniz");
            RuleFor(x => x.AnnouncementTitle).MinimumLength(5).WithMessage("Başlık alanını boş geçemezsiniz");
            RuleFor(x => x.AnnouncementTitle).MaximumLength(20).WithMessage("Başlık alanını boş geçemezsiniz");
        }
    }
}
