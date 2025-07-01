using System.ComponentModel.DataAnnotations;

namespace WEB.Models.ViewModels.AccountVM
{
    public class ChangePasswordVM
    {
        public Guid Id { get; set; }

        [Display(Name = "Eski Şifre")]
        public string? OldPassword { get; set; }

        [Display(Name = "Yeni Şifre")]
        public string? NewPassword { get; set; }

        [Display(Name = "Yeni Şifre Tekrar")]
        public string? CheckNewPassword { get; set; }
    }
}
