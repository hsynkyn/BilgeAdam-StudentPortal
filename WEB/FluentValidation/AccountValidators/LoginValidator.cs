using FluentValidation;
using WEB.Models.ViewModels.AccountVM;

namespace WEB.FluentValidation.AccountValidators
{
    public class LoginValidator : AbstractValidator<LoginVM>
    {
        public LoginValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Bu alan zorunludur").MaximumLength(100).WithMessage("100 karakter sınırını geçtiniz!!");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Bu alan zorunludur").MaximumLength(10).WithMessage("10 karakter sınırını geçtiniz!!");
        }
    }
}
