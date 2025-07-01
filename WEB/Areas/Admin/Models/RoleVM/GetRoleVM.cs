using System.ComponentModel.DataAnnotations;

namespace WEB.Areas.Admin.Models.RoleVM
{
    public class GetRoleVM
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public required string UpdatedDate { get; set; }
        public required string Status { get; set; }
    }
}
