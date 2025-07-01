using System.ComponentModel.DataAnnotations;

namespace WEB.Areas.Admin.Models.RoleVM
{
    public class CreateRoleVM
    {
        [Display(Name="Rol Adı")]
        public string? Name { get; set; }
    }
}
