using FluentValidation;
using WEB.Models.ViewModels.AccountVM;

namespace WEB.FluentValidation.AccountValidators
{
    public class EditUserValidator : AbstractValidator<EditUserVM>
    {
        public EditUserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Bu alan zorunludur!!").MaximumLength(50).WithMessage("50 karakter sınırını aştınız!!").MinimumLength(2).WithMessage("En az 2 karakter kullanmalısınız!!");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Bu alan zorunludur!!").EmailAddress().WithMessage("Email formatında giriş yapınız. Örn: example@example.com");

            RuleFor(x => x.Password).MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz!!").When(x => !string.IsNullOrEmpty(x.Password));


        }
    }
}
