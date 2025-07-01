using System.ComponentModel.DataAnnotations;
using WEB.Areas.Education.Models.Abstract;

namespace WEB.Areas.Education.Models.TeacherVM
{
    public class UpdateTeacherVM : BasePersonVM
    {
        public Guid Id { get; set; }

        [Display(Name ="İşe Giriş Tarhi: ")]
        public DateOnly? HireDate { get; set; }

        [Display(Name = "Ders: ")]
        public Guid? CourseId { get; set; }

    }
}
