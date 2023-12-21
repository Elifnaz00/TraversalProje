
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AnnouncementValidationRules
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementUpdateDto>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlığı boş geçmeyin");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen duyuru içeriğini boş geçmeyin");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Duyuru başlığı en az 5 karakter olmalı");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Duyuru içeriği en az 5 karakter olmalı");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Duyuru başlığı en fazla 50 karakter olmalı");
            RuleFor(x => x.Content).MinimumLength(500).WithMessage("Duyuru içeriği en az 500 karakter olmalı");
        }
    }
}
