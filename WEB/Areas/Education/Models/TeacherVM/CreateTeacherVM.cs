using System.ComponentModel.DataAnnotations;
using WEB.Areas.Education.Models.Abstract;

namespace WEB.Areas.Education.Models.TeacherVM
{
    public class CreateTeacherVM : BasePersonVM
    {
        [Display(Name ="İşe Giriş Tarihi: ")]
        public DateOnly? HireDate { get; set; }

        [Display(Name = "Ders: ")]
        public Guid? CourseId { get; set; }
    }
}
