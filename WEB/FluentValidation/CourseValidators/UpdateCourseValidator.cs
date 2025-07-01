using FluentValidation;
using WEB.Areas.Education.Models.CourseVM;

namespace WEB.FluentValidation.CourseValidators
{
    public class UpdateClassroomValidator : AbstractValidator<UpdateCourseVM>
    {
        public UpdateClassroomValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alan zorunludur").MaximumLength(30).WithMessage("30 karakter sınırını geçtiniz!!").MinimumLength(2).WithMessage("En az 2 karakter girmelisiniz!");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Bu alan zorunludur").MaximumLength(200).WithMessage("200 karakter sınırını geçtiniz!!").MinimumLength(2).WithMessage("En az 2 karakter girmelisiniz!");

            RuleFor(x => x.TotalHour).NotEmpty().WithMessage("Bu alan zorunludur!!");
        }
    }
}
