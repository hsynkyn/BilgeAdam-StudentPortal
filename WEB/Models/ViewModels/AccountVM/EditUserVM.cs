using System.ComponentModel.DataAnnotations;

namespace WEB.Models.ViewModels.AccountVM
{
    public class EditUserVM
    {
        public Guid Id { get; set; }
        [Display(Name ="Ad")]
        public string? FirstName { get; set; }
        [Display(Name = "Soyad")]
        public  string? LastName { get; set; }
        [Display(Name = "E-mail")]
        public  string? Email { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public  string? UserName { get; set; }
        [Display(Name = "Şifre")]
        public string? Password { get; set; }
    }
}
