using FluentValidation;
using WEB.Areas.Admin.Models.RoleVM;

namespace WEB.FluentValidation.RoleValidators
{
    public class UpdateRoleValidator : AbstractValidator<UpdateRoleVM>
    {
        public UpdateRoleValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alan zorunludur!").MaximumLength(250).WithMessage("250 karakter sınırı geçtiniz!").MinimumLength(2).WithMessage("En az 2 karakter girmelisiniz!");
        }
    }
}
