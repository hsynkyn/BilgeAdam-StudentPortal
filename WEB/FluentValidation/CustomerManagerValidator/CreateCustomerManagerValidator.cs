using FluentValidation;
using WEB.Areas.Education.Models.TeacherVM;

namespace WEB.FluentValidation.CustomerManagerValidator
{
    public class CreateCustomerManagerValidator: AbstractValidator<CreateTeacherVM>
    {
        public CreateCustomerManagerValidator()
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

            RuleFor(x => x.HireDate)
              .NotEmpty()
              .WithMessage("Bu alan zorunludur!");

            
        }
    }
}
