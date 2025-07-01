using FluentValidation;
using WEB.Areas.Admin.Models.RoleVM;

namespace WEB.FluentValidation.RoleValidators
{
    public class CreateRoleValidator : AbstractValidator<CreateRoleVM>
    {
        public CreateRoleValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alan zorunludur!").MaximumLength(250).WithMessage("250 karakter sınırı geçtiniz!").MinimumLength(2).WithMessage("En az 2 karakter girmelisiniz!");
        }
    }
}
