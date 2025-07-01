using FluentValidation;
using WEB.Models.ViewModels.AccountVM;

namespace WEB.FluentValidation.AccountValidators
{
    public class CreatePasswordValidator : AbstractValidator<ResetPasswordVM>
    {
        public CreatePasswordValidator()
        {

            RuleFor(x => x.NewPassword).NotEmpty().WithMessage("Bu alan zorunludur!!").MaximumLength(10).WithMessage("En fazla 10 karakter girmelisiniz!!").MinimumLength(2).WithMessage("En az 2 karakter girmelisiniz!!");

            RuleFor(x => x.CheckNewPassword).NotEmpty().WithMessage("Bu alan zorunludur!!").Equal(x => x.NewPassword).WithMessage("Şifreler eşleşmiyor!!");
        }
    }
}
