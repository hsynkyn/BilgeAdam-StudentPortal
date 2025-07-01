using FluentValidation;
using WEB.Areas.Education.Models.StudentVM;

namespace WEB.FluentValidation.StudentValidators
{
    public class UpdateStudentValidator : AbstractValidator<UpdateStudentVM>
    {
        public UpdateStudentValidator()
        {
            RuleFor(x => x.FirstName)
   .NotEmpty()
   .WithMessage("Bu alan zorunludur!")
   .MaximumLength(100)
   .WithMessage("100 karakter sınırını geçtiniz!")
   .MinimumLength(2)
   .WithMessage("En az 2 karakter girmelisiniz");

            RuleFor(x => x.LastName)
               .NotEmpty()
               .WithMessage("Bu alan zorunludur!")
               .MaximumLength(100)
               .WithMessage("100 karakter sınırını geçtiniz!")
               .MinimumLength(2)
               .WithMessage("En az 2 karakter girmelisiniz");

            RuleFor(x => x.Email)
               .NotEmpty()
               .WithMessage("Bu alan zorunludur!")
               .EmailAddress()
               .WithMessage("Lütfen doğru formatta giriş yapınız. ÖRN: example@example.com");


            RuleFor(x => x.Birthdate)
               .NotEmpty()
               .WithMessage("Bu alan zorunludur!");

            RuleFor(x => x.RegisterPrice)
              .NotEmpty()
              .WithMessage("Bu alan zorunludur!").GreaterThan(0).WithMessage("0'dan büyük bir değer girmelisiniz");

            RuleFor(x => x.ClassroomId)
             .NotEmpty()
             .WithMessage("Bu alan zorunludur!");
        }
    }
}
