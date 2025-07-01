using System.ComponentModel.DataAnnotations;

namespace WEB.Areas.Education.Models.ClassroomVM
{
    public class CreateClassroomVM
    {
        [Display(Name="Sınıf Adı")]
        public string? Name { get; set; }

        

        [Display(Name = "Başlangıç Tarihi")]
        public DateOnly? StartDate { get; set; }

        [Display(Name = "Bitiş Tarihi")]
        public DateOnly? EndDate { get; set; }

        [Display(Name = "Eğitmen")]
        public Guid? TeacherId { get; set; }
    }
}
