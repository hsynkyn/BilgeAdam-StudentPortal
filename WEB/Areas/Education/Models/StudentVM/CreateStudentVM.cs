using System.ComponentModel.DataAnnotations;
using WEB.Areas.Education.Models.Abstract;

namespace WEB.Areas.Education.Models.StudentVM
{
    public class CreateStudentVM : BasePersonVM
    {

        [Display(Name = "Resim")]
        public IFormFile? Image { get; set; }

        [Display(Name ="Resim")]
        public required string? ImagePath { get; set; }              

        [Display(Name = "Kayıt Ücreti")]
        public required double RegisterPrice { get; set; }
        [Display(Name = "Sınıf")]
        public required Guid ClassroomId { get; set; }

        [Display(Name = "Eğitmen")]
        public Guid? TeacherId { get; set; }
        [Display(Name = "Kurs")]
        public Guid? CourseId { get; set; }
    }
}
