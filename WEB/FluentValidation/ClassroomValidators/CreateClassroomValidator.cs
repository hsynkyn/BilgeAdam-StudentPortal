using FluentValidation;
using WEB.Areas.Education.Models.ClassroomVM;
using WEB.Areas.Education.Models.CourseVM;

namespace WEB.FluentValidation.ClassroomValidators

{
    public class CreateClassroomValidator : AbstractValidator<CreateClassroomVM>
    {
        public CreateClassroomValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alan zorunludur").MaximumLength(100).WithMessage("100 karakter sınırını geçtiniz!!").MinimumLength(2).WithMessage("En az 2 karakter girmelisiniz!");

           

            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Bu alan zorunludur");

            RuleFor(x => x.EndDate).NotEmpty().WithMessage("Bu alan zorunludur").GreaterThanOrEqualTo(x => x.StartDate).WithMessage("Bitiş tarihi başlangıç tarihinden önce yada aynı olamaz");

            RuleFor(x => x.TeacherId).NotEmpty().WithMessage("Bu alan zorunludur");


        }
    }
}
