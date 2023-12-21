using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail)
                .NotEmpty().WithMessage("Mail alanı boş geçilemez");

            RuleFor(x => x.Subject)
               .NotEmpty().WithMessage("Konu alanı boş geçilemez")
               .MinimumLength(3).WithMessage("Konu alanı en az 3 karakter olmalı")
               .MaximumLength(100).WithMessage("Konu alanı en fazla 100 karakter olmalı");

            RuleFor(x => x.MessageBody)
               .NotEmpty().WithMessage("Mesaj alanı boş geçilemez")
               .MinimumLength(10).WithMessage("Mesaj alanı en az 10 karakter olmalı")
               .MaximumLength(255).WithMessage("Mesaj alanı en fazla 255 karakter olmalı");


        }
    }
}
