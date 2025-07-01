using System.ComponentModel.DataAnnotations;

namespace WEB.Areas.Education.Models.Abstract
{
    public abstract class BasePersonVM
    {
        [Display(Name ="Ad")]
        public string? FirstName { get; set; }

        [Display(Name = "Soyad")]
        public  string? LastName { get; set; }

        [Display(Name = "E-Mail")]
        public  string? Email { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateOnly? Birthdate { get; set; }

        public string? FullName { get => FirstName + " " + LastName; }
    }
}
