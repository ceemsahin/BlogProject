using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {

        public WriterValidator()
        {
            RuleFor(x => x.WriterNameSurname).NotEmpty().WithMessage("Yazar adı ve soyadı boş geçilemez").MinimumLength(2).WithMessage("En az 2(iki) Karakter giriniz");


            RuleFor(x => x.WriterEmail).NotEmpty().WithMessage("Mail adresi boş geçilemez").EmailAddress().WithMessage("Lütfen uygun email adresi giriniz.");


            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");

            RuleFor(p => p.WriterPassword).Matches(@"[A-Z]+").WithMessage("Sifre en az bir büyük harfden ibaret olmalıdır.");
            RuleFor(p => p.WriterPassword).Matches(@"[a-z]+").WithMessage("Sifre en az bir kicik harfden ibaret olmalıdır.");
            RuleFor(p => p.WriterPassword).Matches(@"[0-9]+").WithMessage("Sifre en az bir rakamdan ibaret olmalıdır.");



        }

    }
}
