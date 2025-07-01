using System.ComponentModel.DataAnnotations;

namespace WEB.Models.ViewModels.AccountVM
{
    public class ResetPasswordVM
    {
        public string? Token { get; set; }
        public string? Email { get; set; }

        [Display(Name = "Yeni Şifre")]
        public string? NewPassword { get; set; }

        [Display(Name = "Yeni Şifre Tekrar")]
        public string? CheckNewPassword { get; set; }

    }
}
