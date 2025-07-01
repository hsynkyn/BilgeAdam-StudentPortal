using System.ComponentModel.DataAnnotations;

namespace WEB.Areas.Admin.Models.RoleVM
{
    public class UpdateRoleVM
    {
        public Guid Id { get; set; }
        [Display(Name = "Rol Adı")]
        public string? Name { get; set; }
    }
}
