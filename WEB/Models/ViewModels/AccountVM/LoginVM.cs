using System.ComponentModel.DataAnnotations;

namespace WEB.Models.ViewModels.AccountVM
{
    public class LoginVM
    {
        [Display(Name ="Kullanıcı Adı")]
        public string? UserName { get; set; }

        [Display(Name = "Şifre")]
        public string? Password { get; set; }
    }
}
