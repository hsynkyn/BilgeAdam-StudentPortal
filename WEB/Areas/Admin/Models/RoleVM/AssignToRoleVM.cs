using Core.IdentityEntities;

namespace WEB.Areas.Admin.Models.RoleVM
{
    public class AssignToRoleVM
    {
        public required string RoleName { get; set; }

        public List<GetUserForRoleVM> HasRole { get; set; } = [];
        public List<GetUserForRoleVM> HasNotRole { get; set; } = [];

        public string[] AddIds { get; set; } = [];
        public string[] DeleteIds { get; set; } = [];
    }
}
